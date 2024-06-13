<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="WebApplication1.WebUserControl1" %>
<%@ Register Src="~/GridViewControl.ascx" TagPrefix="uc1" TagName="GridViewControl" %>


<div id="hoverContent" runat="server">
<h1 runat="server">Hello, it's a test</h1>

    <uc1:GridViewControl runat="server" ID="GridViewControl1" />
</div>

<uc1:GridViewControl runat="server" ID="GridViewControl2" />
