<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnSecion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMoMa = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(116, 240)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(197, 13)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(116, 284)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(197, 20)
        Me.TextBox2.TabIndex = 1
        '
        'btnSecion
        '
        Me.btnSecion.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSecion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSecion.FlatAppearance.BorderSize = 2
        Me.btnSecion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSecion.Font = New System.Drawing.Font("Goudy Stout", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecion.ForeColor = System.Drawing.Color.White
        Me.btnSecion.Location = New System.Drawing.Point(116, 328)
        Me.btnSecion.Name = "btnSecion"
        Me.btnSecion.Size = New System.Drawing.Size(197, 67)
        Me.btnSecion.TabIndex = 2
        Me.btnSecion.Text = "Iniciar Secion "
        Me.btnSecion.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Goudy Stout", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Goudy Stout", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 425)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nuevo Usuario"
        '
        'btnMoMa
        '
        Me.btnMoMa.BackColor = System.Drawing.Color.Transparent
        Me.btnMoMa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMoMa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoMa.Font = New System.Drawing.Font("Goudy Stout", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoMa.ForeColor = System.Drawing.Color.Black
        Me.btnMoMa.Location = New System.Drawing.Point(67, 21)
        Me.btnMoMa.Name = "btnMoMa"
        Me.btnMoMa.Size = New System.Drawing.Size(281, 152)
        Me.btnMoMa.TabIndex = 6
        Me.btnMoMa.Text = "Money Manager"
        Me.btnMoMa.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.GraaficaProyo2.My.Resources.Resources.fondo1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(424, 488)
        Me.Controls.Add(Me.btnMoMa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSecion)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "MoneyManager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnSecion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMoMa As Button
End Class
