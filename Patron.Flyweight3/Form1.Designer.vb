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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lstPelotas = New System.Windows.Forms.ListBox()
        Me.lblObjetos = New System.Windows.Forms.Label()
        Me.lblPelotas = New System.Windows.Forms.Label()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ROJA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Lime
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(149, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 43)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "VERDE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Blue
        Me.Button4.Location = New System.Drawing.Point(286, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 43)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "AZUL"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'lstPelotas
        '
        Me.lstPelotas.FormattingEnabled = True
        Me.lstPelotas.Location = New System.Drawing.Point(12, 100)
        Me.lstPelotas.Name = "lstPelotas"
        Me.lstPelotas.Size = New System.Drawing.Size(405, 134)
        Me.lstPelotas.TabIndex = 3
        '
        'lblObjetos
        '
        Me.lblObjetos.AutoSize = True
        Me.lblObjetos.Location = New System.Drawing.Point(104, 274)
        Me.lblObjetos.Name = "lblObjetos"
        Me.lblObjetos.Size = New System.Drawing.Size(39, 13)
        Me.lblObjetos.TabIndex = 4
        Me.lblObjetos.Text = "Label1"
        '
        'lblPelotas
        '
        Me.lblPelotas.AutoSize = True
        Me.lblPelotas.Location = New System.Drawing.Point(283, 274)
        Me.lblPelotas.Name = "lblPelotas"
        Me.lblPelotas.Size = New System.Drawing.Size(39, 13)
        Me.lblPelotas.TabIndex = 5
        Me.lblPelotas.Text = "Label2"
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(107, 61)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(100, 20)
        Me.txtX.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Coordenada X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(224, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Coordenada Y"
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(305, 61)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(100, 20)
        Me.txtY.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 335)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtY)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.lblPelotas)
        Me.Controls.Add(Me.lblObjetos)
        Me.Controls.Add(Me.lstPelotas)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents lstPelotas As ListBox
    Friend WithEvents lblObjetos As Label
    Friend WithEvents lblPelotas As Label
    Friend WithEvents txtX As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtY As TextBox
End Class
