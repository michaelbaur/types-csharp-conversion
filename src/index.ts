import fg from 'fast-glob'
import fs from 'fs-extra'
import * as path from 'node:path'
import { getFileContent, getNamespace } from './converter.js'

const toolName = 'Types-C#-Conversion'

function convertFile(filename: string, targetDir: string): void {
  const namespace = getNamespace(filename)
  const targetFile = path.join(
    path.join(targetDir, namespace),
    `${path.basename(filename, `.d.ts`)}.cs`,
  )

  const types = getFileContent(filename)
  console.log(`[${toolName}] Converted ${filename}`)

  const pagination = 300
  if (types.length < pagination) {
    fs.writeFileSync(targetFile, types.join('\n\n'))
    return
  }
  for (let i = 0; i * pagination < types.length; i++) {
    fs.writeFileSync(
      targetFile.replace('.cs', `.p${i}.cs`),
      types.slice(i * pagination, (i + 1) * pagination).join('\n\n'),
    )
  }
}

async function convertDir(dirName: string, targetDir: string): Promise<void> {
  fs.emptyDirSync(path.join(targetDir, 'DOM'))
  fs.emptyDirSync(path.join(targetDir, 'Decorators'))
  fs.emptyDirSync(path.join(targetDir, 'Lib'))
  fs.emptyDirSync(path.join(targetDir, 'Worker'))

  const typeFiles = await fg([`${dirName}/lib.*.d.ts`], {
    ignore: [
      // The following files just reference other libs
      '**/lib.*.full.d.ts',
      '**/lib.d.ts',
      '**/lib.es6.d.ts',
      '**/lib.esnext.d.ts',
      '**/lib.es2015.d.ts',
      '**/lib.es2016.d.ts',
      '**/lib.es2017.d.ts',
      '**/lib.es2018.d.ts',
      '**/lib.es2019.d.ts',
      '**/lib.es2020.d.ts',
      '**/lib.es2021.d.ts',
      '**/lib.es2022.d.ts',
      '**/lib.es2023.d.ts',
      '**/lib.es2024.d.ts',
      '**/lib.es2025.d.ts',
    ],
  })
  console.log(`[${toolName}] Number of type files: ${typeFiles.length}`)
  await Promise.all(
    typeFiles.map(async (filename) => convertFile(filename, targetDir)),
  )
}

// Run the extract function with the script's arguments
await convertDir(process.argv[2], process.argv[3] ?? '.')
