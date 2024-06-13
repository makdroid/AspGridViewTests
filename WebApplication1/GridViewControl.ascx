<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GridViewControl.ascx.cs" Inherits="WebApplication1.GridViewControl" %>

<asp:GridView runat="server" ID="GridView1"
    AutoGenerateColumns="true"
    OnRowEditing="GridView1_RowEditing"
    OnRowUpdating="GridView1_RowUpdating"
    OnRowCancelingEdit="GridView1_RowCancelingEdit">
    <Columns>
        <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="true" />
        <asp:BoundField DataField="Name" HeaderText="Name" />
        <asp:BoundField DataField="Age" HeaderText="Age" />
        <asp:CommandField ShowEditButton="true" />
    </Columns>
</asp:GridView>
