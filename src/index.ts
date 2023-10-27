import fg from 'fast-glob'
import fs from 'fs-extra'
import * as path from 'node:path'
import ts from 'typescript'
import { getFileContent, preamble } from './converter.js'

const toolName = 'Types-C#-Conversion'

function convertFile(filename: string, targetDir: string): void {
  const program = ts.createProgram([filename], { allowJs: true })
  const sourceFile = program.getSourceFile(filename)!
  const targetFile = path.join(
    targetDir,
    `${path.basename(filename, `.d.ts`)}.cs`,
  )

  const types = getFileContent(sourceFile)
  console.log(`[${toolName}] Converted ${filename}`)

  const pagination = 300
  if (types.length < pagination) {
    fs.writeFileSync(targetFile, preamble + types.join('\n\n'))
    return
  }
  for (let i = 0; i * pagination < types.length; i++) {
    fs.writeFileSync(
      targetFile.replace('.cs', `.p${i}.cs`),
      preamble + types.slice(i * pagination, (i + 1) * pagination).join('\n\n'),
    )
  }
}

async function convertDir(dirName: string, targetDir: string): Promise<void> {
  fs.emptyDirSync(targetDir)
  const typeFiles = await fg([`${dirName}/lib.*.d.ts`], {
    ignore: [
      // The following files just reference other libs
      '**/lib.*.full.d.ts',
      '**/lib.d.ts',
      '**/lib.es6.d.ts',
      '**/lib.esnext.d.ts',
      '**/lib.2015.d.ts',
      '**/lib.2016.d.ts',
      '**/lib.2017.d.ts',
      '**/lib.2018.d.ts',
      '**/lib.2019.d.ts',
      '**/lib.2020.d.ts',
      '**/lib.2021.d.ts',
      '**/lib.2022.d.ts',
      '**/lib.2023.d.ts',
      '**/lib.2024.d.ts',
      '**/lib.2025.d.ts',
    ],
  })
  console.log(`[${toolName}] Number of type files: ${typeFiles.length}`)
  await Promise.all(
    typeFiles.map(async (filename) => convertFile(filename, targetDir)),
  )
}

// Run the extract function with the script's arguments
await convertDir(process.argv[2], process.argv[3] ?? '.')
