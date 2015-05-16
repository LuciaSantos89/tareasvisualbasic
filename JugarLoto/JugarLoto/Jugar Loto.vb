Public Class JugarLoto
    Private premioSorteo As Double
    Private numerosSorteo(5) As Integer
    Private numerosGanadores(5) As Integer
    Private ganadoresCuatroNum, ganadoresCincoNum, ganadoresSeisNum As Integer
    Private premioCuatroNum, premioCincoNum, premioSeisNum As Double

    Private Sub jugarLoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pedirPremio()
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
    End Sub

    Private Sub botonGenerarGanador_Click(sender As Object, e As EventArgs) Handles botonGenerarGanador.Click
        If (tablaNumeros.Rows.Count = 0) Then
            MsgBox("Debe generar boletos", MsgBoxStyle.Exclamation, "No hay boletos")
            Return
        End If
        inputNumero1.Enabled = False
        inputNumero2.Enabled = False
        inputNumero3.Enabled = False
        inputNumero4.Enabled = False
        inputNumero5.Enabled = False
        inputNumero6.Enabled = False
        botonAgregarManual.Enabled = False
        botonAgregarAleatorio.Enabled = False
        botonGenerarGanador.Enabled = False

        Randomize()
        For i As Integer = 0 To 5 Step 1
            Dim numeroRandom As Integer = CInt(Int((33 * Rnd()) + 1))
            If i = 0 Then
                numerosGanadores(i) = numeroRandom
            Else
                For j As Integer = 0 To i - 1 Step 1
                    If numeroRandom <> numerosGanadores(j) Then
                        numerosGanadores(i) = numeroRandom
                    Else
                        i = i - 1
                        Exit For
                    End If
                Next
            End If
        Next

        inputNumeroGanador1.Text = numerosGanadores(0)
        inputNumeroGanador2.Text = numerosGanadores(1)
        inputNumeroGanador3.Text = numerosGanadores(2)
        inputNumeroGanador4.Text = numerosGanadores(3)
        inputNumeroGanador5.Text = numerosGanadores(4)
        inputNumeroGanador6.Text = numerosGanadores(5)

        Dim contador As Integer
        contador = 0

        For Each row As DataGridViewRow In tablaNumeros.Rows
            For i As Integer = 0 To 5 Step 1
                For Each cell As DataGridViewTextBoxCell In row.Cells

                    If numerosGanadores(i) = cell.Value Then
                        contador = contador + 1
                    End If
                Next
            Next
            If contador = 4 Then
                ganadoresCuatroNum = ganadoresCuatroNum + 1
            ElseIf contador = 5 Then
                ganadoresCincoNum = ganadoresCincoNum + 1
            ElseIf contador = 6 Then
                ganadoresSeisNum = ganadoresSeisNum + 1
            End If
            contador = 0
            inputGanadoresCuatro.Text = ganadoresCuatroNum
            inputGanadoresCinco.Text = ganadoresCincoNum
            inputGanadoresSeis.Text = ganadoresSeisNum
        Next

        premioCuatroNum = 0
        premioCincoNum = 0
        premioSeisNum = 0
        If ganadoresCuatroNum <> 0 Then
            premioCuatroNum = (premioSorteo * 0.15) / ganadoresCuatroNum
        End If
        If ganadoresCincoNum <> 0 Then
            premioCincoNum = (premioSorteo * 0.25) / ganadoresCincoNum
        End If
        If ganadoresSeisNum <> 0 Then
            premioSeisNum = premioSorteo
        End If
        inputPremioCuatro.Text = premioCuatroNum
        inputPremioCinco.Text = premioCincoNum
        inputPremioSeis.Text = premioSeisNum
    End Sub

    Private Sub botonNuevoSorteo_Click(sender As Object, e As EventArgs) Handles botonNuevoSorteo.Click
        premioSorteo = 0
        Array.Clear(numerosSorteo, 0, 5)
        Array.Clear(numerosGanadores, 0, 5)
        ganadoresCuatroNum = 0
        ganadoresCincoNum = 0
        ganadoresSeisNum = 0
        premioCuatroNum = 0
        premioCincoNum = 0
        premioSeisNum = 0
        inputPremioSorteo.Clear()
        inputNumero1.Value = inputNumero1.Minimum()
        inputNumero2.Value = inputNumero2.Minimum()
        inputNumero3.Value = inputNumero3.Minimum()
        inputNumero4.Value = inputNumero4.Minimum()
        inputNumero5.Value = inputNumero5.Minimum()
        inputNumero6.Value = inputNumero6.Minimum()
        tablaNumeros.Rows.Clear()
        inputNumeroGanador1.Clear()
        inputNumeroGanador2.Clear()
        inputNumeroGanador3.Clear()
        inputNumeroGanador4.Clear()
        inputNumeroGanador5.Clear()
        inputNumeroGanador6.Clear()
        inputGanadoresCuatro.Clear()
        inputGanadoresCinco.Clear()
        inputGanadoresSeis.Clear()
        inputPremioCuatro.Clear()
        inputPremioCinco.Clear()
        inputPremioSeis.Clear()

        pedirPremio()

        inputNumero1.Enabled = True
        inputNumero2.Enabled = True
        inputNumero3.Enabled = True
        inputNumero4.Enabled = True
        inputNumero5.Enabled = True
        inputNumero6.Enabled = True
        botonAgregarManual.Enabled = True
        botonAgregarAleatorio.Enabled = True
        botonGenerarGanador.Enabled = True
    End Sub

    Sub pedirPremio()
        premioSorteo = CDbl(InputBox("Ingrese el valor del premio"))
        inputPremioSorteo.Text = premioSorteo
    End Sub

End Class
