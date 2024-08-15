<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim ID_zLabel As System.Windows.Forms.Label
        Dim Дата_заключенияLabel As System.Windows.Forms.Label
        Dim РаботаLabel As System.Windows.Forms.Label
        Dim КлиентLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DipIPDataSet = New VKR.DipIPDataSet()
        Me.ЗаявкаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЗаявкаTableAdapter = New VKR.DipIPDataSetTableAdapters.ЗаявкаTableAdapter()
        Me.TableAdapterManager = New VKR.DipIPDataSetTableAdapters.TableAdapterManager()
        Me.Виды_работTableAdapter = New VKR.DipIPDataSetTableAdapters.Виды_работTableAdapter()
        Me.КлиентыTableAdapter = New VKR.DipIPDataSetTableAdapters.КлиентыTableAdapter()
        Me.ЗаявкаBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ЗаявкаBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ID_zTextBox = New System.Windows.Forms.TextBox()
        Me.Дата_заключенияDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ВидыработBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.КлиентыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        ID_zLabel = New System.Windows.Forms.Label()
        Дата_заключенияLabel = New System.Windows.Forms.Label()
        РаботаLabel = New System.Windows.Forms.Label()
        КлиентLabel = New System.Windows.Forms.Label()
        CType(Me.DipIPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗаявкаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗаявкаBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ЗаявкаBindingNavigator.SuspendLayout()
        CType(Me.ВидыработBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КлиентыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_zLabel
        '
        ID_zLabel.AutoSize = True
        ID_zLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ID_zLabel.Location = New System.Drawing.Point(49, 88)
        ID_zLabel.Name = "ID_zLabel"
        ID_zLabel.Size = New System.Drawing.Size(119, 20)
        ID_zLabel.TabIndex = 1
        ID_zLabel.Text = "Номер заявки:"
        '
        'Дата_заключенияLabel
        '
        Дата_заключенияLabel.AutoSize = True
        Дата_заключенияLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Дата_заключенияLabel.Location = New System.Drawing.Point(49, 127)
        Дата_заключенияLabel.Name = "Дата_заключенияLabel"
        Дата_заключенияLabel.Size = New System.Drawing.Size(148, 20)
        Дата_заключенияLabel.TabIndex = 3
        Дата_заключенияLabel.Text = "Дата заключения:"
        '
        'РаботаLabel
        '
        РаботаLabel.AutoSize = True
        РаботаLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        РаботаLabel.Location = New System.Drawing.Point(49, 161)
        РаботаLabel.Name = "РаботаLabel"
        РаботаLabel.Size = New System.Drawing.Size(64, 20)
        РаботаLabel.TabIndex = 5
        РаботаLabel.Text = "Услуга:"
        '
        'КлиентLabel
        '
        КлиентLabel.AutoSize = True
        КлиентLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        КлиентLabel.Location = New System.Drawing.Point(49, 197)
        КлиентLabel.Name = "КлиентLabel"
        КлиентLabel.Size = New System.Drawing.Size(69, 20)
        КлиентLabel.TabIndex = 7
        КлиентLabel.Text = "Клиент:"
        '
        'DipIPDataSet
        '
        Me.DipIPDataSet.DataSetName = "DipIPDataSet"
        Me.DipIPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ЗаявкаBindingSource
        '
        Me.ЗаявкаBindingSource.DataMember = "Заявка"
        Me.ЗаявкаBindingSource.DataSource = Me.DipIPDataSet
        '
        'ЗаявкаTableAdapter
        '
        Me.ЗаявкаTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = VKR.DipIPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Виды_работTableAdapter = Me.Виды_работTableAdapter
        Me.TableAdapterManager.Выполнения_работыTableAdapter = Nothing
        Me.TableAdapterManager.ДолжностиTableAdapter = Nothing
        Me.TableAdapterManager.Ед_измеренияTableAdapter = Nothing
        Me.TableAdapterManager.ЗаявкаTableAdapter = Me.ЗаявкаTableAdapter
        Me.TableAdapterManager.КлиентыTableAdapter = Me.КлиентыTableAdapter
        Me.TableAdapterManager.МатериалыTableAdapter = Nothing
        Me.TableAdapterManager.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager.СтатусTableAdapter = Nothing
        Me.TableAdapterManager.СтатусЗаявкиTableAdapter = Nothing
        '
        'Виды_работTableAdapter
        '
        Me.Виды_работTableAdapter.ClearBeforeFill = True
        '
        'КлиентыTableAdapter
        '
        Me.КлиентыTableAdapter.ClearBeforeFill = True
        '
        'ЗаявкаBindingNavigator
        '
        Me.ЗаявкаBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ЗаявкаBindingNavigator.BindingSource = Me.ЗаявкаBindingSource
        Me.ЗаявкаBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ЗаявкаBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ЗаявкаBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ЗаявкаBindingNavigatorSaveItem})
        Me.ЗаявкаBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ЗаявкаBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ЗаявкаBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ЗаявкаBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ЗаявкаBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ЗаявкаBindingNavigator.Name = "ЗаявкаBindingNavigator"
        Me.ЗаявкаBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ЗаявкаBindingNavigator.Size = New System.Drawing.Size(692, 25)
        Me.ЗаявкаBindingNavigator.TabIndex = 0
        Me.ЗаявкаBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(79, 22)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 22)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(71, 22)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ЗаявкаBindingNavigatorSaveItem
        '
        Me.ЗаявкаBindingNavigatorSaveItem.Image = CType(resources.GetObject("ЗаявкаBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ЗаявкаBindingNavigatorSaveItem.Name = "ЗаявкаBindingNavigatorSaveItem"
        Me.ЗаявкаBindingNavigatorSaveItem.Size = New System.Drawing.Size(130, 22)
        Me.ЗаявкаBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'ID_zTextBox
        '
        Me.ID_zTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ЗаявкаBindingSource, "ID_z", True))
        Me.ID_zTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ID_zTextBox.Location = New System.Drawing.Point(236, 88)
        Me.ID_zTextBox.Name = "ID_zTextBox"
        Me.ID_zTextBox.ReadOnly = True
        Me.ID_zTextBox.Size = New System.Drawing.Size(325, 26)
        Me.ID_zTextBox.TabIndex = 2
        '
        'Дата_заключенияDateTimePicker
        '
        Me.Дата_заключенияDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ЗаявкаBindingSource, "Дата_заключения", True))
        Me.Дата_заключенияDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Дата_заключенияDateTimePicker.Location = New System.Drawing.Point(236, 121)
        Me.Дата_заключенияDateTimePicker.Name = "Дата_заключенияDateTimePicker"
        Me.Дата_заключенияDateTimePicker.Size = New System.Drawing.Size(325, 26)
        Me.Дата_заключенияDateTimePicker.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ЗаявкаBindingSource, "Работа", True))
        Me.ComboBox1.DataSource = Me.ВидыработBindingSource
        Me.ComboBox1.DisplayMember = "Наименование"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(236, 157)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(325, 28)
        Me.ComboBox1.TabIndex = 9
        Me.ComboBox1.ValueMember = "ID_rab"
        '
        'ВидыработBindingSource
        '
        Me.ВидыработBindingSource.DataMember = "Виды_работ"
        Me.ВидыработBindingSource.DataSource = Me.DipIPDataSet
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ЗаявкаBindingSource, "Клиент", True))
        Me.ComboBox2.DataSource = Me.КлиентыBindingSource
        Me.ComboBox2.DisplayMember = "Клиент"
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(236, 195)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(325, 28)
        Me.ComboBox2.TabIndex = 10
        Me.ComboBox2.ValueMember = "ID_client"
        '
        'КлиентыBindingSource
        '
        Me.КлиентыBindingSource.DataMember = "Клиенты"
        Me.КлиентыBindingSource.DataSource = Me.DipIPDataSet
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 355)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(ID_zLabel)
        Me.Controls.Add(Me.ID_zTextBox)
        Me.Controls.Add(Дата_заключенияLabel)
        Me.Controls.Add(Me.Дата_заключенияDateTimePicker)
        Me.Controls.Add(РаботаLabel)
        Me.Controls.Add(КлиентLabel)
        Me.Controls.Add(Me.ЗаявкаBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Регистрация заявок"
        CType(Me.DipIPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗаявкаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗаявкаBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ЗаявкаBindingNavigator.ResumeLayout(False)
        Me.ЗаявкаBindingNavigator.PerformLayout()
        CType(Me.ВидыработBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КлиентыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DipIPDataSet As DipIPDataSet
    Friend WithEvents ЗаявкаBindingSource As BindingSource
    Friend WithEvents ЗаявкаTableAdapter As DipIPDataSetTableAdapters.ЗаявкаTableAdapter
    Friend WithEvents TableAdapterManager As DipIPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ЗаявкаBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ЗаявкаBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ID_zTextBox As TextBox
    Friend WithEvents Дата_заключенияDateTimePicker As DateTimePicker
    Friend WithEvents Виды_работTableAdapter As DipIPDataSetTableAdapters.Виды_работTableAdapter
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ВидыработBindingSource As BindingSource
    Friend WithEvents КлиентыTableAdapter As DipIPDataSetTableAdapters.КлиентыTableAdapter
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents КлиентыBindingSource As BindingSource
End Class
