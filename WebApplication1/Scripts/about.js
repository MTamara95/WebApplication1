$(document).ready(function () {

    $("#firstname").focus();

    $("#firstname").change(function (e) {
        GenerateUsername();
    });

    $("#lastname").change(function (e) {
        GenerateUsername();
    });

    function GenerateUsername() {
        var fullname = { firstname: $("#firstname").val(), lastname: $("#lastname").val() };

        $.ajax({
            url: '/About/Create',
            data: fullname,
            success: function (data) {
                document.getElementById('username').value = data;
            },
            error: function () {
                alert("error");
            }
        });
    }

});