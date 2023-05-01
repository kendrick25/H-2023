Module Module1
    Sub Main()

        'Problema #1.
        Dim precioUnitario As Double
        Dim cantidadVenta As Integer
        Dim precioParcial As Double
        Dim descuento As Double
        Dim precioNeto As Double

        Dim lectDesc As String
        Dim num As Integer
        Dim n As String

        ' Problema #2
        Dim sueldoAnual As Double
        Dim antiguedad As Integer
        'ejemplo
        Dim menue As Integer = 0
        ' ----------------------------------------------------------------------------------------------
        While menue <> 3
            Console.WriteLine("---------------------------------GRUPO CONTABLESA-------------------------------" & vbCrLf & "")
            Try
                '---------------------------MENU----------------------------------------------------------
                Console.WriteLine("                                        Menu" & vbCrLf & "" & vbCrLf & "  1- Problema #1 - Precio unitario de un producto vendido y la cantidad de venta." & vbCrLf & "" & vbCrLf & "  2- Problema #2- Calcular el sueldo de trabajador." & vbCrLf & "" & vbCrLf & "  3- Finalizar." & vbCrLf & "" & vbCrLf & "---------------------------------------------------------------------------------")
                menue = Console.ReadLine()
                '---------------Error de Menu---------------------------------------------------------------------------
                If menue >= 4 Then
                    Console.WriteLine("----------------------------------------------------" & vbCrLf & "El # ingresado no esta en el menu seleccion." & vbCrLf & "----------------------------------------------------")
                End If
                '-----------------opciones de menu-------------------------------------------------------------------------
                Select Case menue
                    Case "1"
                        '------------------Problema #1------------------------------------------------------------
                        Console.WriteLine("------------------------------------------------------" & vbCrLf & "Ingrese el precio unitario del producto vendido:")
                        precioUnitario = Console.ReadLine()

                        Console.WriteLine("Ingrese la cantidad de venta: ")
                        cantidadVenta = Console.ReadLine()

                        precioParcial = precioUnitario * cantidadVenta

                        Console.WriteLine("el precio parcial es :" & precioParcial & vbCrLf & " ¿Desea aplicar descuento? (S/N)")
                        num = 0
                        lectDesc = Console.ReadLine()
                        If lectDesc = "S" Or lectDesc = "s" Then

                            Console.WriteLine("------------------------------------------------------ " & vbCrLf & vbCrLf & "Seleccione el porcentaje de descuento:")
                            Console.WriteLine("1- 7% " & vbCrLf & "2- 10%" & vbCrLf & "3- 20%" & vbCrLf & "4- 30%" & vbCrLf & "5- 40%" & vbCrLf & "6- 50%" & vbCrLf & "------------------------------------------------------ ")
                            While num = 0
                                n = Console.ReadLine()
                                If n = "1" Or n = "2" Or n = "3" Or n = "4" Or n = "5" Or n = "6" Then
                                    Select Case n
                                        Case "1"
                                            num = 1
                                            descuento = precioParcial * 0.07
                                        Case "2"
                                            num = 1
                                            descuento = precioParcial * 0.1
                                        Case "3"
                                            num = 1
                                            descuento = precioParcial * 0.2
                                        Case "4"
                                            num = 1
                                            descuento = precioParcial * 0.3
                                        Case "5"
                                            num = 1
                                            descuento = precioParcial * 0.4
                                        Case "6"
                                            num = 1
                                            descuento = precioParcial * 0.5
                                    End Select
                                Else
                                    Console.Clear()
                                    Console.WriteLine("------------------------------------------------------" & vbCrLf & vbCrLf & "Has introducido un caracter no valido")
                                    Console.WriteLine("------------------------------------------------------ " & vbCrLf & vbCrLf & "Seleccione el porcentaje de descuento:")
                                    Console.WriteLine("1- 7% " & vbCrLf & "2- 10%" & vbCrLf & "3- 20%" & vbCrLf & "4- 30%" & vbCrLf & "5- 40%" & vbCrLf & "6- 50%" & vbCrLf & "------------------------------------------------------ ")
                                End If
                            End While
                            precioNeto = precioParcial - descuento
                            Console.WriteLine("Precio neto:...........$ " & precioNeto)
                            Console.ReadKey()
                            Console.Clear()
                        Else
                            If lectDesc = "N" Or lectDesc = "n" Then
                                num = 0
                                Console.WriteLine("------------------------------------------------------ " & vbCrLf & "No se aplico Descuento" & vbCrLf & "------------------------------------------------------ ")
                            Else
                                num = 0
                                Console.WriteLine("------------------------------------------------------ " & vbCrLf & "Has ingresado un valor incorrecto, por lo tanto no se aplico el descuento." & vbCrLf & "------------------------------------------------------ ")
                            End If

                            Console.WriteLine(vbCrLf & "Precio neto:...........$ " & precioParcial & vbCrLf & "presione ''enter'' para volver al menu")
                        End If
                '----------------------------Fin de Problema# 1-------------------------------------------------------------
                    Case "2"
                        '--------------Problema #2---------------------------
                        Dim number As Double
                        Dim number2 As Double
                        Dim n3 As Integer = 0
                        While n3 = 0
                            Console.WriteLine("------------------------------------------------------ " & vbCrLf & "Ingresa el Sueldo anual del trabajador:")
                            sueldoAnual = Console.ReadLine()
                            If Double.TryParse(sueldoAnual, number) Then
                                Console.WriteLine("------------------------------------------------------ " & vbCrLf & "Ingrese la antigüedad del trabajador en años:")
                                antiguedad = Console.ReadLine()

                                If Double.TryParse(antiguedad, number2) Then
                                    If antiguedad >= 10 Then
                                        sueldoAnual *= 1.1
                                        n3 = 1
                                    ElseIf antiguedad >= 5 Then
                                        sueldoAnual *= 1.07
                                        n3 = 1
                                    ElseIf antiguedad >= 3 Then
                                        sueldoAnual *= 1.05
                                        n3 = 1
                                    Else
                                        sueldoAnual *= 1.03
                                        n3 = 1
                                    End If
                                Else
                                    Console.WriteLine("El valor ingresado es incorrecto 2")
                                End If
                            Else
                                Console.WriteLine("El valor ingresado es incorrecto")
                            End If
                        End While

                        Console.WriteLine("------------------------------------------------------ " & vbCrLf & "Sueldo anual:...........$ " & sueldoAnual & vbCrLf & "presione ''enter'' para volver al menu")
                        Console.ReadKey()
                        Console.Clear()
                        '----------------------Fin de Problema #2--------------------------------------------------------
                    Case "3"
                        '---------------------Opcion #3---------------------------------------------------------
                        Console.WriteLine("Presiona cualquier tecla para salir...")
                        Console.ReadKey()
                        Environment.Exit(0)
                End Select
                '---------------------------Fin de select------------------------------------------------------------
            Catch ex As Exception
                Console.WriteLine("Has ingresado un valor incorrecto." & vbCrLf & "Presione enter para seguir ")
            End Try
            Console.ReadKey()
            Console.Clear()
        End While
        ' ---------------------------------Fin de While-------------------------------------------------------------
    End Sub
End Module

