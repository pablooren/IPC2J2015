<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Empleados.master"  CodeBehind="Bodega.aspx.cs" Inherits="Fase2.Bodega" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
  
    
      <p>


          <asp:Label ID="Label1" runat="server" ForeColor="White" Text="Porfavor cargue un lote para verificar "></asp:Label>


          </p>
      <p>


          <asp:FileUpload ID="FileUpload1" runat="server" />


          </p>
      <p>


          <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click" />


          </p>

    </asp:Content>
