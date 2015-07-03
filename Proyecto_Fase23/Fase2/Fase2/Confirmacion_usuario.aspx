<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Empleados.master" CodeBehind="Confirmacion_usuario.aspx.cs" Inherits="Fase2.Confirmacion_usuario" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
   

   



    <p>


        <asp:Label ID="Label1" runat="server" Text="Porfavor, seleccione usuario y luego escriba el Codigo internacional "></asp:Label>


    </p>
    
     <p>


         <asp:TextBox ID="intbox" runat="server"></asp:TextBox>


    </p>
     <p>


         &nbsp;</p>
   

   



     <p>
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="DPI" DataSourceID="datos" ForeColor="White">
             <Columns>
                 <asp:CommandField ShowSelectButton="True" />
                 <asp:BoundField DataField="DPI" HeaderText="DPI" ReadOnly="True" SortExpression="DPI" />
                 <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                 <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                 <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                 <asp:BoundField DataField="Tarjeta_asociada" HeaderText="Tarjeta_asociada" SortExpression="Tarjeta_asociada" />
                 <asp:BoundField DataField="Nombre_usuario" HeaderText="Nombre_usuario" SortExpression="Nombre_usuario" />
                 <asp:BoundField DataField="Cas_Int" HeaderText="Cas_Int" SortExpression="Cas_Int" />
             </Columns>
             <SelectedRowStyle BackColor="#99CCFF" />
         </asp:GridView>



     </p>
     <asp:SqlDataSource ID="datos" runat="server" ConnectionString="<%$ ConnectionStrings:Quetzal_ExpressConnectionString %>" SelectCommand="SELECT DPI, Nombre, Apellido, Telefono, Tarjeta_asociada, Nombre_usuario, Cas_Int FROM Cliente WHERE (Cas_Int IS NULL)" ></asp:SqlDataSource>
     <p>
         &nbsp;</p>
<p>
         <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
</p>
   

   



     </asp:Content>




