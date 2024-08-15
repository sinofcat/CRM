Public Class Form10
    Private Sub МатериалыBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles МатериалыBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.МатериалыBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DipIPDataSet)

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Ед_измерения". При необходимости она может быть перемещена или удалена.
        Me.Ед_измеренияTableAdapter.Fill(Me.DipIPDataSet.Ед_измерения)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Материалы". При необходимости она может быть перемещена или удалена.
        Me.МатериалыTableAdapter.Fill(Me.DipIPDataSet.Материалы)

    End Sub
End Class