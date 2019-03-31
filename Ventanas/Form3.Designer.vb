<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Marcas
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.ComboBoxModificar = New System.Windows.Forms.ComboBox()
        Me.ComboBoxEliminar = New System.Windows.Forms.ComboBox()
        Me.btnIngresarMarca = New System.Windows.Forms.Button()
        Me.textMarca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(258, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 24)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Marcas"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(527, 162)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(103, 21)
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(527, 93)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(103, 21)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'ComboBoxModificar
        '
        Me.ComboBoxModificar.FormattingEnabled = True
        Me.ComboBoxModificar.Location = New System.Drawing.Point(360, 162)
        Me.ComboBoxModificar.Name = "ComboBoxModificar"
        Me.ComboBoxModificar.Size = New System.Drawing.Size(140, 21)
        Me.ComboBoxModificar.TabIndex = 14
        '
        'ComboBoxEliminar
        '
        Me.ComboBoxEliminar.FormattingEnabled = True
        Me.ComboBoxEliminar.Location = New System.Drawing.Point(360, 94)
        Me.ComboBoxEliminar.Name = "ComboBoxEliminar"
        Me.ComboBoxEliminar.Size = New System.Drawing.Size(140, 21)
        Me.ComboBoxEliminar.TabIndex = 13
        '
        'btnIngresarMarca
        '
        Me.btnIngresarMarca.Location = New System.Drawing.Point(177, 187)
        Me.btnIngresarMarca.Name = "btnIngresarMarca"
        Me.btnIngresarMarca.Size = New System.Drawing.Size(132, 30)
        Me.btnIngresarMarca.TabIndex = 12
        Me.btnIngresarMarca.Text = "Ingresar Marca"
        Me.btnIngresarMarca.UseVisualStyleBackColor = True
        '
        'textMarca
        '
        Me.textMarca.Location = New System.Drawing.Point(177, 134)
        Me.textMarca.Name = "textMarca"
        Me.textMarca.Size = New System.Drawing.Size(132, 20)
        Me.textMarca.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nombre de Marca"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.SalirToolStripMenuItem, Me.LimpiarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(678, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'Marcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 300)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.ComboBoxModificar)
        Me.Controls.Add(Me.ComboBoxEliminar)
        Me.Controls.Add(Me.btnIngresarMarca)
        Me.Controls.Add(Me.textMarca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Marcas"
        Me.Text = "Administrar Marcas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents ComboBoxModificar As ComboBox
    Friend WithEvents ComboBoxEliminar As ComboBox
    Friend WithEvents btnIngresarMarca As Button
    Friend WithEvents textMarca As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
End Class
