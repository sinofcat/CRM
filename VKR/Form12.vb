Public Class Form12
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.chek". При необходимости она может быть перемещена или удалена.
        Me.chekTableAdapter.Fill(Me.DipIPDataSet.chek)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class