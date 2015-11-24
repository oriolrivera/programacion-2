


Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
<WebService(Namespace:="http://localhost/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Service
    Inherits System.Web.Services.WebService
    <WebMethod()> _
    Public Function GetCustomers() As MyDataComponent.CustomersDataTable
        Dim da As New MyDataComponentTableAdapters.CustomersTableAdapter()

        Dim ds As New MyDataComponent.CustomersDataTable()
        da.Fill(ds)
        Return ds
    End Function
End Class

