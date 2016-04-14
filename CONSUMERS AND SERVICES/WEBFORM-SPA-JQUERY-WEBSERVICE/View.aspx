<%@ Page Language="C#" AutoEventWireup="true" CodeFile="View.aspx.cs" Inherits="View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script src="Scripts/jquery-2.2.1.min.js"></script>
<script>
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
                    $("#divResult").html("PI VALUE: "     + data.PI + "<br/>" +
                                         "CALCULATION TIME: " + data.CalculationTime);

                },

                error: function (xhr, status, error) {
                    alert("error");
                    var err = eval("(" + xhr.responseText + ")");
                    $("#divResult").html(err.Message)
                }
            });
        });
    });
</script>


<title>JQuery Simple constant Calculator</title>
</head>
<body>
<form id="form1" runat="server">   
   
        
        
    
<div style="text-align:center;width:800px;margin-left:auto;margin-right:auto;" >
   
    <br />
    <br />

    <h2>Moon and Back Calculator - WEBFORM JQUERY WEBSERVICE</h2>
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
