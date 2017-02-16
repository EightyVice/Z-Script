Imports System.IO
Namespace zscriptcompiler
    'Z-Script Libraries and Compiler and Interpreter
    Public Class compiler
        Dim StrVal As String
        Public Function Compile(ByVal Code As String, ByVal Address As String)
            Dim line As String
            Dim x As StreamReader
            x = File.OpenText(Address)
            Do Until x.EndOfStream
                line = x.ReadLine
                If line.Contains("Title: ") Then
                    Console.Title = line.Substring(7)
                End If
                If line.Contains("Mesg: ") Then
                    MsgBox(line.Substring(5), , "")
                End If
                If line.Contains("Error: ") Then
                    MsgBox(line.Substring(9), MsgBoxStyle.Critical, "")
                End If
                If line.Contains("Write: ") Then
                    Console.Write(line.Substring(7))
                End If
                If line.Contains("StartProcess: ") Then
                    Process.Start(line.Substring(14))
                    MsgBox(line.Substring(14))
                End If
                'Declaring a String Variable will be like ex.  SetStr <Name> { <Value>
                If line.Contains("SetStr ") Then
                    Dim StrVarVal As String
                    Dim Name As String
                    Dim sp() As String = line.Split("{")
                    StrVarVal = sp(1)
                    Name = sp(0).Replace("SetStr ", "")
                    MsgBox(Name & " : " & StrVarVal)
                    Dim StrVar As New Dictionary(Of String, String)()
                    StrVar(Name) = StrVarVal  ' Set the value of the "variable"

                    StrVal = StrVar(Name)  ' Retrieve the value of the variable
                    MsgBox(StrVal)
                End If
                'Getting the value of declared string ex. GetStr <Name> @ <Print Values
                If line.Contains("GetStr ") Then
                    Dim GetVar As String = StrVal
                    Dim gsp() As String = line.Split("@")
                    If gsp(1) = "Title" Then
                        Console.Title = GetVar
                    End If
                    If gsp(1) = "Mesg" Then
                        MsgBox(GetVar)
                    End If
                    If gsp(1) = "Error" Then
                        MsgBox(GetVar, MsgBoxStyle.Critical)
                    End If
                End If
            Loop
            Return 0
        End Function
        Public version As String = "Z-Script Compiler Version 1.0.0"
    End Class
End Namespace
