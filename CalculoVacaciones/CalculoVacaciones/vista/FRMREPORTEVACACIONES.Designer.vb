<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMREPORTEVACACIONES
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DB_VACACIONESDataSet2 = New CalculoVacaciones.DB_VACACIONESDataSet2()
        Me.visualizar_vacacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.visualizar_vacacionesTableAdapter = New CalculoVacaciones.DB_VACACIONESDataSet2TableAdapters.visualizar_vacacionesTableAdapter()
        CType(Me.DB_VACACIONESDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.visualizar_vacacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DB_VACACIONESDataSet2"
        ReportDataSource1.Value = Me.visualizar_vacacionesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CalculoVacaciones.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(939, 299)
        Me.ReportViewer1.TabIndex = 0
        '
        'DB_VACACIONESDataSet2
        '
        Me.DB_VACACIONESDataSet2.DataSetName = "DB_VACACIONESDataSet2"
        Me.DB_VACACIONESDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'visualizar_vacacionesBindingSource
        '
        Me.visualizar_vacacionesBindingSource.DataMember = "visualizar_vacaciones"
        Me.visualizar_vacacionesBindingSource.DataSource = Me.DB_VACACIONESDataSet2
        '
        'visualizar_vacacionesTableAdapter
        '
        Me.visualizar_vacacionesTableAdapter.ClearBeforeFill = True
        '
        'FRMREPORTEVACACIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 299)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FRMREPORTEVACACIONES"
        Me.Text = "FRMREPORTEVACACIONES"
        CType(Me.DB_VACACIONESDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.visualizar_vacacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents visualizar_vacacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DB_VACACIONESDataSet2 As CalculoVacaciones.DB_VACACIONESDataSet2
    Friend WithEvents visualizar_vacacionesTableAdapter As CalculoVacaciones.DB_VACACIONESDataSet2TableAdapters.visualizar_vacacionesTableAdapter
End Class
