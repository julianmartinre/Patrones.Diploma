<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lstEspecies = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 58)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cucaracha"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(162, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 58)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Hormiga"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(312, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 58)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Langosta"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lstEspecies
        '
        Me.lstEspecies.FormattingEnabled = True
        Me.lstEspecies.Location = New System.Drawing.Point(12, 76)
        Me.lstEspecies.Name = "lstEspecies"
        Me.lstEspecies.Size = New System.Drawing.Size(444, 238)
        Me.lstEspecies.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 333)
        Me.Controls.Add(Me.lstEspecies)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lstEspecies As ListBox
End Class
