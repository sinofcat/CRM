Public Class Form11
    Private Sub Ед_измеренияBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Ед_измеренияBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Ед_измеренияBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DipIPDataSet)

    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Ед_измерения". При необходимости она может быть перемещена или удалена.
        Me.Ед_измеренияTableAdapter.Fill(Me.DipIPDataSet.Ед_измерения)

    End Sub
End Class