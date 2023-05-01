Imports System.ComponentModel.Design
Imports System.Net.Security

Module Module1
    Sub Main()
        Dim myObjecterrores As New Erroresentrada()
        Dim menu As Integer = 0
        While menu <> 4
            Try
                '------------------------Menu--------------------------------------------------------
                myObjecterrores.menuerror2()
                Dim entradaValidamenu As Boolean = False
                Dim entradamenu As String = ""
                While Not entradaValidamenu
                    entradamenu = Console.ReadLine()
                    If Not IsNumeric(entradamenu) Then
                        myObjecterrores.Errormenu1()
                        myObjecterrores.menuerror2()
                    Else
                        If entradamenu.Length > 1 And entradamenu.Chars(0) = "0" Then
                            myObjecterrores.Errormenu1()
                            myObjecterrores.menuerror2()
                        Else
                            entradaValidamenu = True
                        End If
                    End If
                End While
                Dim numeromenu As Integer = Convert.ToInt32(entradamenu)
                Select Case numeromenu
                    Case "1"
                        Dim ap1 As String = ""
                        While ap1 <> "a"
                            Console.Clear()
                            '---------------------------Problema #1------------------------------------------------------
                            Dim myObject As New ValorEntrada()
                            myObject.Problem1calc()
                            '-------------------------
                            Console.ForegroundColor = ConsoleColor.Green
                            Console.WriteLine(" Presione 'a' si desea volver al menu, si no 'ENTER' para continuar")
                            Console.ResetColor()
                            ap1 = Console.ReadLine()
                        End While
                        Console.Clear()
                    '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    Case "2"
                        Console.Clear()
                        '---------------------------Problema #2------------------------------------------------------
                        Dim n As Integer = 0
                        While n <> 1
                            Dim entradaValida As Boolean = False
                            Dim entrada As String = ""
                            While Not entradaValida
                                myObjecterrores.menuproblem2()
                                entrada = Console.ReadLine()
                                If Not IsNumeric(entrada) Or entrada.Contains(",") Or entrada.Contains(".") Then
                                    myObjecterrores.Errorp22()
                                Else
                                    If entrada < 1 Or entrada > 10 Or entrada.Length > 2 Or entrada.Chars(0) = "0" Then
                                        myObjecterrores.Errorp22()
                                    Else
                                        entradaValida = True
                                        End If

                                End If
                            End While
                            Console.Clear()
                            Dim myObject As New ValorEntrada()
                            Dim numero As Integer = Convert.ToInt64(entrada)
                            Dim ap1 As String = ""
                            Select Case numero
                                Case 1
                                    While ap1 <> "a"
                                        myObject.Entrada1()
                                        '-------------------------
                                        Console.WriteLine(vbCrLf & "------------------------------------------------------------------------------" & vbCrLf)
                                        Console.ForegroundColor = ConsoleColor.Green
                                        Console.WriteLine("   Presione 'a' si desea volver al menu anterior, si no 'ENTER' para continuar")
                                        Console.ResetColor()
                                        ap1 = Console.ReadLine()
                                        Console.Clear()
                                    End While
                                Case 2
                                    While ap1 <> "a"
                                        myObject.Entrada2()
                                        '-------------------------
                                        Console.WriteLine(vbCrLf & "------------------------------------------------------------------------------" & vbCrLf)
                                        Console.ForegroundColor = ConsoleColor.Green
                                        Console.WriteLine("   Presione 'a' si desea volver al menu anterior, si no 'ENTER' para continuar")
                                        Console.ResetColor()
                                        ap1 = Console.ReadLine()
                                        Console.Clear()
                                    End While

                                Case 3
                                    While ap1 <> "a"
                                        myObject.Entrada3()
                                        '-------------------------
                                        Console.WriteLine(vbCrLf & "------------------------------------------------------------------------------" & vbCrLf)
                                        Console.ForegroundColor = ConsoleColor.Green
                                        Console.WriteLine("   Presione 'a' si desea volver al menu anterior, si no 'ENTER' para continuar")
                                        Console.ResetColor()
                                        ap1 = Console.ReadLine()
                                        Console.Clear()
                                    End While
                                Case 4
                                    While ap1 <> "a"
                                        myObject.Entrada4()
                                        '-------------------------
                                        Console.WriteLine(vbCrLf & "------------------------------------------------------------------------------" & vbCrLf)
                                        Console.ForegroundColor = ConsoleColor.Green

                                        Console.WriteLine("   Presione 'a' si desea volver al menu anterior, si no 'ENTER' para continuar")
                                        Console.ResetColor()
                                        ap1 = Console.ReadLine()
                                        Console.Clear()
                                    End While
                                Case 5
                                    While ap1 <> "a"
                                        myObject.Entrada5()
                                        Console.WriteLine(vbCrLf & "------------------------------------------------------------------------------" & vbCrLf)
                                        '-------------------------
                                        Console.ForegroundColor = ConsoleColor.Green
                                        Console.WriteLine("   Presione 'a' si desea volver al menu anterior, si no 'ENTER' para continuar")
                                        Console.ResetColor()
                                        ap1 = Console.ReadLine()
                                        Console.Clear()
                                    End While
                                Case 6
                                    While ap1 <> "a"
                                        myObject.Entrada6()
                                        '-------------------------
                                        Console.WriteLine(vbCrLf & "------------------------------------------------------------------------------" & vbCrLf)
                                        Console.ForegroundColor = ConsoleColor.Green
                                        Console.WriteLine("   Presione 'a' si desea volver al menu anterior, si no 'ENTER' para continuar")
                                        Console.ResetColor()
                                        ap1 = Console.ReadLine()
                                        Console.Clear()
                                    End While
                                Case 7
                                    While ap1 <> "a"
                                        myObject.Entrada7()
                                        '-------------------------
                                        Console.WriteLine(vbCrLf & "------------------------------------------------------------------------------" & vbCrLf)
                                        Console.ForegroundColor = ConsoleColor.Green
                                        Console.WriteLine("   Presione 'a' si desea volver al menu anterior, si no 'ENTER' para continuar")
                                        Console.ResetColor()
                                        ap1 = Console.ReadLine()
                                        Console.Clear()
                                    End While
                                Case 8
                                    While ap1 <> "a"
                                        myObject.Entrada8()
                                        '-------------------------
                                        Console.WriteLine(vbCrLf & "------------------------------------------------------------------------------" & vbCrLf)
                                        Console.ForegroundColor = ConsoleColor.Green
                                        Console.WriteLine("   Presione 'a' si desea volver al menu anterior, si no 'ENTER' para continuar")
                                        Console.ResetColor()
                                        ap1 = Console.ReadLine()
                                        Console.Clear()
                                    End While
                                Case 9
                                    While ap1 <> "a"
                                        myObject.Entrada9()
                                        '--------------------------
                                        Console.WriteLine(vbCrLf & "-----------------------------------------------------------------------------" & vbCrLf)
                                        Console.ForegroundColor = ConsoleColor.Green
                                        Console.WriteLine("   Presione 'a' si desea volver al menu anterior, si no 'ENTER' para continuar")
                                        Console.ResetColor()
                                        ap1 = Console.ReadLine()
                                        Console.Clear()
                                    End While
                                Case > 10
                                    myObjecterrores.Errorp21()
                                Case = 10
                                    n = 1
                                    Console.ForegroundColor = ConsoleColor.Green
                                    Console.WriteLine("   Presione cualquier tecla para continuar")
                                    Console.ResetColor()
                                    Console.ReadKey()
                            End Select
                            entradaValida = False
                            Console.Clear()
                        End While
                    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    Case "3"
                        '-------------------------------problema #3----------------------------------
                        Dim myObject As New ValorEntrada()
                        myObject.TiempoMili()
                    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    Case "4"
                        If numeromenu = 4 Then
                            myObjecterrores.Powerdecs()
                            Dim a As String = Console.ReadLine()
                            Select Case a
                                Case "1"
                                    myObjecterrores.Poweroff()
                                    menu = 4
                                Case Else
                                    Throw New Exception
                                    Console.Clear()
                            End Select
                        End If
                    Case > 4
                        myObjecterrores.Menuvalue()
                    Case <1
                        myObjecterrores.Menuvalue()
                End Select
            Catch ex As Exception
                myObjecterrores.errorfm()
        End Try
        End While
    End Sub
End Module


