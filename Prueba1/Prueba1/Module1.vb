Module Module1

    Sub Main()
        Dim opcionMenu As Integer
        opcionMenu = menu()

        Dim resultadoFactorial As Integer
        Dim arreglo As Integer() = New Integer() {1, 2, 6, 1, 5, 5}
        Dim esPar As Boolean
        Dim arregloSumado As Integer()
        Dim matriz(,) As Integer = New Integer(,) {{6, 9, 1}, {4, 15, 6}}
        Dim valoresAltoBajo(1) As Integer

        Select Case opcionMenu
            Case 1
                resultadoFactorial = factorial(6)
                Console.WriteLine(resultadoFactorial)
                Console.Read()
            Case 2
                esPar = numeroCentralPar(arreglo)
                Console.WriteLine(esPar)
                Console.Read()
            Case 3
                arregloSumado = sumaValoresArreglo(arreglo)
                For Each numero As Integer In arreglo
                    Console.Write(numero & " | ")
                Next
                Console.WriteLine()
                For Each numero As Integer In arregloSumado
                    Console.Write(numero & " | ")
                Next
                Console.Read()
            Case 4
                valoresAltoBajo = valorMasAltoMasBajo(matriz)
                For i As Integer = 0 To matriz.GetLength(0) - 1 Step 1
                    For j As Integer = 0 To matriz.GetLength(1) - 1 Step 1
                        Console.Write(matriz(i, j) & " | ")
                    Next
                    Console.WriteLine()
                Next
                For Each numero As Integer In valoresAltoBajo
                    Console.Write(numero & " | ")
                Next
                Console.Read()
            Case Else
                Console.WriteLine("Bye")
                Console.Read()
        End Select


    End Sub

    Function factorial(numero As Integer) As Integer
        Dim numeroFactorial As Integer
        numeroFactorial = 1
        If numero <> 0 Then
            For i As Integer = 1 To numero Step 1
                numeroFactorial = numeroFactorial * i
            Next
        End If

        Return numeroFactorial

    End Function

    Function numeroCentralPar(arreglo As Integer()) As Boolean
        Dim posicionCentral As Integer
        posicionCentral = arreglo.Length / 2
        If arreglo(posicionCentral) Mod 2 = 0 Then
            Return True
        End If
        Return False
    End Function

    Function sumaValoresArreglo(arreglo As Integer()) As Integer()
        Dim arregloSumado As Integer() = New Integer() {1, 2}
        Dim suma As Integer
        For i As Integer = 0 To arreglo.Length - 1 Step 1
            If i = arreglo.Length - 1 Then
                suma = (arreglo(0) + arreglo(i))
            Else
                suma = arreglo(i) + arreglo(i + 1)
            End If
            ReDim Preserve arregloSumado(i)
            arregloSumado(i) = suma
            'Console.WriteLine(suma)
        Next
        Return arregloSumado
    End Function

    Function valorMasAltoMasBajo(matrix As Integer(,)) As Integer()
        Dim arregloValores(1) As Integer
        Dim valorAlto As Integer
        Dim valorBajo As Integer
        valorAlto = 0
        For i As Integer = 0 To matrix.GetLength(0) - 1 Step 1
            For j As Integer = 0 To matrix.GetLength(1) - 1 Step 1
                If matrix(i, j) > valorAlto Then
                    valorAlto = matrix(i, j)
                End If
            Next
        Next
        valorBajo = valorAlto
        For i As Integer = 0 To matrix.GetLength(0) - 1 Step 1
            For j As Integer = 0 To matrix.GetLength(1) - 1 Step 1
                If matrix(i, j) < valorBajo Then
                    valorBajo = matrix(i, j)
                End If
            Next
        Next
        arregloValores(0) = valorBajo
        arregloValores(1) = valorAlto
        Return arregloValores
    End Function

    Function menu() As Integer
        Console.WriteLine("Eliga una opcion del menu")
        Console.WriteLine("1. Factorial")
        Console.WriteLine("2. Numero centra par")
        Console.WriteLine("3. Arreglo sumado")
        Console.WriteLine("4. Valor más alto y valor más bajo")
        Console.WriteLine("Para salir presiona cualquier otro numero")
        Dim opcion As Integer
        opcion = Console.ReadLine
        Return opcion
    End Function

End Module
