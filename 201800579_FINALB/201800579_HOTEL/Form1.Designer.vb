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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TScalculo = New System.Windows.Forms.ToolStripLabel()
        Me.TSmostrar = New System.Windows.Forms.ToolStripLabel()
        Me.TSconsultar = New System.Windows.Forms.ToolStripLabel()
        Me.TSlimpiar = New System.Windows.Forms.ToolStripLabel()
        Me.GPconsulta = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTresultados = New System.Windows.Forms.DataGridView()
        Me.GPHabitacion = New System.Windows.Forms.GroupBox()
        Me.CBhabitacion = New System.Windows.Forms.ComboBox()
        Me.GPClientes = New System.Windows.Forms.GroupBox()
        Me.TBcantidad = New System.Windows.Forms.TextBox()
        Me.TBnit = New System.Windows.Forms.TextBox()
        Me.TBnombre = New System.Windows.Forms.TextBox()
        Me.LBCantidad = New System.Windows.Forms.Label()
        Me.LBnit = New System.Windows.Forms.Label()
        Me.LBnombre = New System.Windows.Forms.Label()
        Me.DGNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGNIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGHabitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGParcial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGdescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TSvectores = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.GPconsulta.SuspendLayout()
        CType(Me.DTresultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPHabitacion.SuspendLayout()
        Me.GPClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TScalculo, Me.TSmostrar, Me.TSconsultar, Me.TSvectores, Me.TSlimpiar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(880, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TScalculo
        '
        Me.TScalculo.Name = "TScalculo"
        Me.TScalculo.Size = New System.Drawing.Size(49, 22)
        Me.TScalculo.Text = "Agregar"
        '
        'TSmostrar
        '
        Me.TSmostrar.Name = "TSmostrar"
        Me.TSmostrar.Size = New System.Drawing.Size(48, 22)
        Me.TSmostrar.Text = "Mostrar"
        '
        'TSconsultar
        '
        Me.TSconsultar.Name = "TSconsultar"
        Me.TSconsultar.Size = New System.Drawing.Size(58, 22)
        Me.TSconsultar.Text = "Consultar"
        '
        'TSlimpiar
        '
        Me.TSlimpiar.Name = "TSlimpiar"
        Me.TSlimpiar.Size = New System.Drawing.Size(95, 22)
        Me.TSlimpiar.Text = "Limpiar Entradas"
        '
        'GPconsulta
        '
        Me.GPconsulta.Controls.Add(Me.TextBox5)
        Me.GPconsulta.Controls.Add(Me.Label1)
        Me.GPconsulta.Location = New System.Drawing.Point(637, 52)
        Me.GPconsulta.Name = "GPconsulta"
        Me.GPconsulta.Size = New System.Drawing.Size(218, 167)
        Me.GPconsulta.TabIndex = 11
        Me.GPconsulta.TabStop = False
        Me.GPconsulta.Text = "CONSULTA"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(88, 51)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(114, 26)
        Me.TextBox5.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "NIT"
        '
        'DTresultados
        '
        Me.DTresultados.BackgroundColor = System.Drawing.Color.OliveDrab
        Me.DTresultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTresultados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGNombre, Me.DGNIT, Me.DGCantidad, Me.DGHabitacion, Me.DGParcial, Me.DGdescuento, Me.DGTotal})
        Me.DTresultados.Location = New System.Drawing.Point(75, 238)
        Me.DTresultados.Name = "DTresultados"
        Me.DTresultados.Size = New System.Drawing.Size(746, 286)
        Me.DTresultados.TabIndex = 10
        '
        'GPHabitacion
        '
        Me.GPHabitacion.Controls.Add(Me.CBhabitacion)
        Me.GPHabitacion.Location = New System.Drawing.Point(445, 52)
        Me.GPHabitacion.Name = "GPHabitacion"
        Me.GPHabitacion.Size = New System.Drawing.Size(155, 167)
        Me.GPHabitacion.TabIndex = 8
        Me.GPHabitacion.TabStop = False
        Me.GPHabitacion.Text = "TIPO DE HABITACION"
        '
        'CBhabitacion
        '
        Me.CBhabitacion.FormattingEnabled = True
        Me.CBhabitacion.Items.AddRange(New Object() {"Estandar", "A/C", "Jacuzzi"})
        Me.CBhabitacion.Location = New System.Drawing.Point(19, 55)
        Me.CBhabitacion.Name = "CBhabitacion"
        Me.CBhabitacion.Size = New System.Drawing.Size(121, 28)
        Me.CBhabitacion.TabIndex = 0
        '
        'GPClientes
        '
        Me.GPClientes.Controls.Add(Me.TBcantidad)
        Me.GPClientes.Controls.Add(Me.TBnit)
        Me.GPClientes.Controls.Add(Me.TBnombre)
        Me.GPClientes.Controls.Add(Me.LBCantidad)
        Me.GPClientes.Controls.Add(Me.LBnit)
        Me.GPClientes.Controls.Add(Me.LBnombre)
        Me.GPClientes.Location = New System.Drawing.Point(30, 52)
        Me.GPClientes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GPClientes.Name = "GPClientes"
        Me.GPClientes.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GPClientes.Size = New System.Drawing.Size(393, 167)
        Me.GPClientes.TabIndex = 7
        Me.GPClientes.TabStop = False
        Me.GPClientes.Text = "DATOS DEL CLIENTE"
        '
        'TBcantidad
        '
        Me.TBcantidad.Location = New System.Drawing.Point(213, 101)
        Me.TBcantidad.Name = "TBcantidad"
        Me.TBcantidad.Size = New System.Drawing.Size(174, 26)
        Me.TBcantidad.TabIndex = 6
        '
        'TBnit
        '
        Me.TBnit.Location = New System.Drawing.Point(213, 68)
        Me.TBnit.Name = "TBnit"
        Me.TBnit.Size = New System.Drawing.Size(174, 26)
        Me.TBnit.TabIndex = 5
        '
        'TBnombre
        '
        Me.TBnombre.Location = New System.Drawing.Point(213, 36)
        Me.TBnombre.Name = "TBnombre"
        Me.TBnombre.Size = New System.Drawing.Size(174, 26)
        Me.TBnombre.TabIndex = 4
        '
        'LBCantidad
        '
        Me.LBCantidad.AutoSize = True
        Me.LBCantidad.Location = New System.Drawing.Point(6, 104)
        Me.LBCantidad.Name = "LBCantidad"
        Me.LBCantidad.Size = New System.Drawing.Size(201, 20)
        Me.LBCantidad.TabIndex = 2
        Me.LBCantidad.Text = "Personas a Hospedarse"
        '
        'LBnit
        '
        Me.LBnit.AutoSize = True
        Me.LBnit.Location = New System.Drawing.Point(170, 74)
        Me.LBnit.Name = "LBnit"
        Me.LBnit.Size = New System.Drawing.Size(37, 20)
        Me.LBnit.TabIndex = 1
        Me.LBnit.Text = "NIT"
        '
        'LBnombre
        '
        Me.LBnombre.AutoSize = True
        Me.LBnombre.Location = New System.Drawing.Point(30, 39)
        Me.LBnombre.Name = "LBnombre"
        Me.LBnombre.Size = New System.Drawing.Size(177, 20)
        Me.LBnombre.TabIndex = 0
        Me.LBnombre.Text = "Nombre del Huesped"
        '
        'DGNombre
        '
        Me.DGNombre.HeaderText = "Huesped"
        Me.DGNombre.Name = "DGNombre"
        '
        'DGNIT
        '
        Me.DGNIT.HeaderText = "NIT"
        Me.DGNIT.Name = "DGNIT"
        '
        'DGCantidad
        '
        Me.DGCantidad.HeaderText = "Cantidad de Huespedes"
        Me.DGCantidad.Name = "DGCantidad"
        '
        'DGHabitacion
        '
        Me.DGHabitacion.HeaderText = "Tipo de Habitacion"
        Me.DGHabitacion.Name = "DGHabitacion"
        '
        'DGParcial
        '
        Me.DGParcial.HeaderText = "Pago Parcial"
        Me.DGParcial.Name = "DGParcial"
        '
        'DGdescuento
        '
        Me.DGdescuento.HeaderText = "Recargo"
        Me.DGdescuento.Name = "DGdescuento"
        '
        'DGTotal
        '
        Me.DGTotal.HeaderText = "Total"
        Me.DGTotal.Name = "DGTotal"
        '
        'TSvectores
        '
        Me.TSvectores.Name = "TSvectores"
        Me.TSvectores.Size = New System.Drawing.Size(83, 22)
        Me.TSvectores.Text = "Limpiar Matriz"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(880, 536)
        Me.Controls.Add(Me.GPconsulta)
        Me.Controls.Add(Me.DTresultados)
        Me.Controls.Add(Me.GPHabitacion)
        Me.Controls.Add(Me.GPClientes)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GPconsulta.ResumeLayout(False)
        Me.GPconsulta.PerformLayout()
        CType(Me.DTresultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPHabitacion.ResumeLayout(False)
        Me.GPClientes.ResumeLayout(False)
        Me.GPClientes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TScalculo As ToolStripLabel
    Friend WithEvents TSmostrar As ToolStripLabel
    Friend WithEvents TSconsultar As ToolStripLabel
    Friend WithEvents TSlimpiar As ToolStripLabel
    Friend WithEvents GPconsulta As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DTresultados As DataGridView
    Friend WithEvents GPHabitacion As GroupBox
    Friend WithEvents CBhabitacion As ComboBox
    Friend WithEvents GPClientes As GroupBox
    Friend WithEvents TBcantidad As TextBox
    Friend WithEvents TBnit As TextBox
    Friend WithEvents TBnombre As TextBox
    Friend WithEvents LBCantidad As Label
    Friend WithEvents LBnit As Label
    Friend WithEvents LBnombre As Label
    Friend WithEvents DGNombre As DataGridViewTextBoxColumn
    Friend WithEvents DGNIT As DataGridViewTextBoxColumn
    Friend WithEvents DGCantidad As DataGridViewTextBoxColumn
    Friend WithEvents DGHabitacion As DataGridViewTextBoxColumn
    Friend WithEvents DGParcial As DataGridViewTextBoxColumn
    Friend WithEvents DGdescuento As DataGridViewTextBoxColumn
    Friend WithEvents DGTotal As DataGridViewTextBoxColumn
    Friend WithEvents TSvectores As ToolStripLabel
End Class
