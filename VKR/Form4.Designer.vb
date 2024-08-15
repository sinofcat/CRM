<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.СтатусЗаявкиBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.СтатусЗаявкиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DipIPDataSet = New VKR.DipIPDataSet()
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
        Me.СтатусЗаявкиBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.СтатусЗаявкиDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.КлиентыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.СотрудникиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ВидыработBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.СтатусBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Param1ToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Param1ToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ЗаявкаTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.СтатусЗаявкиTableAdapter = New VKR.DipIPDataSetTableAdapters.СтатусЗаявкиTableAdapter()
        Me.TableAdapterManager = New VKR.DipIPDataSetTableAdapters.TableAdapterManager()
        Me.VipolnenieStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VipolnenieStatusTableAdapter = New VKR.DipIPDataSetTableAdapters.VipolnenieStatusTableAdapter()
        Me.КлиентыTableAdapter = New VKR.DipIPDataSetTableAdapters.КлиентыTableAdapter()
        Me.СотрудникиTableAdapter = New VKR.DipIPDataSetTableAdapters.СотрудникиTableAdapter()
        Me.Виды_работTableAdapter = New VKR.DipIPDataSetTableAdapters.Виды_работTableAdapter()
        Me.СтатусTableAdapter = New VKR.DipIPDataSetTableAdapters.СтатусTableAdapter()
        CType(Me.СтатусЗаявкиBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.СтатусЗаявкиBindingNavigator.SuspendLayout()
        CType(Me.СтатусЗаявкиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DipIPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СтатусЗаявкиDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КлиентыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СотрудникиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ВидыработBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СтатусBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.VipolnenieStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'СтатусЗаявкиBindingNavigator
        '
        Me.СтатусЗаявкиBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.СтатусЗаявкиBindingNavigator.BindingSource = Me.СтатусЗаявкиBindingSource
        Me.СтатусЗаявкиBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.СтатусЗаявкиBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.СтатусЗаявкиBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.СтатусЗаявкиBindingNavigatorSaveItem})
        Me.СтатусЗаявкиBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.СтатусЗаявкиBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.СтатусЗаявкиBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.СтатусЗаявкиBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.СтатусЗаявкиBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.СтатусЗаявкиBindingNavigator.Name = "СтатусЗаявкиBindingNavigator"
        Me.СтатусЗаявкиBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.СтатусЗаявкиBindingNavigator.Size = New System.Drawing.Size(1238, 25)
        Me.СтатусЗаявкиBindingNavigator.TabIndex = 0
        Me.СтатусЗаявкиBindingNavigator.Text = "BindingNavigator1"
        Me.СтатусЗаявкиBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'СтатусЗаявкиBindingSource
        '
        Me.СтатусЗаявкиBindingSource.DataMember = "СтатусЗаявки"
        Me.СтатусЗаявкиBindingSource.DataSource = Me.DipIPDataSet
        '
        'DipIPDataSet
        '
        Me.DipIPDataSet.DataSetName = "DipIPDataSet"
        Me.DipIPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
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
        'СтатусЗаявкиBindingNavigatorSaveItem
        '
        Me.СтатусЗаявкиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.СтатусЗаявкиBindingNavigatorSaveItem.Image = CType(resources.GetObject("СтатусЗаявкиBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.СтатусЗаявкиBindingNavigatorSaveItem.Name = "СтатусЗаявкиBindingNavigatorSaveItem"
        Me.СтатусЗаявкиBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.СтатусЗаявкиBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'СтатусЗаявкиDataGridView
        '
        Me.СтатусЗаявкиDataGridView.AllowUserToAddRows = False
        Me.СтатусЗаявкиDataGridView.AllowUserToDeleteRows = False
        Me.СтатусЗаявкиDataGridView.AutoGenerateColumns = False
        Me.СтатусЗаявкиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.СтатусЗаявкиDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.СтатусЗаявкиDataGridView.DataSource = Me.СтатусЗаявкиBindingSource
        Me.СтатусЗаявкиDataGridView.Location = New System.Drawing.Point(2, 36)
        Me.СтатусЗаявкиDataGridView.Name = "СтатусЗаявкиDataGridView"
        Me.СтатусЗаявкиDataGridView.ReadOnly = True
        Me.СтатусЗаявкиDataGridView.Size = New System.Drawing.Size(1146, 476)
        Me.СтатусЗаявкиDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Заявка"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Номер заявки"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Клиент"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.КлиентыBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "Клиент"
        Me.DataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn2.HeaderText = "Клиент"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "ID_client"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'КлиентыBindingSource
        '
        Me.КлиентыBindingSource.DataMember = "Клиенты"
        Me.КлиентыBindingSource.DataSource = Me.DipIPDataSet
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Сотрудник"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.СотрудникиBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "ФИО"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "Сотрудник"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "ID_sotr"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'СотрудникиBindingSource
        '
        Me.СотрудникиBindingSource.DataMember = "Сотрудники"
        Me.СотрудникиBindingSource.DataSource = Me.DipIPDataSet
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Работа"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.ВидыработBindingSource
        Me.DataGridViewTextBoxColumn4.DisplayMember = "Наименование"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Услуги"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "ID_rab"
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'ВидыработBindingSource
        '
        Me.ВидыработBindingSource.DataMember = "Виды_работ"
        Me.ВидыработBindingSource.DataSource = Me.DipIPDataSet
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Дата_заключения"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Дата заключения"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Дата_окончания"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Дата окончания"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Сумма"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Сумма (сом)"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Статус"
        Me.DataGridViewTextBoxColumn8.DataSource = Me.СтатусBindingSource
        Me.DataGridViewTextBoxColumn8.DisplayMember = "Статус"
        Me.DataGridViewTextBoxColumn8.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn8.HeaderText = "Статус"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn8.ValueMember = "ID_st"
        '
        'СтатусBindingSource
        '
        Me.СтатусBindingSource.DataMember = "Статус"
        Me.СтатусBindingSource.DataSource = Me.DipIPDataSet
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Статус_даты"
        Me.DataGridViewTextBoxColumn9.HeaderText = "По сроком выполнение"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Param1ToolStripLabel, Me.Param1ToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(1238, 25)
        Me.FillToolStrip.TabIndex = 2
        Me.FillToolStrip.Text = "FillToolStrip"
        Me.FillToolStrip.Visible = False
        '
        'Param1ToolStripLabel
        '
        Me.Param1ToolStripLabel.Name = "Param1ToolStripLabel"
        Me.Param1ToolStripLabel.Size = New System.Drawing.Size(50, 22)
        Me.Param1ToolStripLabel.Text = "Param1:"
        '
        'Param1ToolStripTextBox
        '
        Me.Param1ToolStripTextBox.Name = "Param1ToolStripTextBox"
        Me.Param1ToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 22)
        Me.FillToolStripButton.Text = "Fill"
        '
        'ЗаявкаTextBox
        '
        Me.ЗаявкаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.СтатусЗаявкиBindingSource, "Заявка", True))
        Me.ЗаявкаTextBox.Location = New System.Drawing.Point(624, 569)
        Me.ЗаявкаTextBox.Name = "ЗаявкаTextBox"
        Me.ЗаявкаTextBox.ReadOnly = True
        Me.ЗаявкаTextBox.Size = New System.Drawing.Size(44, 20)
        Me.ЗаявкаTextBox.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(1161, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Завершить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Выберите заявку для завершения "
        '
        'СтатусЗаявкиTableAdapter
        '
        Me.СтатусЗаявкиTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = VKR.DipIPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Виды_работTableAdapter = Nothing
        Me.TableAdapterManager.Выполнения_работыTableAdapter = Nothing
        Me.TableAdapterManager.ДолжностиTableAdapter = Nothing
        Me.TableAdapterManager.Ед_измеренияTableAdapter = Nothing
        Me.TableAdapterManager.ЗаявкаTableAdapter = Nothing
        Me.TableAdapterManager.КлиентыTableAdapter = Nothing
        Me.TableAdapterManager.МатериалыTableAdapter = Nothing
        Me.TableAdapterManager.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager.СтатусTableAdapter = Nothing
        Me.TableAdapterManager.СтатусЗаявкиTableAdapter = Me.СтатусЗаявкиTableAdapter
        '
        'VipolnenieStatusBindingSource
        '
        Me.VipolnenieStatusBindingSource.DataMember = "VipolnenieStatus"
        Me.VipolnenieStatusBindingSource.DataSource = Me.DipIPDataSet
        '
        'VipolnenieStatusTableAdapter
        '
        Me.VipolnenieStatusTableAdapter.ClearBeforeFill = True
        '
        'КлиентыTableAdapter
        '
        Me.КлиентыTableAdapter.ClearBeforeFill = True
        '
        'СотрудникиTableAdapter
        '
        Me.СотрудникиTableAdapter.ClearBeforeFill = True
        '
        'Виды_работTableAdapter
        '
        Me.Виды_работTableAdapter.ClearBeforeFill = True
        '
        'СтатусTableAdapter
        '
        Me.СтатусTableAdapter.ClearBeforeFill = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 524)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ЗаявкаTextBox)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.СтатусЗаявкиDataGridView)
        Me.Controls.Add(Me.СтатусЗаявкиBindingNavigator)
        Me.Name = "Form4"
        Me.Text = "Выполнения работ по заявкам"
        CType(Me.СтатусЗаявкиBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.СтатусЗаявкиBindingNavigator.ResumeLayout(False)
        Me.СтатусЗаявкиBindingNavigator.PerformLayout()
        CType(Me.СтатусЗаявкиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DipIPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СтатусЗаявкиDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КлиентыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СотрудникиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ВидыработBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СтатусBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.VipolnenieStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DipIPDataSet As DipIPDataSet
    Friend WithEvents СтатусЗаявкиBindingSource As BindingSource
    Friend WithEvents СтатусЗаявкиTableAdapter As DipIPDataSetTableAdapters.СтатусЗаявкиTableAdapter
    Friend WithEvents TableAdapterManager As DipIPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents СтатусЗаявкиBindingNavigator As BindingNavigator
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
    Friend WithEvents СтатусЗаявкиBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents СтатусЗаявкиDataGridView As DataGridView
    Friend WithEvents VipolnenieStatusBindingSource As BindingSource
    Friend WithEvents VipolnenieStatusTableAdapter As DipIPDataSetTableAdapters.VipolnenieStatusTableAdapter
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents Param1ToolStripLabel As ToolStripLabel
    Friend WithEvents Param1ToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillToolStripButton As ToolStripButton
    Friend WithEvents ЗаявкаTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents КлиентыBindingSource As BindingSource
    Friend WithEvents КлиентыTableAdapter As DipIPDataSetTableAdapters.КлиентыTableAdapter
    Friend WithEvents СотрудникиBindingSource As BindingSource
    Friend WithEvents СотрудникиTableAdapter As DipIPDataSetTableAdapters.СотрудникиTableAdapter
    Friend WithEvents ВидыработBindingSource As BindingSource
    Friend WithEvents Виды_работTableAdapter As DipIPDataSetTableAdapters.Виды_работTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents СтатусBindingSource As BindingSource
    Friend WithEvents СтатусTableAdapter As DipIPDataSetTableAdapters.СтатусTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
