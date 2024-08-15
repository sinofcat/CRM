Imports System.Windows.Forms

Public Class MDI_main
    Private Sub openchild(Child As Form)
        'Перед загрузкой дочерней формы, закрываем текущую
        Dim f As Boolean = True
        If ActiveMdiChild IsNot Nothing Then
            If ActiveMdiChild.Name.Equals(Child.Name) Then
                f = False
            End If
            ActiveMdiChild.Close()
        End If
        If f = True Then
            Child.MdiParent = Me
            Child.Show()
        End If
    End Sub
    Private Sub ЗаявкиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗаявкиToolStripMenuItem.Click
        openchild(Form1)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As DialogResult
        result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If result = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub ВыполненияЗаявкиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ВыполненияЗаявкиToolStripMenuItem.Click
        openchild(Form2)
    End Sub

    Private Sub ВыполненияЗаявкиToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ВыполненияЗаявкиToolStripMenuItem1.Click
        openchild(Form4)
    End Sub

    Private Sub РегистрацияКлиентаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РегистрацияКлиентаToolStripMenuItem.Click
        openchild(Form6)
    End Sub

    Private Sub СотрудникиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СотрудникиToolStripMenuItem.Click
        openchild(Form7)
    End Sub

    Private Sub УслугиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles УслугиToolStripMenuItem.Click
        openchild(Form8)
    End Sub

    Private Sub ДолжностиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДолжностиToolStripMenuItem.Click
        openchild(Form9)
    End Sub

    Private Sub МатериалыToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles МатериалыToolStripMenuItem.Click
        openchild(Form10)
    End Sub

    Private Sub ЕдиницаИзмеренияToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЕдиницаИзмеренияToolStripMenuItem.Click
        openchild(Form11)
    End Sub

    Private Sub ОтчетToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОтчетToolStripMenuItem.Click
        openchild(Form12)
    End Sub
End Class
