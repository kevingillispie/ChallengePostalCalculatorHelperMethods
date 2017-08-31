<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostageCalc.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods.PostageCalc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Postal Calculator</h1>
    <form id="form1" runat="server">
        <div>
            <p>Width:</p>
            <asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" OnTextChanged="generateParcelPrice"></asp:TextBox>
            <br />
            <br />
            <p>Height:</p>
            <asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" OnTextChanged="generateParcelPrice"></asp:TextBox>
            <br />
            <br />
            <p>Length:</p>
            <asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="generateParcelPrice"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:RadioButton ID="groundRadio" runat="server" Text="Ground" AutoPostBack="True" GroupName="deliveryMethod" OnCheckedChanged="generateParcelPrice" />
            <br />
            <asp:RadioButton ID="airRadio" runat="server" Text="Air" AutoPostBack="True" GroupName="deliveryMethod" OnCheckedChanged="generateParcelPrice" />
            <br />
            <asp:RadioButton ID="nextDayRadio" runat="server" Text="Next Day" AutoPostBack="True" GroupName="deliveryMethod" OnCheckedChanged="generateParcelPrice" />
            <br />
            <br />
            <p>Price: <asp:Label ID="resultLabel" runat="server"></asp:Label></p>
        </div>
    </form>
</body>
</html>
