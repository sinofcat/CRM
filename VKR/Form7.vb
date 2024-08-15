Public Class Form7
    Private Sub СотрудникиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles СотрудникиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.СотрудникиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DipIPDataSet)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Должности". При необходимости она может быть перемещена или удалена.
        Me.ДолжностиTableAdapter.Fill(Me.DipIPDataSet.Должности)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
        Me.СотрудникиTableAdapter.Fill(Me.DipIPDataSet.Сотрудники)

    End Sub
End Class