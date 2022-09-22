<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMNUEVOEMPLEADO
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
        Me.txtnombres = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnumeroi = New System.Windows.Forms.TextBox()
        Me.cbxidentificacion = New System.Windows.Forms.ComboBox()
        Me.TbtipoidentificacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_VACACIONESDataSet1 = New CalculoVacaciones.DB_VACACIONESDataSet1()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtsalariobase = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DB_VACACIONESDataSet = New CalculoVacaciones.DB_VACACIONESDataSet()
        Me.DBVACACIONESDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_tipo_identificacionTableAdapter = New CalculoVacaciones.DB_VACACIONESDataSet1TableAdapters.tb_tipo_identificacionTableAdapter()
        CType(Me.TbtipoidentificacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_VACACIONESDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_VACACIONESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBVACACIONESDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnombres
        '
        Me.txtnombres.Location = New System.Drawing.Point(193, 51)
        Me.txtnombres.Multiline = True
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.Size = New System.Drawing.Size(213, 36)
        Me.txtnombres.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOMBRES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "APELLIDOS"
        '
        'txtapellidos
        '
        Me.txtapellidos.Location = New System.Drawing.Point(193, 109)
        Me.txtapellidos.Multiline = True
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(213, 36)
        Me.txtapellidos.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TIPO IDENTIFICACION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "NUMERO IDENTIFICACION"
        '
        'txtnumeroi
        '
        Me.txtnumeroi.Location = New System.Drawing.Point(193, 229)
        Me.txtnumeroi.Multiline = True
        Me.txtnumeroi.Name = "txtnumeroi"
        Me.txtnumeroi.Size = New System.Drawing.Size(213, 36)
        Me.txtnumeroi.TabIndex = 6
        '
        'cbxidentificacion
        '
        Me.cbxidentificacion.DataSource = Me.TbtipoidentificacionBindingSource
        Me.cbxidentificacion.DisplayMember = "tipo_identificacion"
        Me.cbxidentificacion.FormattingEnabled = True
        Me.cbxidentificacion.Location = New System.Drawing.Point(193, 175)
        Me.cbxidentificacion.Name = "cbxidentificacion"
        Me.cbxidentificacion.Size = New System.Drawing.Size(213, 21)
        Me.cbxidentificacion.TabIndex = 8
        Me.cbxidentificacion.ValueMember = "id_identificacion"
        '
        'TbtipoidentificacionBindingSource
        '
        Me.TbtipoidentificacionBindingSource.DataMember = "tb_tipo_identificacion"
        Me.TbtipoidentificacionBindingSource.DataSource = Me.DB_VACACIONESDataSet1
        '
        'DB_VACACIONESDataSet1
        '
        Me.DB_VACACIONESDataSet1.DataSetName = "DB_VACACIONESDataSet1"
        Me.DB_VACACIONESDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtfecha
        '
        Me.dtfecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtfecha.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtfecha.CustomFormat = """dd, yyyy - dddd"""
        Me.dtfecha.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(193, 293)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(213, 27)
        Me.dtfecha.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "FECHA INGRESO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 415)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "DIRECCION"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(193, 402)
        Me.txtdireccion.Multiline = True
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(213, 36)
        Me.txtdireccion.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 357)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "SALARIO BASE"
        '
        'txtsalariobase
        '
        Me.txtsalariobase.Location = New System.Drawing.Point(193, 344)
        Me.txtsalariobase.Multiline = True
        Me.txtsalariobase.Name = "txtsalariobase"
        Me.txtsalariobase.Size = New System.Drawing.Size(213, 36)
        Me.txtsalariobase.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(39, 496)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 42)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "GUARDAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(226, 496)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(180, 42)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "CANCELAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DB_VACACIONESDataSet
        '
        Me.DB_VACACIONESDataSet.DataSetName = "DB_VACACIONESDataSet"
        Me.DB_VACACIONESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DBVACACIONESDataSetBindingSource
        '
        Me.DBVACACIONESDataSetBindingSource.DataSource = Me.DB_VACACIONESDataSet
        Me.DBVACACIONESDataSetBindingSource.Position = 0
        '
        'Tb_tipo_identificacionTableAdapter
        '
        Me.Tb_tipo_identificacionTableAdapter.ClearBeforeFill = True
        '
        'FRMNUEVOEMPLEADO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 581)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtsalariobase)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtfecha)
        Me.Controls.Add(Me.cbxidentificacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnumeroi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtapellidos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombres)
        Me.Name = "FRMNUEVOEMPLEADO"
        Me.Text = "CREAR EMPLEADO"
        CType(Me.TbtipoidentificacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_VACACIONESDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_VACACIONESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBVACACIONESDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnombres As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtapellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnumeroi As System.Windows.Forms.TextBox
    Friend WithEvents cbxidentificacion As System.Windows.Forms.ComboBox
    Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtsalariobase As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DB_VACACIONESDataSet As CalculoVacaciones.DB_VACACIONESDataSet
    Friend WithEvents DBVACACIONESDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DB_VACACIONESDataSet1 As CalculoVacaciones.DB_VACACIONESDataSet1
    Friend WithEvents TbtipoidentificacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_tipo_identificacionTableAdapter As CalculoVacaciones.DB_VACACIONESDataSet1TableAdapters.tb_tipo_identificacionTableAdapter
End Class
