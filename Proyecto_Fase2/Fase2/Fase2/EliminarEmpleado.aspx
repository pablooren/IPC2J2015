<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Empleados.master" CodeBehind="EliminarEmpleado.aspx.cs" Inherits="Fase2.EliminarEmpleado" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"> 
    <p>


        <asp:Label ID="Label1" runat="server" ForeColor="White" Text="Porfavor seleccione el empleado a despedir"></asp:Label>


    </p>
    <p>


        <asp:Label ID="depto_l" runat="server" ForeColor="White" Text="Label"></asp:Label>
&nbsp;
        <asp:Label ID="suc_l" runat="server" ForeColor="White" Text="Label"></asp:Label>


    </p>
    <div id="Layer1" style="width:1000px; height:400px; overflow: scroll;">
    <p>


        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="ID_empleado" HeaderText="ID_empleado" SortExpression="ID_empleado" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                <asp:BoundField DataField="Cargo" HeaderText="Cargo" SortExpression="Cargo" />
                <asp:BoundField DataField="Pais" HeaderText="Pais" SortExpression="Pais" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
                <asp:BoundField DataField="Nombre1" HeaderText="Nombre1" SortExpression="Nombre1" />
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


    </p>
    <p>


        &nbsp;</p>
    <p>


        &nbsp;</p>
    <p>


        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Quetzal_ExpressConnectionString %>" SelectCommand="emp_suc_depto" SelectCommandType="StoredProcedure">
            <SelectParameters>
                <asp:ControlParameter ControlID="depto_l" DefaultValue="1" Name="depto" PropertyName="Text" Type="Int32" />
                <asp:ControlParameter ControlID="suc_l" DefaultValue="1" Name="sucu" PropertyName="Text" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>


    </p>
    <p>


        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Despedir" />


    </p>
        </div>
    </asp:Content>