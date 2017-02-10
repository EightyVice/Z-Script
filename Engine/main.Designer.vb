<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.log_txt = New System.Windows.Forms.TextBox()
        Me.command_txt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'log_txt
        '
        Me.log_txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.log_txt.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.log_txt.Location = New System.Drawing.Point(0, 0)
        Me.log_txt.Multiline = True
        Me.log_txt.Name = "log_txt"
        Me.log_txt.Size = New System.Drawing.Size(464, 272)
        Me.log_txt.TabIndex = 0
        Me.log_txt.Text = "[Scrpt] Script Loaded Successfully"
        '
        'command_txt
        '
        Me.command_txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.command_txt.Location = New System.Drawing.Point(0, 0)
        Me.command_txt.Name = "command_txt"
        Me.command_txt.Size = New System.Drawing.Size(464, 20)
        Me.command_txt.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.command_txt)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 249)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 23)
        Me.Panel1.TabIndex = 2
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 272)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.log_txt)
        Me.Name = "main"
        Me.ShowInTaskbar = False
        Me.Text = "Z-Script Engine Log"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents log_txt As System.Windows.Forms.TextBox
    Friend WithEvents command_txt As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
