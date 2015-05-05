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
        If nombrePersona.Text = "" Or nombreClaseLab.Text = "" Or tipoClaseLab.SelectedIndex = -1 Then
            Debug.WriteLine("no")
        Else
            listaClasesLabs.Items.Add(nombreClaseLab.Text)
            totalCuenta = totalCuenta + precio
            cuentaTotal.Text = totalCuenta
        End If
    End Sub


    Private Sub numeroMensualidades_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numeroMensualidades.KeyPress
        Debug.WriteLine(numeroMensualidades.Text.Length)
        e.Handled = Not (Char.IsDigit(e.KeyChar) And e.KeyChar < "7" And e.KeyChar > "0" Or Asc(e.KeyChar) = Keys.Back)

    End Sub

    Private Sub calcularPagoMensualidad_Click(sender As Object, e As EventArgs) Handles calcularPagoMensualidad.Click
        If totalCuenta = 0 Or totalCuenta = Nothing Or numeroMensualidades.Text = "" Or listaClasesLabs.Items.Count = 0 Then
            Debug.WriteLine("no")
        Else
            cantidadMensualidades = 1
            cantidadMensualidades = CInt(numeroMensualidades.Text)
            mensualidadPago = totalCuenta / cantidadMensualidades
            pagoMensualidad.Text = mensualidadPago
        End If
    End Sub
End Class
