<%@ Page Language="C#" AutoEventWireup="true" CodeFile="View.aspx.cs" Inherits="View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>JQUERY WEBFORM WEBSERVICE</title>
<script src="Scripts/jquery-2.2.1.min.js"></script>
 
<script>
    $(document).ready(function () {

        //BUTTON CLICK TO CALL THE WEBAPI2 SERVICE
        $(":button").click(function () {

            var urlRequest = "/Controller.asmx/Calculate";

            $.ajax({
                url: urlRequest,
				type: "POST",
                dataType: 'json',                
                contentType: "application/json; charset=utf-8",
                data: {},
                success: function (result) {
                    var data = result.d;
                    $("#divResult").html("PI: " + data.PI + "<br/>" +
                                         "Elapsed time in milliseconds: (" + data.CalculationTime + ")");

                },
                error: function (xhr, status, error) {
                    var err = eval("(" + xhr.responseText + ")");
                    $("#divResult").html(err.Message)
                }
            });
        });
    });
</script>

</head>
<body>

<form name="JQUERYFORM" runat="server">

<div style="text-align:center;width:800px;margin-left:auto;margin-right:auto;" >
   
    <a href="/">HOME</a>

    <br />
    <br />

    <h2>Moon and Back Calculator - JQuery and WEBFORM and WEBSERVICE</h2>
    <i>(What is the volume of the moon ???)</i><br />
    <br />
    Volume of a Sphere = (4/3) PI R^3<br/>
    <br />
    Radius of the Moon (10,917km) = (10,917,000m)<br/>
    <br/>
    <input type="button" value="Calculate" id="btnCalculate" style="width:100px;"/>
    <br />
    <br />
    <div id="divResult" style="text-align:left;width:300px;margin-left:auto;margin-right:auto;" ></div><br /><br>

</div>
</form>
</body>
</html>
