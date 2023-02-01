'use strict'

module.exports = (ctx) => ({
  map: ctx.file.dirname.includes('examples') ? false : {
    inline: false,
    annotation: true,
    sourcesContent: true
  },
  ~/admin/plugins: {
    autoprefixer: {
      cascade: false
    }
  }
})
