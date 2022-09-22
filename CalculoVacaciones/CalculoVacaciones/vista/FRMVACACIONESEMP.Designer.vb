<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMVACACIONESEMP
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
        Me.dtfechainicio = New System.Windows.Forms.DateTimePicker()
        Me.dtfechafin = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FECHA INICIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(263, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FECHA FIN"
        '
        'dtfechainicio
        '
        Me.dtfechainicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtfechainicio.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtfechainicio.CustomFormat = """dd, yyyy - dddd"""
        Me.dtfechainicio.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.dtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechainicio.Location = New System.Drawing.Point(102, 44)
        Me.dtfechainicio.Name = "dtfechainicio"
        Me.dtfechainicio.Size = New System.Drawing.Size(147, 27)
        Me.dtfechainicio.TabIndex = 29
        '
        'dtfechafin
        '
        Me.dtfechafin.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtfechafin.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtfechafin.CustomFormat = """dd, yyyy - dddd"""
        Me.dtfechafin.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.dtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechafin.Location = New System.Drawing.Point(339, 45)
        Me.dtfechafin.Name = "dtfechafin"
        Me.dtfechafin.Size = New System.Drawing.Size(139, 27)
        Me.dtfechafin.TabIndex = 30
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 214)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(456, 150)
        Me.DataGridView1.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(22, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 38)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "VER VACACIONES DISPONIBLES"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "DIAS TOMADOS"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(112, 110)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(103, 29)
        Me.TextBox1.TabIndex = 34
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(330, 384)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 38)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "IMPRIMIR REPORTE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FRMVACACIONESEMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 446)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dtfechafin)
        Me.Controls.Add(Me.dtfechainicio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRMVACACIONESEMP"
        Me.Text = "VACACIONES X EMPLEADO"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtfechainicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtfechafin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
