Public Class Matricula

    Private nombrePer As String
    Private clases, labs As String()
    Private totalCuenta, mensualidadPago As Double
    Private cantidadMensualidades As Integer
    Private precioClase, precioLaboratorio, precio As Double

    Private Sub nombrePersona_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles nombrePersona.KeyPress
        e.Handled = Not (Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = Keys.Back Or Asc(e.KeyChar) = Keys.Space)
    End Sub

    Private Sub nombreClaseLab_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles nombreClaseLab.KeyPress
        e.Handled = Not (Char.IsLetterOrDigit(e.KeyChar) Or Asc(e.KeyChar) = Keys.Back Or Asc(e.KeyChar) = Keys.Space)
    End Sub

    Private Sub tipoClaseLab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipoClaseLab.SelectedIndexChanged
        Select tipoClaseLab.SelectedItem
            Case "Clase"
                precio = 150
                precioClaseLab.Text = "150"
            Case "Laboratorio"
                precio = 100
                precioClaseLab.Text = "100"
            Case Else
                precio = 0
                precioClaseLab.Text = ""
        End Select
    End Sub

    Private Sub agregarClase_Click(sender As Object, e As EventArgs) Handles agregarClase.Click
        Debug.WriteLine("Voy a añadir la clase")
    End Sub
End Class
