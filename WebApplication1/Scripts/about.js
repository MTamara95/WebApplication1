$(document).ready(function () {

    $("#inactiveUntil").hide();
    $("#firstname").focus();

    $("#username").one("focus", function (e) {
        GenerateUsername();
    });

    $("#selectStatus").change(function (e) {
        if ($("#selectStatus").select().val() == "Employee - Inactive") {
            $("#inactiveUntil").show();
        }
        else {
            $("#inactiveUntil").hide();
        }
    });

    function GenerateUsername() {
        var fullname = { firstname: $("#firstname").val(), lastname: $("#lastname").val() };

        $.ajax({
            url: '/About/GenerateUsername',
            data: fullname,
            success: function (data) {
                $("#username").val(data);
            },
            error: function () {
            }
        });
    }

});