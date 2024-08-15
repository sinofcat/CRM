Public Class Form8
    Private Sub Виды_работBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Виды_работBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Виды_работBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DipIPDataSet)

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Виды_работ". При необходимости она может быть перемещена или удалена.
        Me.Виды_работTableAdapter.Fill(Me.DipIPDataSet.Виды_работ)

    End Sub
End Class