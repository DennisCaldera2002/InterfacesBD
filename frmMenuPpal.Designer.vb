<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPpal
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
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeRolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeOpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsignarOpcionesARolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.OtrosToolStripMenuItem, Me.OtrosToolStripMenuItem1, Me.OtrosToolStripMenuItem2, Me.SeguridadToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuSalir})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'menuSalir
        '
        Me.menuSalir.Name = "menuSalir"
        Me.menuSalir.Size = New System.Drawing.Size(96, 22)
        Me.menuSalir.Text = "Salir"
        '
        'OtrosToolStripMenuItem
        '
        Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
        Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.OtrosToolStripMenuItem.Text = "Otros."
        '
        'OtrosToolStripMenuItem1
        '
        Me.OtrosToolStripMenuItem1.Name = "OtrosToolStripMenuItem1"
        Me.OtrosToolStripMenuItem1.Size = New System.Drawing.Size(54, 20)
        Me.OtrosToolStripMenuItem1.Text = "Otros.."
        '
        'OtrosToolStripMenuItem2
        '
        Me.OtrosToolStripMenuItem2.Name = "OtrosToolStripMenuItem2"
        Me.OtrosToolStripMenuItem2.Size = New System.Drawing.Size(57, 20)
        Me.OtrosToolStripMenuItem2.Text = "Otros..."
        '
        'SeguridadToolStripMenuItem
        '
        Me.SeguridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuUsuarios, Me.GestiónDeRolesToolStripMenuItem, Me.GestiónDeOpcionesToolStripMenuItem})
        Me.SeguridadToolStripMenuItem.Name = "SeguridadToolStripMenuItem"
        Me.SeguridadToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SeguridadToolStripMenuItem.Text = "Seguridad"
        '
        'menuUsuarios
        '
        Me.menuUsuarios.Name = "menuUsuarios"
        Me.menuUsuarios.Size = New System.Drawing.Size(183, 22)
        Me.menuUsuarios.Text = "Gestión de Usuarios"
        '
        'GestiónDeRolesToolStripMenuItem
        '
        Me.GestiónDeRolesToolStripMenuItem.Name = "GestiónDeRolesToolStripMenuItem"
        Me.GestiónDeRolesToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.GestiónDeRolesToolStripMenuItem.Text = "Gestión de Roles"
        '
        'GestiónDeOpcionesToolStripMenuItem
        '
        Me.GestiónDeOpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.AsignarOpcionesARolToolStripMenuItem})
        Me.GestiónDeOpcionesToolStripMenuItem.Name = "GestiónDeOpcionesToolStripMenuItem"
        Me.GestiónDeOpcionesToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.GestiónDeOpcionesToolStripMenuItem.Text = "Gestión de Opciones"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'AsignarOpcionesARolToolStripMenuItem
        '
        Me.AsignarOpcionesARolToolStripMenuItem.Name = "AsignarOpcionesARolToolStripMenuItem"
        Me.AsignarOpcionesARolToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.AsignarOpcionesARolToolStripMenuItem.Text = "Rol Opciones"
        '
        'frmMenuPpal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMenuPpal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuSalir As ToolStripMenuItem
    Friend WithEvents OtrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OtrosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OtrosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuUsuarios As ToolStripMenuItem
    Friend WithEvents GestiónDeRolesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónDeOpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsignarOpcionesARolToolStripMenuItem As ToolStripMenuItem
End Class
