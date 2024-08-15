Public Class Form2
    Private Sub Выполнения_работыBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Выполнения_работыBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Выполнения_работыBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DipIPDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
        Me.СотрудникиTableAdapter.Fill(Me.DipIPDataSet.Сотрудники)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Материалы". При необходимости она может быть перемещена или удалена.
        Me.МатериалыTableAdapter.Fill(Me.DipIPDataSet.Материалы)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Виды_работ". При необходимости она может быть перемещена или удалена.
        Me.Виды_работTableAdapter.Fill(Me.DipIPDataSet.Виды_работ)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Выполнения_работы". При необходимости она может быть перемещена или удалена.
        Me.Выполнения_работыTableAdapter.FillBySort(Me.DipIPDataSet.Выполнения_работы)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.Выполнения_работыBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DipIPDataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Выполнения_работыTableAdapter.Fill(Me.DipIPDataSet.Выполнения_работы)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Выполнения_работыTableAdapter.FillBySort(Me.DipIPDataSet.Выполнения_работы)
    End Sub
End Class