<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI_main
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI_main))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОперацииToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РегистрацияКлиентаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗаявкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыполненияЗаявкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыполненияЗаявкиToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОтчетToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправочникиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СотрудникиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.УслугиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ДолжностиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.МатериалыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЕдиницаИзмеренияToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ОперацииToolStripMenuItem, Me.СправочникиToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1023, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(48, 20)
        Me.FileMenu.Text = "&Файл"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.ExitToolStripMenuItem.Text = "В&ыход"
        '
        'ОперацииToolStripMenuItem
        '
        Me.ОперацииToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.РегистрацияКлиентаToolStripMenuItem, Me.ЗаявкиToolStripMenuItem, Me.ВыполненияЗаявкиToolStripMenuItem, Me.ВыполненияЗаявкиToolStripMenuItem1, Me.ОтчетToolStripMenuItem})
        Me.ОперацииToolStripMenuItem.Name = "ОперацииToolStripMenuItem"
        Me.ОперацииToolStripMenuItem.Size = New System.Drawing.Size(129, 20)
        Me.ОперацииToolStripMenuItem.Text = "Работа с клиентами"
        '
        'РегистрацияКлиентаToolStripMenuItem
        '
        Me.РегистрацияКлиентаToolStripMenuItem.Name = "РегистрацияКлиентаToolStripMenuItem"
        Me.РегистрацияКлиентаToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.РегистрацияКлиентаToolStripMenuItem.Text = "Регистрация клиента"
        '
        'ЗаявкиToolStripMenuItem
        '
        Me.ЗаявкиToolStripMenuItem.Name = "ЗаявкиToolStripMenuItem"
        Me.ЗаявкиToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ЗаявкиToolStripMenuItem.Text = "Принять заявки"
        '
        'ВыполненияЗаявкиToolStripMenuItem
        '
        Me.ВыполненияЗаявкиToolStripMenuItem.Name = "ВыполненияЗаявкиToolStripMenuItem"
        Me.ВыполненияЗаявкиToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ВыполненияЗаявкиToolStripMenuItem.Text = "Расходы заявок"
        '
        'ВыполненияЗаявкиToolStripMenuItem1
        '
        Me.ВыполненияЗаявкиToolStripMenuItem1.Name = "ВыполненияЗаявкиToolStripMenuItem1"
        Me.ВыполненияЗаявкиToolStripMenuItem1.Size = New System.Drawing.Size(190, 22)
        Me.ВыполненияЗаявкиToolStripMenuItem1.Text = "Выполнения заявки"
        '
        'ОтчетToolStripMenuItem
        '
        Me.ОтчетToolStripMenuItem.Name = "ОтчетToolStripMenuItem"
        Me.ОтчетToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ОтчетToolStripMenuItem.Text = "Отчет"
        '
        'СправочникиToolStripMenuItem
        '
        Me.СправочникиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СотрудникиToolStripMenuItem, Me.УслугиToolStripMenuItem, Me.ДолжностиToolStripMenuItem, Me.МатериалыToolStripMenuItem, Me.ЕдиницаИзмеренияToolStripMenuItem})
        Me.СправочникиToolStripMenuItem.Name = "СправочникиToolStripMenuItem"
        Me.СправочникиToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.СправочникиToolStripMenuItem.Text = "Справочники"
        '
        'СотрудникиToolStripMenuItem
        '
        Me.СотрудникиToolStripMenuItem.Name = "СотрудникиToolStripMenuItem"
        Me.СотрудникиToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.СотрудникиToolStripMenuItem.Text = "Сотрудники"
        '
        'УслугиToolStripMenuItem
        '
        Me.УслугиToolStripMenuItem.Name = "УслугиToolStripMenuItem"
        Me.УслугиToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.УслугиToolStripMenuItem.Text = "Услуги"
        '
        'ДолжностиToolStripMenuItem
        '
        Me.ДолжностиToolStripMenuItem.Name = "ДолжностиToolStripMenuItem"
        Me.ДолжностиToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ДолжностиToolStripMenuItem.Text = "Должности"
        '
        'МатериалыToolStripMenuItem
        '
        Me.МатериалыToolStripMenuItem.Name = "МатериалыToolStripMenuItem"
        Me.МатериалыToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.МатериалыToolStripMenuItem.Text = "Материалы"
        '
        'ЕдиницаИзмеренияToolStripMenuItem
        '
        Me.ЕдиницаИзмеренияToolStripMenuItem.Name = "ЕдиницаИзмеренияToolStripMenuItem"
        Me.ЕдиницаИзмеренияToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ЕдиницаИзмеренияToolStripMenuItem.Text = "Единица измерения"
        '
        'ToolStrip
        '
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1023, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 618)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1023, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(66, 17)
        Me.ToolStripStatusLabel.Text = "Состояние"
        '
        'MDI_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1023, 640)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDI_main"
        Me.Text = "ОсОО ""IP Net"""
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ОперацииToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ЗаявкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents РегистрацияКлиентаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВыполненияЗаявкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СправочникиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ВыполненияЗаявкиToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents СотрудникиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents УслугиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ДолжностиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents МатериалыToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ЕдиницаИзмеренияToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОтчетToolStripMenuItem As ToolStripMenuItem
End Class
