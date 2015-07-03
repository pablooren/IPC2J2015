<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Empleados.master"  CodeBehind="Paqueteria.aspx.cs" Inherits="Fase2.Paqueteria" %>
<%@ MasterType VirtualPath="~/Empleados.master" %> 

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 

    <p>



        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="RegistroPaquete.aspx">Registrar Paquete</asp:HyperLink>



    </p>
    <p>



        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="Lote.aspx">Registrar lote</asp:HyperLink>



    </p>
    <p>



        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="EstadoLote.aspx">Estado de lote</asp:HyperLink>



    </p>

     </asp:Content>
