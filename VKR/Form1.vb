Public Class Form1
    Private Sub ЗаявкаBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ЗаявкаBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ЗаявкаBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DipIPDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
        Me.КлиентыTableAdapter.Fill(Me.DipIPDataSet.Клиенты)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Виды_работ". При необходимости она может быть перемещена или удалена.
        Me.Виды_работTableAdapter.Fill(Me.DipIPDataSet.Виды_работ)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Заявка". При необходимости она может быть перемещена или удалена.
        Me.ЗаявкаTableAdapter.Fill(Me.DipIPDataSet.Заявка)
        BindingNavigatorAddNewItem.PerformClick()
        Дата_заключенияDateTimePicker.Value = Now

    End Sub
End Class
