Public Class FRMNUEVOEMPLEADO
    Public codigoemp As Integer
    Dim db As New DB_VACACIONESEntities6

    Private Sub FRMNUEVOEMPLEADO_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TODO: esta línea de código carga datos en la tabla 'DB_VACACIONESDataSet1.tb_tipo_identificacion' Puede moverla o quitarla según sea necesario.
        Me.Tb_tipo_identificacionTableAdapter.Fill(Me.DB_VACACIONESDataSet1.tb_tipo_identificacion)
       

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim db As New DB_VACACIONESEntities6

        If codigoemp = 0 Then
            If txtapellidos.Text = "" Or txtnombres.Text = "" Then
                MsgBox("Campos pendientes ", MsgBoxStyle.Critical, "Error")
            Else
                db.crear_empleado(Me.txtnombres.Text, txtapellidos.Text, cbxidentificacion.SelectedValue, txtnumeroi.Text, CDate(dtfecha.Text), Decimal.Parse(txtsalariobase.Text), txtdireccion.Text)
                MsgBox("Se ha guardado exitosamente", MsgBoxStyle.Information, "Acción realizada")
                Me.Close()
            End If
        Else
            db.editar_empleado(codigoemp, Me.txtnombres.Text, txtapellidos.Text, cbxidentificacion.SelectedValue, txtnumeroi.Text, CDate(dtfecha.Text), Decimal.Parse(txtsalariobase.Text), txtdireccion.Text)
            MsgBox("Se ha actualizo exitosamente", MsgBoxStyle.Information, "Acción realizada")
            Me.Close()
        End If



    End Sub
End Class