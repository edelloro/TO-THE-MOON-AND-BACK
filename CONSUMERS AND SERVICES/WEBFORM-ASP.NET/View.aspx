<%@ Page Language="C#" AutoEventWireup="true" CodeFile="View.aspx.cs" Inherits="View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>JQUERY WEBFORM WEBSERVICE</title>

<script>
   
</script>

</head>
<body>

<form name="ASPNETWEBFORM" runat="server">

<div style="text-align:center;width:800px;margin-left:auto;margin-right:auto;" >
    <br />
    <br />
    <h2>Moon and Back Calculator - ASPNET WEBFORM</h2>
    <br />
    <i>(What is the volume of the moon ???)</i><br />
    <br />
    Volume of a Sphere = (4/3) PI R^3<br/>
    <br />
    Radius of the Moon (1,737km) <br/>
    <br/>
    <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" Width="306px"/>
    <br />
    <br />
    <asp:TextBox ID="txtResult" runat="server" BorderStyle="None" Height="122px" TextMode="MultiLine" Width="296px"></asp:TextBox>
    <br /><br />
</div>
</form>
</body>
</html>
