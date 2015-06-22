<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/ClienteM.master" CodeBehind="Clientes.aspx.cs" Inherits="Fase2.Clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent"  runat="server" ClientIDMode="AutoID">
  
    <p>


        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Consulta_paquete.aspx">Consulta de paquetes</asp:HyperLink>


    </p>
<p>


    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="Cotizacion.aspx">Cotizacion</asp:HyperLink>


    </p>
<p>


    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="Editar_cliente.aspx">Editar perfil</asp:HyperLink>


    </p>
      </asp:Content>
