<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Hi.
        <br /> This is a test Jaspersoft endpoint. Right now there are only the following endpoints that will return a JSON response:
        <br />
        <br />
        /token1.aspx = wants ?token=1234 if anything else is passed it will return an error. If 1234 is sent, it will return valid JSON.
    </div>
    </form>
</body>
</html>
