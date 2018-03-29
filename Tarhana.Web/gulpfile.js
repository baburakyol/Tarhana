/// <binding ProjectOpened='kiralikbul, bakiyoruz' />
/****
 * Visual Studio 2017
  Tools > Options > Projects and Solutions > Web Package Management > External Web Tools
Then you need to add your Node install directory to the top of the list, like so:
  1- .\node_modules\.bin
  2- $(PATH)

Usage
cd to project directory 

npm install - to install dependencies
   if saas error then ??
   npm rebuild node-sass --force

gulp sass - to compile Sass files
gulp sass:watch to compile Sass synchronously

Sctipts .NET Core CLI commands
dotnet run      - runs source code without any explicit compile or launch commands
dotnet build    - builds a project and all of its dependencies
dotnet publish  - packs the application and its dependencies into a folder for deployment to a hosting system


*/
'use strict'

var gulp = require('gulp');
var merge = require('merge-stream');
var sass = require('gulp-sass');
var autoprefixer = require('gulp-autoprefixer');
var cssmin = require('gulp-cssmin')
var rename = require('gulp-rename');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');

gulp.paths = {
    dist: 'wwwroot/',
    src: './Views/'
};

var paths = gulp.paths;

gulp.pkg = require('./package.json');
var pkg = gulp.pkg;

gulp.task('bulonline', function () {
    var templatename = 'bulonline';
    var saas = gulp.src(paths.src + '/_scss/site.scss')
        .pipe(sass())
        .pipe(autoprefixer())
        .pipe(gulp.dest(paths.dist + 'themes/' + templatename + '/css'))
        .pipe(cssmin())
        .pipe(rename({ suffix: '.min' }))
        .pipe(gulp.dest(paths.dist + 'themes/' + templatename + '/css'));
    var images = gulp.src([paths.src + '/_images/**/*']).pipe(gulp.dest(paths.dist + 'themes/' + templatename + '/images'));
    var js = gulp.src([paths.src + '/_js/**/*'])
        .pipe(concat('scripts.js'))
        .pipe(gulp.dest(paths.dist + 'themes/' + templatename + '/js'))
        .pipe(rename('scripts.min.js'))
        .pipe(uglify())
        .pipe(gulp.dest(paths.dist + 'themes/' + templatename + '/js'));
    return merge(saas, images, js);
});


