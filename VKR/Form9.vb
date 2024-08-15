Public Class Form9
    Private Sub ДолжностиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ДолжностиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ДолжностиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DipIPDataSet)

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Должности". При необходимости она может быть перемещена или удалена.
        Me.ДолжностиTableAdapter.Fill(Me.DipIPDataSet.Должности)

    End Sub
End Class