Imports Entidades
Imports Negocio
Public Class frmAutomovil
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ActualizagrvAutomovil()
    End Sub
    Protected Sub ActualizagrvAutomovil()
        Dim automovil As nAutomovil
        automovil = New nAutomovil
        grvAutomovil.DataSource = automovil.ConsultarAutomovil()
        grvAutomovil.DataBind()
    End Sub
    Protected Sub cmdGrabar_Click(sender As Object, e As EventArgs)
        Dim automovil As New eAutomovil
        Dim negocioAutomovil As New Negocio.nAutomovil
        Dim graba As Int16
        graba = 0
        automovil.Marca = txtMarca.Text
        automovil.Modelo = txtModelo.Text
        automovil.Anio = Convert.ToInt16(txtAnio.Text)
        automovil.Precio = Convert.ToDecimal(txtPrecio.Text)
        graba = negocioAutomovil.AgregarAutomovil(automovil)
        If graba > 0 Then
            lblResultado.Text = "Registro agregado"
            lblResultado.ForeColor = Drawing.Color.Green
        Else
            lblResultado.Text = "Registro No agregado"
            lblResultado.ForeColor = Drawing.Color.Red
        End If
        ActualizagrvAutomovil()
    End Sub
End Class
