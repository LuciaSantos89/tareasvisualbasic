Public Class JugarLoto
    Private premioSorteo As Double
    Private numerosSorteo(5) As Integer

    Private tablaNumerosSorteo()() As Integer = New Integer()() {}

    Private Sub jugarLoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        premioSorteo = CDbl(InputBox("Ingrese el valor del premio"))
        inputPremioSorteo.Text = premioSorteo

    End Sub

    Private Sub inputNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles inputNumero6.KeyPress, inputNumero5.KeyPress, inputNumero4.KeyPress, inputNumero3.KeyPress, inputNumero2.KeyPress, inputNumero1.KeyPress
        'e.Handled =

    End Sub

    Private Sub botonAgregarManual_Click(sender As Object, e As EventArgs) Handles botonAgregarManual.Click
        numerosSorteo(0) = inputNumero1.Value
        numerosSorteo(1) = inputNumero2.Value
        numerosSorteo(2) = inputNumero3.Value
        numerosSorteo(3) = inputNumero4.Value
        numerosSorteo(4) = inputNumero5.Value
        numerosSorteo(5) = inputNumero6.Value

        For i As Integer = 0 To 5 Step 1
            If i <> 5 Then
                For j As Integer = i + 1 To 5 Step 1
                    If numerosSorteo.GetValue(i) = numerosSorteo.GetValue(j) Then
                        MsgBox("No pueden haber números iguales", MsgBoxStyle.Exclamation, "Números Iguales")
                        Return
                    End If
                Next
            End If
        Next
        tablaNumeros.Rows.Add(CStr(numerosSorteo.GetValue(0)), CStr(numerosSorteo.GetValue(1)), CStr(numerosSorteo.GetValue(2)), CStr(numerosSorteo.GetValue(3)), CStr(numerosSorteo.GetValue(4)), CStr(numerosSorteo.GetValue(5)))
        agregarATabla()
    End Sub

    Private Sub botonAgregarAleatorio_Click(sender As Object, e As EventArgs) Handles botonAgregarAleatorio.Click
        Randomize()
        For i As Integer = 0 To 5 Step 1
            Dim numeroRandom As Integer = CInt(Int((33 * Rnd()) + 1))
            If i = 0 Then
                numerosSorteo(i) = numeroRandom
            Else
                For j As Integer = 0 To i - 1 Step 1
                    If numeroRandom <> numerosSorteo(j) Then
                        numerosSorteo(i) = numeroRandom
                    Else
                        i = i - 1
                        Exit For
                    End If
                Next
            End If
        Next
        tablaNumeros.Rows.Add(CStr(numerosSorteo.GetValue(0)), CStr(numerosSorteo.GetValue(1)), CStr(numerosSorteo.GetValue(2)), CStr(numerosSorteo.GetValue(3)), CStr(numerosSorteo.GetValue(4)), CStr(numerosSorteo.GetValue(5)))
        agregarATabla()
    End Sub

    Private Sub agregarATabla()
        Debug.WriteLine(tablaNumerosSorteo.GetLength(0))
        If tablaNumerosSorteo.GetLength(0) = 0 Then
            ReDim Preserve tablaNumerosSorteo(0)
            tablaNumerosSorteo(0) = numerosSorteo
        Else
            ReDim Preserve tablaNumerosSorteo(tablaNumerosSorteo.GetLength(0))
            tablaNumerosSorteo(tablaNumerosSorteo.GetLength(0) - 1) = numerosSorteo
        End If
        For Each number In tablaNumerosSorteo(0)
            Debug.WriteLine(number)
        Next
    End Sub

End Class
