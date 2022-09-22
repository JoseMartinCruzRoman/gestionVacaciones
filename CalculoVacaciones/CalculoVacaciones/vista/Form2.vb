Public Class Form2
    Dim db As New DB_VACACIONESEntities6

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB_VACACIONESDataSet.lista_empleado' Puede moverla o quitarla según sea necesario.
        Me.Lista_empleadoTableAdapter.Fill(Me.DB_VACACIONESDataSet.lista_empleado)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DataGridView1.DataSource = db.buscar_empleado(Me.TextBox1.Text).ToList()
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Me.DataGridView1.DataSource = db.buscar_empleado(Me.TextBox1.Text).ToList()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FRM As FRMNUEVOEMPLEADO : FRM = New FRMNUEVOEMPLEADO() : FRM.ShowDialog()
        FRM.codigoemp = 0
        TextBox1.Text = ""
        Me.Lista_empleadoTableAdapter.Fill(Me.DB_VACACIONESDataSet.lista_empleado)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id As String = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value()
        db.eliminar_empleado(id)
        Me.Lista_empleadoTableAdapter.Fill(Me.DB_VACACIONESDataSet.lista_empleado)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim FRM As FRMNUEVOEMPLEADO
        Dim fecha As Date

        FRM = New FRMNUEVOEMPLEADO()
        FRM.codigoemp = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value()
        FRM.txtnombres.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value()
        FRM.txtapellidos.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value()
        FRM.dtfecha.Text = CDate(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value())
        FRM.cbxidentificacion.SelectedValue = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value()
        FRM.txtnumeroi.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(6).Value()
        FRM.txtsalariobase.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(8).Value()
        FRM.txtdireccion.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value()
        FRM.Button1.Text = "ACTUALIZAR"
        FRM.ShowDialog()

        Me.Lista_empleadoTableAdapter.Fill(Me.DB_VACACIONESDataSet.lista_empleado)


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim FRM As FRMVACACIONESEMP
        FRM = New FRMVACACIONESEMP()
        FRM.codigoemp = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value()

        FRM.ShowDialog()
    End Sub
End Class