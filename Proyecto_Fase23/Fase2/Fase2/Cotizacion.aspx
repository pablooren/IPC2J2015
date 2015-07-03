<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/ClienteM.master" CodeBehind="Cotizacion.aspx.cs" Inherits="Fase2.Cotizacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent"  runat="server" ClientIDMode="AutoID">
  
    <p>


        <asp:Label ID="Label1" runat="server" ForeColor="White" Text="Seleccione categoria"></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="169px">
        </asp:DropDownList>


        </p>
<p>


        <asp:Label ID="Label2" runat="server" ForeColor="White" Text="Ingrese peso"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="32px"></asp:TextBox>


        </p>
<p>


        <asp:Label ID="Label3" runat="server" ForeColor="White" Text="Ingrese Precio"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server" Width="54px"></asp:TextBox>


        </p>
<p>


        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cotizar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


        </p>
    </asp:Content>