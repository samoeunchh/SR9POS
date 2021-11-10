// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var option = "";
$.ajax({
    type: "GET",
    url: "/Products/getunits",
    dataType: 'json',
    contentType: 'application/json; charset=utf-8',
    success: function (content, ajaxObj) {
        $.each(content, function (i, v) {
            //console.log(v);
            option += "<option value='" + v.unitId + "'>" + v.unitName + "</option>";
        });
    },
    error: function (error) {
        console.log(error);
    }
});
