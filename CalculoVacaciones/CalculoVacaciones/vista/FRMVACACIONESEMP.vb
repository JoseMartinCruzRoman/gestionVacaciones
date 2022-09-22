Public Class FRMVACACIONESEMP
    Public codigoemp As Integer
    Dim db As New DB_VACACIONESEntities6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("Debe poner los dias tomados / o cero dias", MsgBoxStyle.Critical, "Error")
        Else
            Me.DataGridView1.DataSource = db.visualizar_vacaciones(CDate(Me.dtfechainicio.Text), CDate(Me.dtfechafin.Text), codigoemp, Me.TextBox1.Text).ToList()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FRM As FRMREPORTEVACACIONES
        FRM = New FRMREPORTEVACACIONES()

        FRM.fechainicio = CDate(dtfechainicio.Text)
        FRM.fechafin = CDate(dtfechafin.Text)
        FRM.codemp = codigoemp
        FRM.diastomados = TextBox1.Text

        FRM.ShowDialog()


    End Sub
End Class