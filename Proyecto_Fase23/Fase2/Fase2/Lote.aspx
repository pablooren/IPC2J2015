<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Empleados.master" CodeBehind="Lote.aspx.cs" Inherits="Fase2.Lote" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <p>


&nbsp;
        <asp:Label ID="Label3" runat="server" ForeColor="White" Text="Ingrese fecha de salida"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="80px">dd/mm/aa</asp:TextBox>


</p>
    <p>


        &nbsp;</p>
    <p>


        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Quetzal_ExpressConnectionString %>" SelectCommand="SELECT [ID_paquete], [Cliente], [Categoria], [Peso_lb], [Precio] FROM [Paquete]"></asp:SqlDataSource>


</p>
    <p>


        <asp:Label ID="Label2" runat="server" ForeColor="White" Text="Seleccione el destino "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


</p>
    <p>


        &nbsp;</p>
    <p>


        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Serie_Suc" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Serie_Suc" HeaderText="Serie_Suc" InsertVisible="False" ReadOnly="True" SortExpression="Serie_Suc" />
                <asp:BoundField DataField="Pais" HeaderText="Pais" SortExpression="Pais" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
&nbsp;&nbsp;&nbsp;


</p>
    <p>


        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Aceptar" />
        &nbsp;</p>
    <p>


        &nbsp;</p>
    <p>


        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Quetzal_ExpressConnectionString %>" SelectCommand="SELECT [Serie_Suc], [Pais], [Direccion], [Telefono] FROM [Sucursal]"></asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


</p>
    <p>


        &nbsp;</p>    

</asp:Content>