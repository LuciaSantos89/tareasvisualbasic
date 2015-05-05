Public Class Matricula

    Private Sub nombrePersona_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles nombrePersona.KeyPress
        e.Handled = Not (Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = Keys.Back Or Asc(e.KeyChar) = Keys.Space)
    End Sub

    Private Sub nombreClaseLab_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles nombreClaseLab.KeyPress
        e.Handled = Not (Char.IsLetterOrDigit(e.KeyChar) Or Asc(e.KeyChar) = Keys.Back Or Asc(e.KeyChar) = Keys.Space)
    End Sub
End Class
