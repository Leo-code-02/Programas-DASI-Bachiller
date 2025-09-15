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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrmasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SumaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiplicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DivisionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.ProgrmasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(511, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'ProgrmasToolStripMenuItem
        '
        Me.ProgrmasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SumaToolStripMenuItem, Me.RestaToolStripMenuItem, Me.MultiplicacionToolStripMenuItem, Me.DivisionToolStripMenuItem})
        Me.ProgrmasToolStripMenuItem.Name = "ProgrmasToolStripMenuItem"
        Me.ProgrmasToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.ProgrmasToolStripMenuItem.Text = "Programas"
        '
        'SumaToolStripMenuItem
        '
        Me.SumaToolStripMenuItem.Name = "SumaToolStripMenuItem"
        Me.SumaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SumaToolStripMenuItem.Text = "Suma"
        '
        'RestaToolStripMenuItem
        '
        Me.RestaToolStripMenuItem.Name = "RestaToolStripMenuItem"
        Me.RestaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RestaToolStripMenuItem.Text = "Resta"
        '
        'MultiplicacionToolStripMenuItem
        '
        Me.MultiplicacionToolStripMenuItem.Name = "MultiplicacionToolStripMenuItem"
        Me.MultiplicacionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MultiplicacionToolStripMenuItem.Text = "Multiplicacion"
        '
        'DivisionToolStripMenuItem
        '
        Me.DivisionToolStripMenuItem.Name = "DivisionToolStripMenuItem"
        Me.DivisionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DivisionToolStripMenuItem.Text = "Division"
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(508, 400)
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(2, 27)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(508, 400)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 450)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgrmasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SumaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultiplicacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DivisionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
End Class
