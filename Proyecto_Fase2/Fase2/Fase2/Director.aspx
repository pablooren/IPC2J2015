<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Empleados.master" CodeBehind="Director.aspx.cs" Inherits="Fase2.Director" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <p>



        <asp:HyperLink ID="HyperLink1" NavigateUrl="Contratos.aspx" runat="server">Realizar Contratacion</asp:HyperLink>



    </p>
    <p>



        <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Consulta_empleados.aspx" runat="server">Consultar Equipo</asp:HyperLink>



    </p>
    <p>



        <asp:HyperLink ID="HyperLink3" runat="server">Modificar contratacion</asp:HyperLink>



    </p>
    <p>



        <asp:HyperLink ID="HyperLink4" runat="server">Despedir empleado</asp:HyperLink>



    </p>

     </asp:Content>
