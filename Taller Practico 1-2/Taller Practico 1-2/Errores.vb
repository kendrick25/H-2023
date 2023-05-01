Public Class Erroresentrada
    Public Sub Errormenu1()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(vbCrLf &
                                  "------------------------------------" & vbCrLf &
                                  "  Error: Ingrese un valor correcto" & vbCrLf &
                                  "-----------------------------------")
        Console.ReadKey()
        Console.ResetColor()
        Console.Clear()
    End Sub
    Public Sub Errorp2()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(vbCrLf &
                                          "------------------------------------" & vbCrLf &
                                          "  Error:revise el valor introducido." & vbCrLf &
                                          "-----------------------------------")
        Console.ReadKey()
        Console.ResetColor()
        Console.Clear()
    End Sub
    Public Sub Errorpppp()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(vbCrLf &
                                          "-------------------------------------------------------------------------------------" & vbCrLf &
                                          "  Error:revise el valor introducido deve ser mayor a 0 y no puede exceder del millon." & vbCrLf &
                                          "-------------------------------------------------------------------------------------")
        Console.ReadKey()
        Console.ResetColor()
        Console.Clear()
    End Sub
    Public Sub Errorp21()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("-----------------------------------" & vbCrLf &
                      "Error:Escoje una opcion del menu." & vbCrLf &
                      "-----------------------------------" & vbCrLf)
        Console.ResetColor()
        Console.ReadKey()
        Console.Clear()
    End Sub
    Public Sub Errorp22()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("----------------------------------------------------------------" & vbCrLf &
                          "Error: Debe ingresar un número de las opciones mostradas de  1 a 10" & vbCrLf &
                          "----------------------------------------------------------------" & vbCrLf)
        Console.ResetColor()
        Console.ReadKey()
        Console.Clear()
    End Sub
    Public Sub Errorfm()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(vbCrLf &
                                          "------------------------------------" & vbCrLf &
                                          "  Error:formato no valido." & vbCrLf &
                                          "-----------------------------------")
        Console.ReadKey()
        Console.ResetColor()
        Console.Clear()
    End Sub

    Public Sub Powerdecs()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(vbCrLf &
              "----------------------------------------------------" & vbCrLf &
              "                    Desea finalizar " & vbCrLf & "1- Si." & vbCrLf &
              "------Presiona cualquier tecla para continuar.------" & vbCrLf &
              "---------------------------------------------------")
        Console.ResetColor()
    End Sub
    Public Sub Poweroff()
        Console.ReadKey()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Red
        Console.Write(vbCrLf & "       ----------------------------------------------------------------------- " & vbCrLf &
                               "      |                                 OFF                                   |" & vbCrLf &
                               "       ----------------------------------------------------------------------- " & vbCrLf)
    End Sub
    Public Sub Menuvalue()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(vbCrLf &
                                          "----------------------------------------------------------------" & vbCrLf &
                                          "  Error:escoja una de las opciones del menu mostrado de 1 a 4." & vbCrLf &
                                          "----------------------------------------------------------------")
        Console.ReadKey()
        Console.ResetColor()
        Console.Clear()
    End Sub
    Public Sub Problem1sum()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(vbCrLf &
                  "-------------------------------------------" & vbCrLf &
                  "  Error:el valor ingresado es incorrecto." & vbCrLf &
                  "-------------------------------------------")
        Console.ReadKey()
        Console.ResetColor()
        Console.Clear()
    End Sub
    Public Sub Problem1sum2()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(vbCrLf &
                  "---------------------------------------------------------------" & vbCrLf &
                  " Error:Solo se admiten valores de 2 a 10 para realizar calculos" & vbCrLf &
                  "---------------------------------------------------------------")
        Console.ReadKey()
        Console.ResetColor()
        Console.Clear()
    End Sub
    Public Sub Problem1sum3()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(vbCrLf &
                  "---------------------------------------------------------------" & vbCrLf &
                  "  Error:ingrese mas de un valor para realizar calculos" & vbCrLf &
                  "---------------------------------------------------------------")
        Console.ReadKey()
        Console.ResetColor()
        Console.Clear()
    End Sub
    Public Sub Menuproblem2()
        Console.WriteLine(vbCrLf &
                                  "------------------------------------" & vbCrLf &
                                  "           Problema #2" & vbCrLf &
                                  "-----------------------------------")
        Console.WriteLine("-----------------------------------------" & vbCrLf &
                                      "  Escoja la moneda de conversion: " & vbCrLf &
                                      "------------------------------------------")
        Console.Write(vbCrLf &
                                      " 1- Euro a Dólares." & vbCrLf &
                                      " 2- Dólares a Euro." & vbCrLf &
                                      " 3- Dólares a Yen." & vbCrLf &
                                      " 4- Yen a Dólares." & vbCrLf &
                                      " 5- Dólares a Pesetas" & vbCrLf &
                                      " 6- Peseta a Dólares" & vbCrLf &
                                      " 7- Dólares a libras" & vbCrLf &
                                      " 8- Libras a dólares" & vbCrLf &
                                      " 9- Conversion de todas las materias" & vbCrLf &
                                       "10- volver al menu" & vbCrLf &
                                      "--------------------------------------------" & vbCrLf)

    End Sub
    Public Sub Tempohora()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(vbCrLf &
                  "-------------------------------------------" & vbCrLf &
                  " Error:Solo se admiten valores de 0 a 23" & vbCrLf &
                  "-------------------------------------------")
        Console.ReadKey()
        Console.ResetColor()
        Console.Clear()
    End Sub
    Public Sub Tempominseg()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(vbCrLf &
                  "-------------------------------------------" & vbCrLf &
                  " Error:Solo se admiten valores de 0 a 59" & vbCrLf &
                  "-------------------------------------------")
        Console.ReadKey()
        Console.ResetColor()
        Console.Clear()
    End Sub
    Public Sub Errorformtahoramili()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("---------------------------------------------------------------------------" & vbCrLf &
                      "      Error: Formato de hora incorrecto. Inténtalo de nuevo." & vbCrLf &
                      "---------------------------------------------------------------------------")
        Console.ResetColor()
        Console.ReadKey()
        Console.Clear()
    End Sub
    Public Sub Errorformtahoramili2()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("------------------------------------------------------------------------------" & vbCrLf &
                          "      Error:el rango de horas es de 0 a 24, de minutos y segundos de 0 a 59." & vbCrLf &
                          "------------------------------------------------------------------------------")
        Console.ResetColor()
        Console.ReadKey()
        Console.Clear()
    End Sub
    Public Sub Menuerror2()
        Console.Write("---------------Universidad Tecnológica de Panamá--------------------" & vbCrLf & vbCrLf &
          "                             Menu" & vbCrLf & vbCrLf &
          " 1- Problema #1 - Realizar calculos de elementos." & vbCrLf &
          " 2- Problema #2 - Conversión de moneda." & vbCrLf &
          " 3- Problema #3 - Hora." & vbCrLf &
          " 4- Finalizar" & vbCrLf & vbCrLf &
          "--------------------------------------------------------------------" & vbCrLf)
    End Sub
    Public Sub Menutimep3()
        Console.Clear()
        Console.WriteLine("                     Tipo de formato" & vbCrLf & vbCrLf &
"  1- Ingresar formato militar." & vbCrLf &
"  2- Ingresar hora,min.,seg." & vbCrLf &
"  3- Volver al menu principal." & vbCrLf &
"---------------------------------------------------------------------------" & vbCrLf)
    End Sub
    Public Sub Errorfmt2()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine(vbCrLf &
                                          "------------------------------------" & vbCrLf &
                                          "  Error:formato no valido." & vbCrLf &
                                          "-----------------------------------")
        Console.ResetColor()
        Console.ReadKey()
    End Sub
End Class
