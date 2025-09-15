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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Text_Usuario = New System.Windows.Forms.TextBox()
        Me.Text_Contraseña = New System.Windows.Forms.TextBox()
        Me.BTN_ACEPTAR = New System.Windows.Forms.Button()
        Me.BTN_CERRAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(133, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña:"
        '
        'Text_Usuario
        '
        Me.Text_Usuario.Location = New System.Drawing.Point(306, 175)
        Me.Text_Usuario.Multiline = True
        Me.Text_Usuario.Name = "Text_Usuario"
        Me.Text_Usuario.Size = New System.Drawing.Size(148, 30)
        Me.Text_Usuario.TabIndex = 3
        '
        'Text_Contraseña
        '
        Me.Text_Contraseña.Location = New System.Drawing.Point(306, 258)
        Me.Text_Contraseña.Multiline = True
        Me.Text_Contraseña.Name = "Text_Contraseña"
        Me.Text_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Text_Contraseña.Size = New System.Drawing.Size(148, 30)
        Me.Text_Contraseña.TabIndex = 4
        '
        'BTN_ACEPTAR
        '
        Me.BTN_ACEPTAR.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ACEPTAR.Location = New System.Drawing.Point(212, 346)
        Me.BTN_ACEPTAR.Name = "BTN_ACEPTAR"
        Me.BTN_ACEPTAR.Size = New System.Drawing.Size(92, 45)
        Me.BTN_ACEPTAR.TabIndex = 5
        Me.BTN_ACEPTAR.Text = "Aceptar"
        Me.BTN_ACEPTAR.UseVisualStyleBackColor = True
        '
        'BTN_CERRAR
        '
        Me.BTN_CERRAR.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CERRAR.Location = New System.Drawing.Point(350, 346)
        Me.BTN_CERRAR.Name = "BTN_CERRAR"
        Me.BTN_CERRAR.Size = New System.Drawing.Size(90, 45)
        Me.BTN_CERRAR.TabIndex = 6
        Me.BTN_CERRAR.Text = "Cerrar"
        Me.BTN_CERRAR.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(649, 450)
        Me.Controls.Add(Me.BTN_CERRAR)
        Me.Controls.Add(Me.BTN_ACEPTAR)
        Me.Controls.Add(Me.Text_Contraseña)
        Me.Controls.Add(Me.Text_Usuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form1"
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Text_Usuario As TextBox
    Friend WithEvents Text_Contraseña As TextBox
    Friend WithEvents BTN_ACEPTAR As Button
    Friend WithEvents BTN_CERRAR As Button

    Private Sub BTN_ACEPTAR_Click(sender As Object, e As EventArgs) Handles BTN_ACEPTAR.Click
        Dim Usuario As String
        Dim Contraseña As Integer
        Usuario = Text_Usuario.Text
        Contraseña = Text_Contraseña.Text
        If Usuario = ("leandro") And Contraseña = ("9090") Then
            Bienvenida.Show()
        Else
            MsgBox("Resvise su Nombre o Contraseña")

        End If
    End Sub

    Private Sub BTN_CERRAR_Click(sender As Object, e As EventArgs) Handles BTN_CERRAR.Click
        End

    End Sub
End Class
