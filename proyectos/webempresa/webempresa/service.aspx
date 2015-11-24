<%@ Page Title="Nuestros servicios" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="service.aspx.vb" Inherits="webempresa.service" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
   	<div class="container">
		        <div class="row">
			        <div class="span12">
                     <h1>Nuestros servicios</h1>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id"
                            DataSourceID="AccessDataSource1" EmptyDataText="There are no data records to display.">
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                                <asp:BoundField DataField="titulo" HeaderText="titulo" SortExpression="titulo" />
                                <asp:BoundField DataField="detalle" HeaderText="detalle" SortExpression="detalle" />
                            </Columns>
                        </asp:GridView>
                        <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="C:\Users\Owner\Documents\webempresa.accdb"
                            DeleteCommand="DELETE FROM `weboftalmologia` WHERE `Id` = ?" InsertCommand="INSERT INTO `weboftalmologia` (`Id`, `titulo`, `detalle`) VALUES (?, ?, ?)"
                            SelectCommand="SELECT `Id`, `titulo`, `detalle` FROM `weboftalmologia`" UpdateCommand="UPDATE `weboftalmologia` SET `titulo` = ?, `detalle` = ? WHERE `Id` = ?">
                            <DeleteParameters>
                                <asp:Parameter Name="Id" Type="Int32" />
                            </DeleteParameters>
                            <InsertParameters>
                                <asp:Parameter Name="Id" Type="Int32" />
                                <asp:Parameter Name="titulo" Type="String" />
                                <asp:Parameter Name="detalle" Type="String" />
                            </InsertParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="titulo" Type="String" />
                                <asp:Parameter Name="detalle" Type="String" />
                                <asp:Parameter Name="Id" Type="Int32" />
                            </UpdateParameters>
                        </asp:AccessDataSource>
                    </div>
		        </div>
	        </div>

            <!-- content -->


            <footer style="width: 100%;
	height: 200px;
	background: #333;
	border-top: 2px solid #000;
	position: absolute;
	bottom: 0;color:#fff;text-align:center">
                <p>© copyright.</p>
            </footer>
</asp:Content>
