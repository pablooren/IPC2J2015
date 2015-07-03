<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/ClienteM.master" CodeBehind="Editar_cliente.aspx.cs" Inherits="Fase2.Editar_cliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent"  runat="server" ClientIDMode="AutoID">
  
    <p>


        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" ForeColor="White" Text="Porfavor edite los campos que desea cambiar"></asp:Label>


        </p>
    <p>


        <asp:Label ID="Label2" runat="server" ForeColor="White" Text="Nombre"></asp:Label>
&nbsp;<asp:TextBox ID="nom_box" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" ForeColor="White" Text="Apellido"></asp:Label>
&nbsp;
        <asp:TextBox ID="ape_box" runat="server"></asp:TextBox>


        </p>
    <p>


        <asp:Label ID="Label4" runat="server" ForeColor="White" Text="Direccion"></asp:Label>
&nbsp;
        <asp:TextBox ID="dir_box" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" ForeColor="White" Text="Telefono"></asp:Label>
&nbsp;
        <asp:TextBox ID="tele_box" runat="server"></asp:TextBox>


        </p>
    <p>


        <asp:Label ID="Label6" runat="server" ForeColor="White" Text="Numero de tarjeta credito/debito"></asp:Label>
&nbsp;
        <asp:TextBox ID="tarj_box" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Credomatic</asp:ListItem>
            <asp:ListItem>MasterCard</asp:ListItem>
            <asp:ListItem>Visa</asp:ListItem>
            <asp:ListItem>American Express</asp:ListItem>
        </asp:DropDownList>


        </p>
    <p>


        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Aceptar" />


        </p>
    <p>


        &nbsp;</p>
    
 </asp:Content>
