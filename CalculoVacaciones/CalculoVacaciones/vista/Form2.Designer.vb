<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ListaempleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_VACACIONESDataSet = New CalculoVacaciones.DB_VACACIONESDataSet()
        Me.Lista_empleadoTableAdapter = New CalculoVacaciones.DB_VACACIONESDataSetTableAdapters.lista_empleadoTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaingresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_identificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoidentificacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numero_identificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salario_base_mensual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaempleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_VACACIONESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LISTA DE EMLEADOS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombresDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.FechaingresoDataGridViewTextBoxColumn, Me.id_identificacion, Me.TipoidentificacionDataGridViewTextBoxColumn, Me.numero_identificacion, Me.direccion, Me.salario_base_mensual})
        Me.DataGridView1.DataSource = Me.ListaempleadoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(50, 213)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 147)
        Me.DataGridView1.TabIndex = 1
        '
        'ListaempleadoBindingSource
        '
        Me.ListaempleadoBindingSource.DataMember = "lista_empleado"
        Me.ListaempleadoBindingSource.DataSource = Me.DB_VACACIONESDataSet
        '
        'DB_VACACIONESDataSet
        '
        Me.DB_VACACIONESDataSet.DataSetName = "DB_VACACIONESDataSet"
        Me.DB_VACACIONESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lista_empleadoTableAdapter
        '
        Me.Lista_empleadoTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(161, 97)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(321, 27)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "EMPLEADO"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(488, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SeaGreen
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(50, 154)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(174, 43)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "NUEVO EMPLEADO"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Location = New System.Drawing.Point(617, 217)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 42)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "ELIMINAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Orange
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(617, 265)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 40)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "EDITAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NombresDataGridViewTextBoxColumn
        '
        Me.NombresDataGridViewTextBoxColumn.DataPropertyName = "nombres"
        Me.NombresDataGridViewTextBoxColumn.HeaderText = "nombres"
        Me.NombresDataGridViewTextBoxColumn.Name = "NombresDataGridViewTextBoxColumn"
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        '
        'FechaingresoDataGridViewTextBoxColumn
        '
        Me.FechaingresoDataGridViewTextBoxColumn.DataPropertyName = "fecha_ingreso"
        Me.FechaingresoDataGridViewTextBoxColumn.HeaderText = "fecha_ingreso"
        Me.FechaingresoDataGridViewTextBoxColumn.Name = "FechaingresoDataGridViewTextBoxColumn"
        '
        'id_identificacion
        '
        Me.id_identificacion.DataPropertyName = "id_identificacion"
        Me.id_identificacion.HeaderText = "id_identificacion"
        Me.id_identificacion.Name = "id_identificacion"
        Me.id_identificacion.Visible = False
        '
        'TipoidentificacionDataGridViewTextBoxColumn
        '
        Me.TipoidentificacionDataGridViewTextBoxColumn.DataPropertyName = "tipo_identificacion"
        Me.TipoidentificacionDataGridViewTextBoxColumn.HeaderText = "tipo_identificacion"
        Me.TipoidentificacionDataGridViewTextBoxColumn.Name = "TipoidentificacionDataGridViewTextBoxColumn"
        '
        'numero_identificacion
        '
        Me.numero_identificacion.DataPropertyName = "numero_identificacion"
        Me.numero_identificacion.HeaderText = "numero_identificacion"
        Me.numero_identificacion.Name = "numero_identificacion"
        Me.numero_identificacion.Visible = False
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "direccion"
        Me.direccion.Name = "direccion"
        Me.direccion.Visible = False
        '
        'salario_base_mensual
        '
        Me.salario_base_mensual.DataPropertyName = "salario_base_mensual"
        Me.salario_base_mensual.HeaderText = "salario_base_mensual"
        Me.salario_base_mensual.Name = "salario_base_mensual"
        Me.salario_base_mensual.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.CadetBlue
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(617, 314)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(108, 40)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "VER VACACIONES"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 389)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "CATALOGO EMPLEADO"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaempleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_VACACIONESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DB_VACACIONESDataSet As CalculoVacaciones.DB_VACACIONESDataSet
    Friend WithEvents ListaempleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Lista_empleadoTableAdapter As CalculoVacaciones.DB_VACACIONESDataSetTableAdapters.lista_empleadoTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaingresoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_identificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoidentificacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero_identificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents salario_base_mensual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
