Imports System.Globalization

Public Class ValorEntrada
    'declaracion de variables  del Problema #2
    Dim euro As Decimal
    Dim dolar As Decimal
    Dim yen As Decimal
    Dim peseta As Decimal
    Dim libra As Decimal
    'llamada de errores
    Public myObject As New Erroresentrada()
    'ddeclaracion de variables
    Public moneda As String = ""
    Public valid As Boolean = False
    '-----------------------------problema 2
    '------------------------------------------------1- euros a dolares
    Public Sub Entrada1()
        Console.WriteLine("---------------------------------------------------------------------------")
        Dim euro As Decimal
        Dim dolar As Decimal
        '--------
        Console.Write(vbCrLf & "Ingrese la cantidad de euros que desea convertir a dólares: $ ")
        While Not valid
            moneda = Console.ReadLine()
            If Not IsNumeric(moneda) Then
                myObject.Errorp2()
                Console.Write(vbCrLf & "Ingrese la cantidad de euros que desea convertir a dólares: $ ")
            Else
                If moneda <= 0 Or moneda > 1000000 Then
                    myObject.Errorpppp()
                    Console.Write(vbCrLf & "Ingrese la cantidad de euros que desea convertir a dólares: $ ")
                Else
                    If moneda.Length > 1 And moneda.Chars(0) = "0" Then
                        myObject.Errorp2()
                        Console.Write(vbCrLf & "Ingrese la cantidad de euros que desea convertir a dólares: $ ")
                    Else
                        valid = True
                        End If
                    End If
                End If

        End While
        '--------
        euro = Convert.ToDecimal(moneda)
        Console.WriteLine(vbCrLf & "---------------------------------------------------------------------------")
        dolar = euro * 1.18
        Console.WriteLine("$ " & euro.ToString("#,##0.00") & " euros son $ " & dolar.ToString("#,##0.00") & " dólares")
        valid = False
    End Sub
    '------------------------------------------------2- dolares a euros
    Public Sub Entrada2()
        Console.WriteLine("---------------------------------------------------------------------------")
        Dim euro As Decimal
        Dim dolar As Decimal
        '--------
        Console.Write(vbCrLf & "Ingrese la cantidad de dólares que desea convertir a euros: $ ")
        While Not valid
            moneda = Console.ReadLine()
            If Not IsNumeric(moneda) Then
                myObject.Errorp2()
                Console.Write(vbCrLf & "Ingrese la cantidad de dólares que desea convertir a euros: $ ")
            Else
                If moneda <= 0 Or moneda > 1000000 Then
                    myObject.Errorpppp()
                    Console.Write(vbCrLf & "Ingrese la cantidad de dólares que desea convertir a euros: $ ")
                Else
                    If moneda.Length > 1 And moneda.Chars(0) = "0" Then
                        myObject.Errorp2()
                        Console.Write(vbCrLf & "Ingrese la cantidad de dólares que desea convertir a euros: $ ")
                    Else
                        valid = True
                    End If
                End If
            End If
        End While
        '--------
        dolar = Convert.ToDecimal(moneda)
        Console.WriteLine(vbCrLf & "---------------------------------------------------------------------------")
        euro = dolar * 0.85
        Console.WriteLine("$ " & dolar.ToString("#,##0.00") & " dólares son $ " & euro.ToString("#,##0.00") & " euros")
        valid = False
    End Sub
    '------------------------------------------------3- dolares a yen
    Public Sub Entrada3()

        Console.WriteLine("---------------------------------------------------------------------------")
        Dim dolar As Decimal
        Dim yen As Decimal
        '--------
        Console.Write(vbCrLf & "Ingrese la cantidad de dólares que desea convertir a yenes: $ ")
        While Not valid
            moneda = Console.ReadLine()
            If Not IsNumeric(moneda) Then
                myObject.Errorp2()
                Console.Write(vbCrLf & "Ingrese la cantidad de dólares que desea convertir a yenes: $ ")
            Else
                If moneda <= 0 Or moneda > 1000000 Then
                    myObject.Errorpppp()
                    Console.Write(vbCrLf & "Ingrese la cantidad de dólares que desea convertir a yenes: $ ")
                Else
                    If moneda.Length > 1 And moneda.Chars(0) = "0" Then
                        myObject.Errorp2()
                        Console.Write(vbCrLf & "Ingrese la cantidad de dólares que desea convertir a yenes: $ ")
                    Else
                        valid = True
                    End If
                End If
            End If
        End While
        '--------
        dolar = Convert.ToDecimal(moneda)
        Console.WriteLine(vbCrLf & "---------------------------------------------------------------------------")
        yen = dolar * 109.98
        Console.WriteLine("$ " & dolar.ToString("#,##0.00") & " dólares son $ " & yen.ToString("#,##0.00") & " yenes")
        valid = False
    End Sub
    '------------------------------------------------4- yen a dolares
    Public Sub Entrada4()
        Console.WriteLine("---------------------------------------------------------------------------")
        Dim dolar As Decimal
        Dim yen As Decimal

        '-------
        Console.Write(vbCrLf & "Ingrese la cantidad de yenes que desea convertir a dólares: $ ")
        While Not valid
            moneda = Console.ReadLine()
            If Not IsNumeric(moneda) Then
                myObject.Errorp2()
                Console.Write(vbCrLf & "Ingrese la cantidad de yenes que desea convertir a dólares: $ ")
            Else
                If moneda <= 0 Or moneda > 1000000 Then
                    myObject.Errorpppp()
                    Console.Write(vbCrLf & "Ingrese la cantidad de yenes que desea convertir a dólares: $ ")
                Else
                    If moneda.Length > 1 And moneda.Chars(0) = "0" Then
                        myObject.Errorp2()
                        Console.Write(vbCrLf & "Ingrese la cantidad de yenes que desea convertir a dólares: $ ")
                    Else
                        valid = True
                    End If
                End If
            End If
        End While
        '--------
        yen = Convert.ToDecimal(moneda)
        Console.WriteLine(vbCrLf & "---------------------------------------------------------------------------")
        dolar = yen * 0.0091
        Console.WriteLine("$ " & yen.ToString("#,##0.00") & " yenes son $ " & dolar.ToString("#,##0.00") & " dólares")
        valid = False
    End Sub
    '-------------------------------------------------5- dolares a pesetas
    Public Sub Entrada5()
        Dim dolar As Decimal

        Dim peseta As Decimal
        Console.WriteLine("---------------------------------------------------------------------------")
        libra = 0
        Console.Write(vbCrLf & "Ingrese la cantidad de dólares que desea convertir a pesetas: $ ")
        While Not valid
            moneda = Console.ReadLine()
            If Not IsNumeric(moneda) Then
                myObject.Errorp2()
                Console.Write(vbCrLf & "Ingrese la cantidad de dólares que desea convertir a pesetas: $ ")
            Else
                If moneda <= 0 Or moneda > 1000000 Then
                    myObject.Errorpppp()
                    Console.Write(vbCrLf & "Ingrese la cantidad de dólares que desea convertir a pesetas: $ ")
                Else
                    If moneda.Length > 1 And moneda.Chars(0) = "0" Then
                        myObject.Errorp2()
                        Console.Write(vbCrLf & "Ingrese la cantidad de dólares que desea convertir a pesetas: $ ")
                    Else
                        valid = True
                    End If
                End If
            End If
        End While
        dolar = Convert.ToDecimal(moneda)
        Console.WriteLine("---------------------------------------------------------------------------")
        peseta = dolar * 166.39
        Console.WriteLine("$ " & dolar.ToString("#,##0.00") & " dólares son $ " & peseta.ToString("#,##0.00") & " pesetas")
        valid = False
    End Sub
    '-------------------------------------------------6- pesetas a dolares
    Public Sub Entrada6()

        Dim dolar As Decimal

        Dim peseta As Decimal
        Console.WriteLine("---------------------------------------------------------------------------")
        '------------
        Console.Write(vbCrLf & "Ingrese la cantidad de pesetas que desea convertir a dólares:$ ")
        While Not valid
            moneda = Console.ReadLine()
            If Not IsNumeric(moneda) Then
                myObject.Errorp2()
                Console.Write(vbCrLf & "Ingrese la cantidad de pesetas que desea convertir a dólares: $ ")
            Else
                If moneda <= 0 Or moneda > 1000000 Then
                    myObject.Errorpppp()
                    Console.Write(vbCrLf & "Ingrese la cantidad de pesetas que desea convertir a dólares: $ ")
                Else
                    If moneda.Length > 1 And moneda.Chars(0) = "0" Then
                        myObject.Errorp2()
                        Console.Write(vbCrLf & "Ingrese la cantidad de pesetas que desea convertir a dólares: $ ")
                    Else
                        valid = True
                    End If
                End If
            End If
        End While
        peseta = Convert.ToDecimal(moneda)
        Console.WriteLine("---------------------------------------------------------------------------")
        dolar = peseta * 0.006
        Console.WriteLine("$ " & peseta.ToString("#,##0.00") & " pesetas son $" & dolar.ToString("#,##0.00") & " dólares")
        valid = False
    End Sub
    '-------------------------------------------------7- doalres a pesetas
    Public Sub Entrada7()
        Console.WriteLine("---------------------------------------------------------------------------")
        Dim dolar As Decimal

        Dim libra As Decimal
        '------------
        Console.Write(vbCrLf & "Ingrese la cantidad de dólares que desea convertir a libras: $ ")
        While Not valid
            moneda = Console.ReadLine()
            If Not IsNumeric(moneda) Then
                myObject.Errorp2()
                Console.Write(vbCrLf & "Ingrese la cantidad de dólares que desea convertir a libras:$ ")
            Else
                If moneda <= 0 Or moneda > 1000000 Then
                    myObject.Errorpppp()
                    Console.Write(vbCrLf & "Ingrese la cantidad de dólares que desea convertir a libras: $ ")
                Else
                    If moneda.Length > 1 And moneda.Chars(0) = "0" Then
                        myObject.Errorp2()
                        Console.Write(vbCrLf & "Ingrese la cantidad de dólares que desea convertir a libras: $ ")
                    Else
                        valid = True
                    End If
                End If
            End If
        End While
        dolar = Convert.ToDecimal(moneda)
        Console.WriteLine("---------------------------------------------------------------------------")
        libra = dolar * 0.72
        Console.WriteLine("$ " & dolar.ToString("#,##0.00") & " dólares son $" & libra.ToString("#,##0.00") & " libras")
        valid = False
    End Sub

    '-------------------------------------------------8-libras a dolares
    Public Sub Entrada8()
        Console.WriteLine("---------------------------------------------------------------------------")
        Dim dolar As Decimal
        Dim libra As Decimal
        '----------
        Console.Write(vbCrLf & "Ingrese la cantidad de libras que desea convertir a dólares: $ ")
        While Not valid
            moneda = Console.ReadLine()
            If Not IsNumeric(moneda) Then
                myObject.Errorp2()
                Console.Write(vbCrLf & "Ingrese la cantidad de libras que desea convertir a dólares: $ ")
            Else
                If moneda <= 0 Or moneda > 1000000 Then
                    myObject.Errorpppp()
                    Console.Write(vbCrLf & "Ingrese la cantidad de libras que desea convertir a dólares: $ ")
                Else
                    If moneda.Length > 1 And moneda.Chars(0) = "0" Then
                        myObject.Errorp2()
                        Console.Write(vbCrLf & "Ingrese la cantidad de libras que desea convertir a dólares: $ ")
                    Else
                        valid = True
                    End If
                End If
            End If
        End While
        libra = Convert.ToDecimal(moneda)
        Console.WriteLine("---------------------------------------------------------------------------")
        dolar = libra * 1.39
        Console.WriteLine("$ " & libra.ToString("#,##0.00") & " libras son $" & dolar.ToString("#,##0.00") & " dólares")
        valid = False
    End Sub
    '-------------------------------------------------9- conversion de todas las materias
    Public Sub Entrada9()
        Console.WriteLine("---------------------------------------------------------------------------")
        euro = 0
        dolar = 0
        yen = 0
        peseta = 0
        libra = 0
        Console.Write(vbCrLf & "Ingrese la cantidad de dolares: $ ")
        While Not valid
            moneda = Console.ReadLine()
            If Not IsNumeric(moneda) Then
                myObject.Errorp2()
                Console.Write(vbCrLf & "Ingrese la cantidad de dólares: $ ")
            Else
                If moneda <= 0 Or moneda > 1000000 Then
                    myObject.Errorpppp()
                    Console.Write(vbCrLf & "Ingrese la cantidad de  dólares: $ ")
                Else
                    If moneda.Length > 1 And moneda.Chars(0) = "0" Then
                        myObject.Errorp2()
                        Console.Write(vbCrLf & "Ingrese la cantidad de  dólares: $ ")
                    Else
                        valid = True
                    End If
                End If
            End If
        End While
        dolar = Convert.ToDecimal(moneda)
        Console.WriteLine("---------------------------------------------------------------------------")
        euro = dolar * 0.85
        yen = dolar * 109.98
        peseta = dolar * 166.39
        libra = dolar * 0.72
        Console.WriteLine("1- $ " & euro.ToString("#,##0.00") & " euros" & vbCrLf &
                          "2- $ " & yen.ToString("#,##0.00") & " yenes" & vbCrLf &
                          "3- $ " & peseta.ToString("#,##0.00") & " pesetas" & vbCrLf &
                          "4- $ " & libra.ToString("#,##0.00") & " libras")
        valid = False
    End Sub
    '-------------------------------probleme1
    Public Sub Problem1calc()
        Dim imprDivs As Double = 1
        Dim imprMod As Double = 1
        '--------------------------------------------------------------------------------------------
        Dim suma As Double = 0
        Dim resta As Double = 0
        Dim multiplicacion As Double = 1
        Dim division As Double = 1
        Dim exponente As Double = 1
        Dim modulo As Integer = 0

        Dim myObjectvalor As New ValorEntrada()
        Dim entradaValidaproblema1 As Boolean = False
        Dim entradaproblema1 As String = ""
        While Not entradaValidaproblema1
            Console.WriteLine("--------------------------------------------------------------------" & vbCrLf &
                              "                        Problema #1                                 " & vbCrLf &
                              "--------------------------------------------------------------------" & vbCrLf &
                              "       Ingrese la cantidad de números a calcular:                      " & vbCrLf &
                              "--------------------------------------------------------------------" & vbCrLf)
            entradaproblema1 = Console.ReadLine()
            If Not IsNumeric(entradaproblema1) Or entradaproblema1.Contains(",") Or entradaproblema1.Contains(".") Then
                myObject.Problem1sum()
            Else
                If entradaproblema1 > 10 Or entradaproblema1 <= 0 Or entradaproblema1 = 1 Or (entradaproblema1.Length > 1 And entradaproblema1.Chars(0) = "0") Then
                    If entradaproblema1 = 1 Then
                        myObject.Problem1sum3()
                    Else
                        myObject.Problem1sum2()
                    End If
                Else
                    entradaValidaproblema1 = True
                End If
            End If
        End While
        Dim numeroproblema1 As Integer = Convert.ToInt32(entradaproblema1)
        Dim i As Integer = 0
        Dim numeros(numeroproblema1 - 1) As Double
        While i < numeroproblema1
            '---------------------------------
            Dim entradaValidaproblema1p As Boolean = False
            Dim entradaproblema1p As String = ""
            While Not entradaValidaproblema1p
                Console.WriteLine(vbCrLf & "--------------------------------------------------------------------" & vbCrLf &
                      "       Ingrese el # " & (i + 1) & " :  " & vbCrLf &
                      "--------------------------------------------------------------------")
                entradaproblema1p = Console.ReadLine()
                If Not IsNumeric(entradaproblema1p) Or entradaproblema1p.Contains(",") Or entradaproblema1p.Contains(" ") Then
                    myObject.Problem1sum()
                Else
                    If entradaproblema1p.Chars(0) = "0" Or entradaproblema1p.Chars(0) = "" Then
                        If entradaproblema1p.Length > 1 Then
                            myObject.Problem1sum()
                        Else
                            entradaValidaproblema1p = True
                        End If
                    Else
                        entradaValidaproblema1p = True
                    End If
                End If
            End While
            numeros(i) = Convert.ToDecimal(entradaproblema1p)

            '---------------------
            If numeros(i) = 0 Then
                suma += numeros(i)
                resta -= numeros(i)
                multiplicacion *= numeros(i)
                If i = 0 Then
                    exponente = 0
                Else
                    exponente = Math.Pow(exponente, numeros(i))
                End If
                imprDivs = 0
                imprMod = 0
                i += 1
            Else
                If i = 0 Then
                    suma = numeros(i)
                    resta = numeros(i)
                    modulo = numeros(i)
                    multiplicacion = numeros(i)
                    division = numeros(i)
                    exponente = numeros(i)
                    i += 1
                ElseIf ((exponente ^ numeros(i)) > Double.MaxValue) Or ((multiplicacion * numeros(i)) > Double.MaxValue) Or ((suma + numeros(i)) > Double.MaxValue) Then
                    Console.ForegroundColor = ConsoleColor.Red
                    Console.Write(vbCrLf & "Error:El valor excede la capacidad del programa :" & Double.MaxValue)

                    Console.ResetColor()
                    If i > 0 Then
                        i = i
                    End If
                Else
                    suma += numeros(i)
                    resta -= numeros(i)
                    multiplicacion *= numeros(i)
                    division /= numeros(i)
                    exponente = Math.Pow(exponente, numeros(i))
                    modulo = modulo Mod numeros(i)
                    i += 1
                End If

            End If
            '-----------------------------------------------------------------------------
        End While
        Console.Clear()
        Console.Write(vbCrLf & "--------------------------------------------------------------------" & vbCrLf &
                               "                          Resultados         " & vbCrLf &
                               "--------------------------------------------------------------------" & vbCrLf &
                               " La cantidad de numeros son:   " & numeroproblema1 & vbCrLf &
                               " Los valores ingresados son: { ")
        For Each elemento In numeros
            If elemento = 0 Then
                Console.Write(" {0} ", elemento)
            Else
                If Integer.TryParse(elemento, Nothing) Then
                    Console.Write(elemento.ToString("#,##0") & " ")
                Else
                    If Decimal.TryParse(elemento, Nothing) Then
                        Console.Write(elemento.ToString("#,##0.00") & " ")
                    End If
                End If
            End If
        Next
        Dim sumastring As String = ""
        Dim restastring As String = ""
        Dim multistring As String = ""
        Dim exponstring As String = ""
        Dim divstring As String = ""
        'impresion del valor de suma
        If Integer.TryParse(suma, Nothing) Then
            sumastring = suma.ToString("#,##0")
        Else
            If Decimal.TryParse(suma, Nothing) Then
                sumastring = suma.ToString("#,##0.00")
            End If
        End If
        'impresion del valor de resta
        If Integer.TryParse(resta, Nothing) Then
            restastring = resta.ToString("#,##0")
        Else
            If Decimal.TryParse(resta, Nothing) Then
                restastring = resta.ToString("#,##0.00")
            End If
        End If
        'impresion del valor de multi
        If Integer.TryParse(multiplicacion, Nothing) Then
            multistring = multiplicacion.ToString("#,##0")
        Else
            If Decimal.TryParse(multiplicacion, Nothing) Then
                multistring = multiplicacion.ToString("#,##0.00")
            End If
        End If
        'impresion del valor de div
        If Integer.TryParse(division, Nothing) Then
            divstring = division.ToString("#,##0")
        Else
            If Decimal.TryParse(division, Nothing) Then
                divstring = division.ToString("#,##0.00")
            End If
        End If
        'impresion final
        Console.Write("}" & vbCrLf & "--------------------------------------------------------------------" & vbCrLf)
        Console.Write("1 - Suma:             " & sumastring & vbCrLf &
                      "2 - Resta:            " & restastring & vbCrLf &
                      "3 - Multiplicación:   " & multistring & vbCrLf)
        If exponente <= 10000 Then
            'impresion del valor de exp
            If Integer.TryParse(exponente, Nothing) Then
                exponstring = exponente.ToString("#,##0")
            Else
                If Double.TryParse(exponente, Nothing) Then
                    exponstring = exponente.ToString("#,##0.00")
                End If
            End If
            Console.Write("4 - Exponente:        " & exponstring & vbCrLf)
        Else
            If exponente > 10000 And exponente < 100000 Then
                'impresion del valor de exp 2
                If Integer.TryParse(exponente, Nothing) Then
                    exponstring = (exponente).ToString("0.00E+0")
                Else
                    If Double.TryParse(exponente, Nothing) Then
                        exponstring = (exponente).ToString("0.00E+0")
                    End If
                End If
                Console.Write("4 - Exponente:        " & exponstring & vbCrLf)
            Else
                If exponente >= 100000 Then
                    'impresion del valor de exp 2

                    If Integer.TryParse(exponente, Nothing) Then
                        exponstring = (exponente).ToString("0.0000E+0")
                    Else
                        If Double.TryParse(exponente, Nothing) Then
                            exponstring = (exponente).ToString("0.0000E+0")
                        End If
                    End If
                    Console.Write("4 - Exponente:        " & exponstring & vbCrLf)
                End If
            End If
        End If
        Dim numerador As Integer = CInt(division * 100)
        Dim denominador As Integer = 100
        While numerador Mod 2 = 0 AndAlso denominador Mod 2 = 0
            numerador \= 2
            denominador \= 2
        End While
        While numerador Mod 5 = 0 AndAlso denominador Mod 5 = 0
            numerador \= 5
            denominador \= 5
        End While
        If imprDivs = 0 Then
            Console.Write("5 - Division:         " & "Indeterminado" & vbCrLf)
            If imprMod = 0 Then
                Console.Write("6 - Módulo o residuo: " & "Indeterminado" & vbCrLf)
            Else
                Console.Write("5 - División:         " & divstring & vbCrLf &
                          "6 - Módulo o residuo: " & modulo & vbCrLf)
            End If
        Else
            Console.Write("5 - División:         " & divstring & "  ó  " & numerador & "/" & denominador & vbCrLf &
                  "6 - Módulo o residuo: " & modulo & vbCrLf)
        End If
        '-----------------------------------------
        '--------------------------------------------
        Console.Write(vbCrLf & "--------------------------------------------------------------------" & vbCrLf)
    End Sub
    '------------------------------problema 3
    Public Sub TiempoMili()
        Console.Clear()
        Console.WriteLine("---------------------------------------------------------------------------" & vbCrLf &
                          "                        Problema #3" & vbCrLf &
                          "---------------------------------------------------------------------------" & vbCrLf)
        '-----------------------Problema #3-----------------------------------------------

        '------------------------------------
        Dim a As Double = 0
        While a <> 3
            Dim tiempo As TimeSpan
            Dim validInput As Boolean = False
            Dim valimenu As Boolean = False
            Dim menup3 As String = ""
            While Not valimenu
                myObject.menutimep3()
                menup3 = Console.ReadLine()
                If Not IsNumeric(menup3) Or menup3.Contains(",") Or menup3.Contains(".") Then
                    myObject.Errorfmt2()
                    menup3 = Console.ReadLine()
                Else
                    If menup3 > 3 Or menup3 < 1 Then
                        myObject.Errorp21()
                    Else
                        If menup3.Length > 1 And menup3.Chars(0) = "0" Then
                            myObject.Errorp21()
                        Else
                            valimenu = True
                        End If
                    End If

                End If
            End While
            a = Convert.ToDecimal(menup3)
            Select Case a
                Case = 1
                    '------------------------------------
                    Dim ap1 As String = ""
                    While ap1 <> "a"
                        Console.Clear()
                        '------------------------------------------------------------------------------------------------------------------
                        Dim input As String = ""
                        While Not validInput
                            Console.Clear()
                            Console.WriteLine("---------------------------------------------------------------------------" & vbCrLf &
                                          "             Introduce la hora en formato militar (HH:MM:SS): " & vbCrLf &
                                          "---------------------------------------------------------------------------" & vbCrLf)
                            input = Console.ReadLine()
                            If input.Contains(",") Or input.Contains(".") Or input.Contains("00") Or Not input.Contains(":") Or input.Length > 8 Or Not input.Length >= 5 Then
                                myObject.Errorformtahoramili()
                            Else
                                If TimeSpan.TryParse(input, tiempo) Then

                                    validInput = True
                                Else
                                    myObject.Errorformtahoramili2()
                                End If
                            End If
                        End While
                        Console.Clear()
                        Console.WriteLine("---------------------------------------------------------------------------" & vbCrLf &
                                      " Hora Ingresada: {0}", input)
                        tiempo = tiempo.Add(TimeSpan.FromSeconds(1))
                        Console.WriteLine("---------------------------------------------------------------------------" & vbCrLf & "  +1 segundo después:" & vbCrLf)
                        Console.Write("          {0} horas :", tiempo.Hours)
                        Console.Write(" {0} minutos :", tiempo.Minutes)
                        Console.Write(" {0} segundos" & vbCrLf &
                                  "---------------------------------------------------------------------------" & vbCrLf, tiempo.Seconds)
                        validInput = False

                        '-------------------------
                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine(vbCrLf & " Presione 'a' si desea volver al menu, si no 'ENTER' para continuar")
                        Console.ResetColor()
                        ap1 = Console.ReadLine()
                    End While

            '-------------------------------
                Case = 2
                    '-------------------------------
                    Dim ap1 As String = ""
                    While ap1 <> "a"
                        Console.Clear()
                        '------------------------------------------------------------------------------------------------------------------
                        Dim validtempo As Boolean = False
                        Dim tempo(3) As String
                        Dim nametempo(3) As String
                        Dim enterostempos(3) As Integer
                        nametempo(0) = "Hora"
                        nametempo(1) = "minuto"
                        nametempo(2) = "segundos"
                        Dim i As Integer
                        i = 0
                        While Not validtempo
                            Console.WriteLine("Ingrese" & nametempo(i) & ":")
                            tempo(i) = Console.ReadLine
                            If Not IsNumeric(tempo(i)) Then
                                myObject.Errorfm()
                            Else
                                If tempo(i).Contains(".") Or tempo(i).Contains(",") Then
                                    myObject.Errorfm()
                                Else
                                    If tempo(i).Length > 1 And tempo(i).Chars(0) = "0" Then
                                        myObject.Errorfm()
                                    Else
                                        If tempo(0) < 0 Or tempo(0) > 23 Then
                                            myObject.Tempohora()
                                        Else
                                            If tempo(1) < 0 Or tempo(1) > 59 Then
                                                myObject.Tempominseg()
                                            Else
                                                If tempo(2) < 0 Or tempo(2) > 59 Then
                                                    myObject.Tempominseg()
                                                Else

                                                    If i = 2 Then
                                                        validtempo = True
                                                        i += 1
                                                    Else
                                                        i += 1
                                                    End If
                                                End If
                                            End If
                                        End If

                                    End If
                                End If
                            End If
                        End While
                        enterostempos(0) = Convert.ToInt32(tempo(0))
                        enterostempos(1) = Convert.ToInt32(tempo(1))
                        enterostempos(2) = Convert.ToInt32(tempo(2))
                        Dim cad As String = enterostempos(0) & ":" & enterostempos(1) & ":" & enterostempos(2)
                        Dim formt As String = "HH:mm:ss"
                        Dim dat As DateTime = Date.Parse(cad)

                        Dim strcad As String = dat.ToString(formt)
                        Console.Clear()
                        Console.Write(vbCrLf & "   _______________________________" & vbCrLf &
                                      "  |                   HH:MM:SS    | " & vbCrLf &
                                      "  | Hora ingresada:   " & strcad & "    | " & vbCrLf &
                                      "  |_______________________________|" & vbCrLf &
                                      "  |             +1seg             | " & vbCrLf &
                                      "  |¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨|" & vbCrLf)

                        Dim cad2 As String = enterostempos(0) & ":" & enterostempos(1) & ":" & enterostempos(2)
                        Dim dat2 As DateTime = dat.AddSeconds(1)

                        Dim strcad2 As String = dat2.ToString(formt)

                        Console.Write("  |            " & strcad2 & "           |" & vbCrLf &
                                  "  |_______________________________|" & vbCrLf)
                        '-------------------------
                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine(vbCrLf & " Presione 'a' si desea volver al menu anterior, si no 'ENTER' para continuar")
                        Console.ResetColor()
                    ap1 = Console.ReadLine()
                    End While
                    '-------------------------------

                Case = 3
                    a = 3
            End Select
        End While
    End Sub
End Class
