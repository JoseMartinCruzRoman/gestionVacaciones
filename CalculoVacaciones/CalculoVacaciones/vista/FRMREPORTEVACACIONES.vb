Public Class FRMREPORTEVACACIONES

    Public fechainicio As Date
    Public fechafin As Date
    Public codemp As Integer
    Public diastomados As Integer





    Private Sub FRMREPORTEVACACIONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB_VACACIONESDataSet2.visualizar_vacaciones' Puede moverla o quitarla según sea necesario.
        Me.visualizar_vacacionesTableAdapter.Fill(Me.DB_VACACIONESDataSet2.visualizar_vacaciones, CDate(fechainicio).ToString(), CDate(fechafin).ToString(), codemp, diastomados)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class