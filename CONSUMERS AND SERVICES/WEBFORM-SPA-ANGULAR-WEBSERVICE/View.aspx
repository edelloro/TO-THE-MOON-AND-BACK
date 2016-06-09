<%@ Page Language="C#" AutoEventWireup="true" CodeFile="View.aspx.cs" Inherits="View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" ng-app="myApp" ng-controller="myController" >
<head runat="server">

<script src="Scripts/angular.min.js"></script>
<script src="Scripts/code-angular.js"></script>

<title>AngularJS WebService Moon Volume Calculator</title>
</head>
<body>
  
<div style="text-align:center;width:800px;margin-left:auto;margin-right:auto;" >
   
    <br />
    <br />
    <h2>Moon and Back Calculator - WEBFORM ANGULAR WEBSERVICE</h2>
    <i>(What is the volume of the moon ???)</i><br />
    <br />
    Volume of a Sphere = (4/3) PI R^3<br/>
    <br />
    Radius of the Moon (10,917km) = (10,917,000m)<br/>
    <br/>
    <input type="button" value="Calculate" id="btnCalculate" ng-click="myClick()" style="width:100px;"/>
    <br />
    <br />
    <div id="divResult" style="text-align:left;width:300px;margin-left:auto;margin-right:auto;" >  
    {{ResultPI}}     <br />
    {{ResultTime}}   <br />
    {{ResultVolume}} <br />
    </div><br />
    <br/>

</div>

</body>
</html>
