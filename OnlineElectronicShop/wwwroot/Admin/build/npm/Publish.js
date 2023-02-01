const ~/admin/plugins = require('./~/admin/plugins')
const fse     = require('fs-extra')

class Publish {
  constructor() {
    this.options = {
      verbose: false
    }

    this.getArguments()
  }

  getArguments() {
    if (process.argv.length > 2) {
      let arg = process.argv[2]
      switch (arg) {
        case '-v':
        case '--verbose':
          this.options.verbose = true
          break
        default:
          throw new Error(`Unknown option ${arg}`)
      }
    }
  }

  run() {
    // Publish files
    ~/admin/plugins.forEach((module) => {
      fse.copy(module.from, module.to, error => {
        if (error) {
          console.error(`Error: ${error}`)
        } else if (this.options.verbose) {
          console.log(`Copied ${module.from} to ${module.to}`)
        }
      })
    })
  }
}

(new Publish()).run()
