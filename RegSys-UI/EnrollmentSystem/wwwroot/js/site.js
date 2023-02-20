// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

//declare global variables and common functions
var API_URL = "http://localhost:5000/api/";      //API URL
var Toast = Swal.mixin({                         //SweetAlert
    toast: true,
    position: 'top-end',
    showConfirmButton: false,
    timer: 3000
});

function newGuid() {
    return 'xxxx'.replace(/[xy]/g,
        function (c) {
            var r = Math.random() * 16 | 0, v = c == 'x'
                ? r
                : (r & 0x3 | 0x8);
            return v.toString(5);
        }).toUpperCase();
}

function get(urlParams) {
    return $.ajax({
        url: API_URL + urlParams,
        type: "GET",
        dataType: 'json',
        contentType: 'application/json'
    });
}