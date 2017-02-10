Imports System.Windows.Forms
Imports zscriptcompiler.zscriptcompiler.compiler
Public Class main
    Public comp As New zscriptcompiler.zscriptcompiler.compiler
    '---------------Definitions---------------
    Public loadedfile As New RichTextBox
    '-----------------------------------------
    '-=======================Functions===========================

    '--------------------------------------------------------------
    'Commands that the user will enter
    Function Entercommand(ByVal Command As String)
        If Command = "$about" Then
            MessageBox.Show("Z-Script Engine (c) 2017 Zeyad Ahmed")
            log_txt.Text += vbCrLf & "[Command]About window loaded"
        End If
        If Command = "$fileInfo" Then

        End If
        If Command = "$load" Then
            Dim x As New OpenFileDialog
            x.Title = "Load Z-Script File"
            x.Filter = "Z-Script files (*.zsc)|*.zsc"
            If x.ShowDialog = Windows.Forms.DialogResult.OK Then
                loadedfile.LoadFile(x.FileName, RichTextBoxStreamType.PlainText)
                MsgBox(loadedfile.Text)
                log_txt.Text += vbCrLf & "[Script]Script Loaded Sccessfully"
                log_txt.Text += vbCrLf & "[Info]File Name: " & x.FileName
                comp.Compile(loadedfile.Text, x.FileName)
            End If
        End If
        If Command = "$end" Then
            End
        End If
        If Command = "$compilerver" Then
            log_txt.Text += vbCrLf & "[Engine]Compiler Version: " & comp.version
        End If
        If Command = "$Commands" Then
            log_txt.Text += vbCrLf & "[Engine]Commands: $about $fileinfo $load $end $compierver"
        End If
        Return 0
    End Function


    '-----------------------------------------------------------------

    'The code for loading the commands and compare it to the saved commands in the function
    Private Sub command_txt_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles command_txt.KeyDown
        If e.KeyCode = Keys.Enter Then
            Entercommand(command_txt.Text)
        End If
    End Sub
End Class
