import fs from 'fs-extra';
import * as path from 'node:path';
import ts from 'typescript';
import { getTypes, preamble } from './converter.js';
/**
 * Prints out particular nodes from a source file
 *
 * @param filename a path to a file
 */
function extract(filename, targetDir) {
    // Create a Program to represent the project, then pull out the
    // source file to parse its AST.
    const program = ts.createProgram([filename], { allowJs: true });
    const sourceFile = program.getSourceFile(filename);
    fs.emptyDirSync(targetDir);
    const types = getTypes(sourceFile);
    const pagination = 500;
    for (let i = 0; i * pagination < types.length; i++) {
        const targetFile = path.join(targetDir, `${path.basename(filename, `.d.ts`)}.p${i}.cs`);
        console.log(targetFile);
        fs.writeFileSync(targetFile, preamble +
            types.slice(i * pagination, (i + 1) * pagination).join('\n\n'));
    }
}
// Run the extract function with the script's arguments
extract(process.argv[2], process.argv[3] ?? '.');
