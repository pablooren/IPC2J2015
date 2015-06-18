<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="INICIO.aspx.cs" Inherits="Fase2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label runat="server" ID="Label2"  > BIENVENIDO                    INICIE SESION PARA CONTINUAR </asp:Label>
                <br />
            <br />
            <br />
            <asp:Label runat= "server" Font-Size="11pt" ID="Label3"> Nombre de Usuario</asp:Label>
            &nbsp;<asp:TextBox ID="usuario" runat="server" Height="19px" Width="126px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Label runat="server" Font-Size="11pt" ID="Label4"> Contraseña</asp:Label>
            &nbsp;
            <asp:TextBox ID="password" TextMode="Password" runat="server" Width="121px" Height="19px" />
                <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label runat= "server" Font-Size="11pt" ID="Label5"> Grupo</asp:Label>
                 
            &nbsp;&nbsp;<asp:DropDownList ID="grupo" runat="server" Height="28px" Width="137px" Font-Size="11pt">
                <asp:ListItem>Administrador</asp:ListItem>
                <asp:ListItem>Cliente</asp:ListItem>
                <asp:ListItem>Empleado</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="inicio" runat="server" Text="Iniciar Sesion" Font-Size="11pt" Height="36px" OnClick="inicio_Click" Width="115px" />
            <br />
            <br />
        <asp:Label ID="Label1" runat="server" Text="¿No es cliente aun? Registrese"></asp:Label>
&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/registro_usuario.aspx">Aqui</asp:HyperLink>
    </h2>
</asp:Content>
