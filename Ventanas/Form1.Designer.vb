<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.HomwToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConectarBDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdminProductos = New System.Windows.Forms.Button()
        Me.btnGestionVenta = New System.Windows.Forms.Button()
        Me.btnReporteProducto = New System.Windows.Forms.Button()
        Me.btnAdminCliente = New System.Windows.Forms.Button()
        Me.btnAdminMarca = New System.Windows.Forms.Button()
        Me.btnAdminCategoria = New System.Windows.Forms.Button()
        Me.btnReporteCliente = New System.Windows.Forms.Button()
        Me.btnReporteMarca = New System.Windows.Forms.Button()
        Me.btnReporteCategoria = New System.Windows.Forms.Button()
        Me.btnReporteVenta = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomwToolStripMenuItem, Me.SalirToolStripMenuItem, Me.ConectarBDToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(750, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomwToolStripMenuItem
        '
        Me.HomwToolStripMenuItem.Name = "HomwToolStripMenuItem"
        Me.HomwToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomwToolStripMenuItem.Text = "Home"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ConectarBDToolStripMenuItem
        '
        Me.ConectarBDToolStripMenuItem.Name = "ConectarBDToolStripMenuItem"
        Me.ConectarBDToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ConectarBDToolStripMenuItem.Text = "Conectar BD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Area de Administracion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(295, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Gestion de Ventas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(536, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Area de Reportes"
        '
        'btnAdminProductos
        '
        Me.btnAdminProductos.Location = New System.Drawing.Point(44, 108)
        Me.btnAdminProductos.Name = "btnAdminProductos"
        Me.btnAdminProductos.Size = New System.Drawing.Size(155, 26)
        Me.btnAdminProductos.TabIndex = 4
        Me.btnAdminProductos.Text = "Administrar Productos"
        Me.btnAdminProductos.UseVisualStyleBackColor = True
        '
        'btnGestionVenta
        '
        Me.btnGestionVenta.Location = New System.Drawing.Point(299, 164)
        Me.btnGestionVenta.Name = "btnGestionVenta"
        Me.btnGestionVenta.Size = New System.Drawing.Size(155, 26)
        Me.btnGestionVenta.TabIndex = 5
        Me.btnGestionVenta.Text = "Gestionar Venta"
        Me.btnGestionVenta.UseVisualStyleBackColor = True
        '
        'btnReporteProducto
        '
        Me.btnReporteProducto.Location = New System.Drawing.Point(539, 108)
        Me.btnReporteProducto.Name = "btnReporteProducto"
        Me.btnReporteProducto.Size = New System.Drawing.Size(155, 26)
        Me.btnReporteProducto.TabIndex = 6
        Me.btnReporteProducto.Text = "ver Productos"
        Me.btnReporteProducto.UseVisualStyleBackColor = True
        '
        'btnAdminCliente
        '
        Me.btnAdminCliente.Location = New System.Drawing.Point(44, 294)
        Me.btnAdminCliente.Name = "btnAdminCliente"
        Me.btnAdminCliente.Size = New System.Drawing.Size(155, 26)
        Me.btnAdminCliente.TabIndex = 7
        Me.btnAdminCliente.Text = "Administrar Clientes"
        Me.btnAdminCliente.UseVisualStyleBackColor = True
        '
        'btnAdminMarca
        '
        Me.btnAdminMarca.Location = New System.Drawing.Point(44, 230)
        Me.btnAdminMarca.Name = "btnAdminMarca"
        Me.btnAdminMarca.Size = New System.Drawing.Size(155, 26)
        Me.btnAdminMarca.TabIndex = 8
        Me.btnAdminMarca.Text = "Administrar Marcas"
        Me.btnAdminMarca.UseVisualStyleBackColor = True
        '
        'btnAdminCategoria
        '
        Me.btnAdminCategoria.Location = New System.Drawing.Point(44, 164)
        Me.btnAdminCategoria.Name = "btnAdminCategoria"
        Me.btnAdminCategoria.Size = New System.Drawing.Size(155, 26)
        Me.btnAdminCategoria.TabIndex = 9
        Me.btnAdminCategoria.Text = "Administrar Categoria"
        Me.btnAdminCategoria.UseVisualStyleBackColor = True
        '
        'btnReporteCliente
        '
        Me.btnReporteCliente.Location = New System.Drawing.Point(539, 294)
        Me.btnReporteCliente.Name = "btnReporteCliente"
        Me.btnReporteCliente.Size = New System.Drawing.Size(155, 26)
        Me.btnReporteCliente.TabIndex = 10
        Me.btnReporteCliente.Text = "ver Clientes"
        Me.btnReporteCliente.UseVisualStyleBackColor = True
        '
        'btnReporteMarca
        '
        Me.btnReporteMarca.Location = New System.Drawing.Point(540, 230)
        Me.btnReporteMarca.Name = "btnReporteMarca"
        Me.btnReporteMarca.Size = New System.Drawing.Size(155, 26)
        Me.btnReporteMarca.TabIndex = 11
        Me.btnReporteMarca.Text = "ver Marcas"
        Me.btnReporteMarca.UseVisualStyleBackColor = True
        '
        'btnReporteCategoria
        '
        Me.btnReporteCategoria.Location = New System.Drawing.Point(539, 164)
        Me.btnReporteCategoria.Name = "btnReporteCategoria"
        Me.btnReporteCategoria.Size = New System.Drawing.Size(155, 26)
        Me.btnReporteCategoria.TabIndex = 12
        Me.btnReporteCategoria.Text = "ver Categorias"
        Me.btnReporteCategoria.UseVisualStyleBackColor = True
        '
        'btnReporteVenta
        '
        Me.btnReporteVenta.Location = New System.Drawing.Point(540, 346)
        Me.btnReporteVenta.Name = "btnReporteVenta"
        Me.btnReporteVenta.Size = New System.Drawing.Size(155, 26)
        Me.btnReporteVenta.TabIndex = 13
        Me.btnReporteVenta.Text = "ver Ventas"
        Me.btnReporteVenta.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 487)
        Me.Controls.Add(Me.btnReporteVenta)
        Me.Controls.Add(Me.btnReporteCategoria)
        Me.Controls.Add(Me.btnReporteMarca)
        Me.Controls.Add(Me.btnReporteCliente)
        Me.Controls.Add(Me.btnAdminCategoria)
        Me.Controls.Add(Me.btnAdminMarca)
        Me.Controls.Add(Me.btnAdminCliente)
        Me.Controls.Add(Me.btnReporteProducto)
        Me.Controls.Add(Me.btnGestionVenta)
        Me.Controls.Add(Me.btnAdminProductos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Alibaba Group"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomwToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdminProductos As Button
    Friend WithEvents btnGestionVenta As Button
    Friend WithEvents btnReporteProducto As Button
    Friend WithEvents btnAdminCliente As Button
    Friend WithEvents btnAdminMarca As Button
    Friend WithEvents btnAdminCategoria As Button
    Friend WithEvents btnReporteCliente As Button
    Friend WithEvents btnReporteMarca As Button
    Friend WithEvents btnReporteCategoria As Button
    Friend WithEvents btnReporteVenta As Button
    Friend WithEvents ConectarBDToolStripMenuItem As ToolStripMenuItem
End Class
