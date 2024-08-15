Public Class Form4
    Private Sub СтатусЗаявкиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles СтатусЗаявкиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.СтатусЗаявкиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DipIPDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Статус". При необходимости она может быть перемещена или удалена.
        Me.СтатусTableAdapter.Fill(Me.DipIPDataSet.Статус)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Виды_работ". При необходимости она может быть перемещена или удалена.
        Me.Виды_работTableAdapter.Fill(Me.DipIPDataSet.Виды_работ)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
        Me.СотрудникиTableAdapter.Fill(Me.DipIPDataSet.Сотрудники)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
        Me.КлиентыTableAdapter.Fill(Me.DipIPDataSet.Клиенты)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.СтатусЗаявки". При необходимости она может быть перемещена или удалена.
        Me.СтатусЗаявкиTableAdapter.FillBySumma(Me.DipIPDataSet.СтатусЗаявки)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.VipolnenieStatusTableAdapter.Fill(Me.DipIPDataSet.VipolnenieStatus, New System.Nullable(Of Integer)(CType(Param1ToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Param1ToolStripTextBox.Text = ЗаявкаTextBox.Text
        FillToolStripButton.PerformClick()
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Статус". При необходимости она может быть перемещена или удалена.
        Me.СтатусTableAdapter.Fill(Me.DipIPDataSet.Статус)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Виды_работ". При необходимости она может быть перемещена или удалена.
        Me.Виды_работTableAdapter.Fill(Me.DipIPDataSet.Виды_работ)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
        Me.СотрудникиTableAdapter.Fill(Me.DipIPDataSet.Сотрудники)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
        Me.КлиентыTableAdapter.Fill(Me.DipIPDataSet.Клиенты)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "DipIPDataSet.СтатусЗаявки". При необходимости она может быть перемещена или удалена.
        Me.СтатусЗаявкиTableAdapter.FillBySumma(Me.DipIPDataSet.СтатусЗаявки)


    End Sub


End Class