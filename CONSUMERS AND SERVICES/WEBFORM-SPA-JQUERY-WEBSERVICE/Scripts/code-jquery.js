
$(document).ready(function () {
    //BUTTON CLICK TO CALL THE WEB SERVICE
    $(":button").click(function () {
        var urlRequest = "/Controller.asmx/Calculate";
        $.ajax({
            url: urlRequest,
            type: "POST",
            dataType: 'json',
            contentType: "application/json; charset=utf-8",
            data: "{}",
            success: function (result) {
                var data = result.d;
                $("#divResult").html("PI VALUE: " + data.PI + "<br/>" +
                                     "CALCULATION TIME: " + data.CalculationTime + "ms<br/>" +
                                     "MOON VOLUME: " + data.MoonVolume);
            },
            error: function (xhr, status, error) {
                alert("error");
                var err = eval("(" + xhr.responseText + ")");
                $("#divResult").html(err.Message)
            }
        });
    });
});