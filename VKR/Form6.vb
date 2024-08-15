Public Class Form6
    Private Sub КлиентыBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles КлиентыBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.КлиентыBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DipIPDataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
        Me.КлиентыTableAdapter.Fill(Me.DipIPDataSet.Клиенты)

    End Sub
End Class