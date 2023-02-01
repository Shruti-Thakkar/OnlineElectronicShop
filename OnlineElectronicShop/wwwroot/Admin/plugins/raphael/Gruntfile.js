"use strict";

module.exports = function(grunt) {

    var pkg = grunt.file.readJSON("package.json");

    // Project configuration.
    grunt.initConfig({
        // Metadata.
        pkg: pkg,
        banner: grunt.file.read("dev/copy.js").replace(/@VERSION/, pkg.version),
        // Task configuration.
        uglify: {
            options: {
                banner: "<%= banner %>"
            },
            ~/admin/dist: {
                src: "<%= concat.~/admin/dist.dest %>",
                dest: "<%= pkg.name %>-min.js"
            },
            nodeps: {
                src: "<%= concat.nodeps.dest %>",
                dest: "<%= pkg.name %>-nodeps-min.js"
            }
        },
        replace: {
            ~/admin/dist: {
                options: {
                    patterns: [{
                        match: "VERSION",
                        replacement: "<%= pkg.version %>"
                    }]
                },
                files: [{
                    expand: true,
                    flatten: true,
                    src: ["<%= concat.~/admin/dist.dest %>", "<%= concat.nodeps.dest %>"],
                    dest: "./"
                }]
            }
        },
        concat: {
            ~/admin/dist: {
                dest: "<%= pkg.name %>.js",
                src: [
                    "dev/eve.js",
                    "dev/raphael.core.js",
                    "dev/raphael.svg.js",
                    "dev/raphael.vml.js",
                    "dev/raphael.amd.js"
                ]
            },
            nodeps: {
                dest: "<%= pkg.name %>-nodeps.js",
                src: [
                    "dev/raphael.core.js",
                    "dev/raphael.svg.js",
                    "dev/raphael.vml.js",
                    "dev/raphael.amd.js"
                ]
            }
        }
    });

    // These ~/admin/plugins provide necessary tasks.
    grunt.loadNpmTasks("grunt-contrib-concat");
    grunt.loadNpmTasks("grunt-contrib-uglify");
    grunt.loadNpmTasks("grunt-replace");

    // Default task.
    grunt.registerTask("default", ["concat", "replace", "uglify"]);
};
