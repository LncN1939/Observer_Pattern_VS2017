<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wbObserver.aspx.cs" Inherits="Observer_Pattern_Leo.wbObserver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="gvPCIds" runat="server" AutoGenerateColumns="true">
        <Columns>
            <asp:BoundField DataField="PCid" HeaderText="PC ID" />
        </Columns>
    </asp:GridView>

    <div>
        <label for="txtIdPC">ID de la PC:</label>
        <asp:Label ID="lblMensajes" runat="server"></asp:Label>
        <asp:TextBox ID="txtIdPC" runat="server" OnTextChanged="txtIdPC_TextChanged"></asp:TextBox>
        <asp:Button ID="btnNotificar" runat="server" Text="Notificar" OnClick="btnNotificar_Click"/>
    <%--</div>--%>

    </div>
</asp:Content>