const ~/admin/plugins = [
  // jQuery
  {
    from: 'node_modules/jquery/~/admin/dist',
    to  : '~/admin/plugins/jquery'
  },
  // Popper
  {
    from: 'node_modules/popper.js/~/admin/dist',
    to  : '~/admin/plugins/popper'
  },
  // Bootstrap
  {
    from: 'node_modules/bootstrap/~/admin/dist/js',
    to  : '~/admin/plugins/bootstrap/js'
  },
  // Font Awesome
  {
    from: 'node_modules/@fortawesome/fontawesome-free/css',
    to  : '~/admin/plugins/fontawesome-free/css'
  },
  {
    from: 'node_modules/@fortawesome/fontawesome-free/webfonts',
    to  : '~/admin/plugins/fontawesome-free/webfonts'
  },
  // overlayScrollbars
  {
    from: 'node_modules/overlayscrollbars/js',
    to  : '~/admin/plugins/overlayScrollbars/js'
  },
  {
    from: 'node_modules/overlayscrollbars/css',
    to  : '~/admin/plugins/overlayScrollbars/css'
  },
  // Chart.js
  {
    from: 'node_modules/chart.js/~/admin/dist/',
    to  : '~/admin/plugins/chart.js'
  },
  // jQuery UI
  {
    from: 'node_modules/jquery-ui-~/admin/dist/',
    to  : '~/admin/plugins/jquery-ui'
  },
  // Flot
  {
    from: 'node_modules/flot/~/admin/dist/es5/',
    to  : '~/admin/plugins/flot'
  },
  // Summernote
  {
    from: 'node_modules/summernote/~/admin/dist/',
    to  : '~/admin/plugins/summernote'
  },
  // Bootstrap Slider
  {
    from: 'node_modules/bootstrap-slider/~/admin/dist/',
    to  : '~/admin/plugins/bootstrap-slider'
  },
  {
    from: 'node_modules/bootstrap-slider/~/admin/dist/css',
    to  : '~/admin/plugins/bootstrap-slider/css'
  },
  // Bootstrap Colorpicker
  {
    from: 'node_modules/bootstrap-colorpicker/~/admin/dist/js',
    to  : '~/admin/plugins/bootstrap-colorpicker/js'
  },
  {
    from: 'node_modules/bootstrap-colorpicker/~/admin/dist/css',
    to  : '~/admin/plugins/bootstrap-colorpicker/css'
  },
  // Tempusdominus Bootstrap 4
  {
    from: 'node_modules/tempusdominus-bootstrap-4/build/js',
    to  : '~/admin/plugins/tempusdominus-bootstrap-4/js'
  },
  {
    from: 'node_modules/tempusdominus-bootstrap-4/build/css',
    to  : '~/admin/plugins/tempusdominus-bootstrap-4/css'
  },
  // Moment
  {
    from: 'node_modules/moment/min',
    to  : '~/admin/plugins/moment'
  },
  {
    from: 'node_modules/moment/locale',
    to  : '~/admin/plugins/moment/locale'
  },
  // FastClick
  {
    from: 'node_modules/fastclick/lib',
    to  : '~/admin/plugins/fastclick'
  },
  // Date Range Picker
  {
    from: 'node_modules/daterangepicker/',
    to  : '~/admin/plugins/daterangepicker'
  },
  // DataTables
  {
    from: 'node_modules/pdfmake/build',
    to: '~/admin/plugins/pdfmake'
  },
  {
    from: 'node_modules/jszip/~/admin/dist',
    to: '~/admin/plugins/jszip'
  },
  {
    from: 'node_modules/datatables.net/js',
    to: '~/admin/plugins/datatables'
  },
  {
    from: 'node_modules/datatables.net-bs4/js',
    to: '~/admin/plugins/datatables-bs4/js'
  },
  {
    from: 'node_modules/datatables.net-bs4/css',
    to: '~/admin/plugins/datatables-bs4/css'
  },
  {
    from: 'node_modules/datatables.net-autofill/js',
    to: '~/admin/plugins/datatables-autofill/js'
  },
  {
    from: 'node_modules/datatables.net-autofill-bs4/js',
    to: '~/admin/plugins/datatables-autofill/js'
  },
  {
    from: 'node_modules/datatables.net-autofill-bs4/css',
    to: '~/admin/plugins/datatables-autofill/css'
  },
  {
    from: 'node_modules/datatables.net-buttons/js',
    to: '~/admin/plugins/datatables-buttons/js'
  },
  {
    from: 'node_modules/datatables.net-buttons-bs4/js',
    to: '~/admin/plugins/datatables-buttons/js'
  },
  {
    from: 'node_modules/datatables.net-buttons-bs4/css',
    to: '~/admin/plugins/datatables-buttons/css'
  },
  {
    from: 'node_modules/datatables.net-colreorder/js',
    to: '~/admin/plugins/datatables-colreorder/js'
  },
  {
    from: 'node_modules/datatables.net-colreorder-bs4/js',
    to: '~/admin/plugins/datatables-colreorder/js'
  },
  {
    from: 'node_modules/datatables.net-colreorder-bs4/css',
    to: '~/admin/plugins/datatables-colreorder/css'
  },
  {
    from: 'node_modules/datatables.net-fixedcolumns/js',
    to: '~/admin/plugins/datatables-fixedcolumns/js'
  },
  {
    from: 'node_modules/datatables.net-fixedcolumns-bs4/js',
    to: '~/admin/plugins/datatables-fixedcolumns/js'
  },
  {
    from: 'node_modules/datatables.net-fixedcolumns-bs4/css',
    to: '~/admin/plugins/datatables-fixedcolumns/css'
  },
  {
    from: 'node_modules/datatables.net-fixedheader/js',
    to: '~/admin/plugins/datatables-fixedheader/js'
  },
  {
    from: 'node_modules/datatables.net-fixedheader-bs4/js',
    to: '~/admin/plugins/datatables-fixedheader/js'
  },
  {
    from: 'node_modules/datatables.net-fixedheader-bs4/css',
    to: '~/admin/plugins/datatables-fixedheader/css'
  },
  {
    from: 'node_modules/datatables.net-keytable/js',
    to: '~/admin/plugins/datatables-keytable/js'
  },
  {
    from: 'node_modules/datatables.net-keytable-bs4/js',
    to: '~/admin/plugins/datatables-keytable/js'
  },
  {
    from: 'node_modules/datatables.net-keytable-bs4/css',
    to: '~/admin/plugins/datatables-keytable/css'
  },
  {
    from: 'node_modules/datatables.net-responsive/js',
    to: '~/admin/plugins/datatables-responsive/js'
  },
  {
    from: 'node_modules/datatables.net-responsive-bs4/js',
    to: '~/admin/plugins/datatables-responsive/js'
  },
  {
    from: 'node_modules/datatables.net-responsive-bs4/css',
    to: '~/admin/plugins/datatables-responsive/css'
  },
  {
    from: 'node_modules/datatables.net-rowgroup/js',
    to: '~/admin/plugins/datatables-rowgroup/js'
  },
  {
    from: 'node_modules/datatables.net-rowgroup-bs4/js',
    to: '~/admin/plugins/datatables-rowgroup/js'
  },
  {
    from: 'node_modules/datatables.net-rowgroup-bs4/css',
    to: '~/admin/plugins/datatables-rowgroup/css'
  },
  {
    from: 'node_modules/datatables.net-rowreorder/js',
    to: '~/admin/plugins/datatables-rowreorder/js'
  },
  {
    from: 'node_modules/datatables.net-rowreorder-bs4/js',
    to: '~/admin/plugins/datatables-rowreorder/js'
  },
  {
    from: 'node_modules/datatables.net-rowreorder-bs4/css',
    to: '~/admin/plugins/datatables-rowreorder/css'
  },
  {
    from: 'node_modules/datatables.net-scroller/js',
    to: '~/admin/plugins/datatables-scroller/js'
  },
  {
    from: 'node_modules/datatables.net-scroller-bs4/js',
    to: '~/admin/plugins/datatables-scroller/js'
  },
  {
    from: 'node_modules/datatables.net-scroller-bs4/css',
    to: '~/admin/plugins/datatables-scroller/css'
  },
  {
    from: 'node_modules/datatables.net-select/js',
    to: '~/admin/plugins/datatables-select/js'
  },
  {
    from: 'node_modules/datatables.net-select-bs4/js',
    to: '~/admin/plugins/datatables-select/js'
  },
  {
    from: 'node_modules/datatables.net-select-bs4/css',
    to: '~/admin/plugins/datatables-select/css'
  },

  // Fullcalendar
  {
    from: 'node_modules/@fullcalendar/core/',
    to  : '~/admin/plugins/fullcalendar'
  },
  {
    from: 'node_modules/@fullcalendar/bootstrap/',
    to  : '~/admin/plugins/fullcalendar-bootstrap'
  },
  {
    from: 'node_modules/@fullcalendar/daygrid/',
    to  : '~/admin/plugins/fullcalendar-daygrid'
  },
  {
    from: 'node_modules/@fullcalendar/timegrid/',
    to  : '~/admin/plugins/fullcalendar-timegrid'
  },
  {
    from: 'node_modules/@fullcalendar/interaction/',
    to  : '~/admin/plugins/fullcalendar-interaction'
  },
  // icheck bootstrap
  {
    from: 'node_modules/icheck-bootstrap/',
    to  : '~/admin/plugins/icheck-bootstrap'
  },
  // inputmask
  {
    from: 'node_modules/inputmask/~/admin/dist/',
    to  : '~/admin/plugins/inputmask'
  },
  // ion-rangeslider
  {
    from: 'node_modules/ion-rangeslider/',
    to  : '~/admin/plugins/ion-rangeslider'
  },
  // JQVMap (jqvmap-novulnerability)
  {
    from: 'node_modules/jqvmap-novulnerability/~/admin/dist/',
    to  : '~/admin/plugins/jqvmap'
  },
  // jQuery Mapael
  {
    from: 'node_modules/jquery-mapael/js/',
    to  : '~/admin/plugins/jquery-mapael'
  },
  // Raphael
  {
    from: 'node_modules/raphael/',
    to  : '~/admin/plugins/raphael'
  },
  // jQuery Mousewheel
  {
    from: 'node_modules/jquery-mousewheel/',
    to  : '~/admin/plugins/jquery-mousewheel'
  },
  // jQuery Knob
  {
    from: 'node_modules/jquery-knob-chif/~/admin/dist/',
    to  : '~/admin/plugins/jquery-knob'
  },
  // pace-progress
  {
    from: 'node_modules/@lgaitan/pace-progress/~/admin/dist/',
    to  : '~/admin/plugins/pace-progress'
  },
  // Select2
  {
    from: 'node_modules/select2/~/admin/dist/',
    to  : '~/admin/plugins/select2'
  },
  {
    from: 'node_modules/@ttskch/select2-bootstrap4-theme/~/admin/dist/',
    to  : '~/admin/plugins/select2-bootstrap4-theme'
  },
  // Sparklines
  {
    from: 'node_modules/sparklines/source/',
    to  : '~/admin/plugins/sparklines'
  },
  // SweetAlert2
  {
    from: 'node_modules/sweetalert2/~/admin/dist/',
    to  : '~/admin/plugins/sweetalert2'
  },
  {
    from: 'node_modules/@sweetalert2/theme-bootstrap-4/',
    to  : '~/admin/plugins/sweetalert2-theme-bootstrap-4'
  },
  // Toastr
  {
    from: 'node_modules/toastr/build/',
    to  : '~/admin/plugins/toastr'
  },
  // jsGrid
  {
    from: 'node_modules/jsgrid/~/admin/dist',
    to: '~/admin/plugins/jsgrid'
  },
  {
    from: 'node_modules/jsgrid/demos/',
    to: '~/admin/plugins/jsgrid/demos'
  },
  // flag-icon-css
  {
    from: 'node_modules/flag-icon-css/css',
    to: '~/admin/plugins/flag-icon-css/css'
  },
  {
    from: 'node_modules/flag-icon-css/flags',
    to: '~/admin/plugins/flag-icon-css/flags'
  },
  // bootstrap4-duallistbox
  {
    from: 'node_modules/bootstrap4-duallistbox/~/admin/dist',
    to: '~/admin/plugins/bootstrap4-duallistbox/'
  },
  // filterizr
  {
    from: 'node_modules/filterizr/~/admin/dist',
    to: '~/admin/plugins/filterizr/'
  },
  // ekko-lightbox
  {
    from: 'node_modules/ekko-lightbox/~/admin/dist',
    to: '~/admin/plugins/ekko-lightbox/'
  },

  // AdminLTE ~/admin/dist
  {
    from: '~/admin/dist/css',
    to  : 'docs/assets/css'
  },
  {
    from: '~/admin/dist/js',
    to  : 'docs/assets/js'
  },
  // jQuery
  {
    from: 'node_modules/jquery/~/admin/dist',
    to  : 'docs/assets/~/admin/plugins/jquery'
  },
  // Popper
  {
    from: 'node_modules/popper.js/~/admin/dist',
    to  : 'docs/assets/~/admin/plugins/popper'
  },
  // Bootstrap
  {
    from: 'node_modules/bootstrap/~/admin/dist/js',
    to  : 'docs/assets/~/admin/plugins/bootstrap/js'
  },
  // Font Awesome
  {
    from: 'node_modules/@fortawesome/fontawesome-free/css',
    to  : 'docs/assets/~/admin/plugins/fontawesome-free/css'
  },
  {
    from: 'node_modules/@fortawesome/fontawesome-free/webfonts',
    to  : 'docs/assets/~/admin/plugins/fontawesome-free/webfonts'
  },
  // overlayScrollbars
  {
    from: 'node_modules/overlayscrollbars/js',
    to  : 'docs/assets/~/admin/plugins/overlayScrollbars/js'
  },
  {
    from: 'node_modules/overlayscrollbars/css',
    to  : 'docs/assets/~/admin/plugins/overlayScrollbars/css'
  }
]

module.exports = ~/admin/plugins
