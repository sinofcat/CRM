<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.DipIPDataSet = New VKR.DipIPDataSet()
        Me.МатериалыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.МатериалыTableAdapter = New VKR.DipIPDataSetTableAdapters.МатериалыTableAdapter()
        Me.TableAdapterManager = New VKR.DipIPDataSetTableAdapters.TableAdapterManager()
        Me.МатериалыBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.МатериалыBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.МатериалыDataGridView = New System.Windows.Forms.DataGridView()
        Me.ЕдизмеренияBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ед_измеренияTableAdapter = New VKR.DipIPDataSetTableAdapters.Ед_измеренияTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.DipIPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.МатериалыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.МатериалыBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.МатериалыBindingNavigator.SuspendLayout()
        CType(Me.МатериалыDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЕдизмеренияBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DipIPDataSet
        '
        Me.DipIPDataSet.DataSetName = "DipIPDataSet"
        Me.DipIPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'МатериалыBindingSource
        '
        Me.МатериалыBindingSource.DataMember = "Материалы"
        Me.МатериалыBindingSource.DataSource = Me.DipIPDataSet
        '
        'МатериалыTableAdapter
        '
        Me.МатериалыTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = VKR.DipIPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Виды_работTableAdapter = Nothing
        Me.TableAdapterManager.Выполнения_работыTableAdapter = Nothing
        Me.TableAdapterManager.ДолжностиTableAdapter = Nothing
        Me.TableAdapterManager.Ед_измеренияTableAdapter = Me.Ед_измеренияTableAdapter
        Me.TableAdapterManager.ЗаявкаTableAdapter = Nothing
        Me.TableAdapterManager.КлиентыTableAdapter = Nothing
        Me.TableAdapterManager.МатериалыTableAdapter = Me.МатериалыTableAdapter
        Me.TableAdapterManager.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager.СтатусTableAdapter = Nothing
        Me.TableAdapterManager.СтатусЗаявкиTableAdapter = Nothing
        '
        'МатериалыBindingNavigator
        '
        Me.МатериалыBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.МатериалыBindingNavigator.BindingSource = Me.МатериалыBindingSource
        Me.МатериалыBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.МатериалыBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.МатериалыBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.МатериалыBindingNavigatorSaveItem})
        Me.МатериалыBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.МатериалыBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.МатериалыBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.МатериалыBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.МатериалыBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.МатериалыBindingNavigator.Name = "МатериалыBindingNavigator"
        Me.МатериалыBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.МатериалыBindingNavigator.Size = New System.Drawing.Size(593, 25)
        Me.МатериалыBindingNavigator.TabIndex = 0
        Me.МатериалыBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 15)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'МатериалыBindingNavigatorSaveItem
        '
        Me.МатериалыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.МатериалыBindingNavigatorSaveItem.Image = CType(resources.GetObject("МатериалыBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.МатериалыBindingNavigatorSaveItem.Name = "МатериалыBindingNavigatorSaveItem"
        Me.МатериалыBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.МатериалыBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'МатериалыDataGridView
        '
        Me.МатериалыDataGridView.AutoGenerateColumns = False
        Me.МатериалыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.МатериалыDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.МатериалыDataGridView.DataSource = Me.МатериалыBindingSource
        Me.МатериалыDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.МатериалыDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.МатериалыDataGridView.Name = "МатериалыDataGridView"
        Me.МатериалыDataGridView.Size = New System.Drawing.Size(593, 375)
        Me.МатериалыDataGridView.TabIndex = 1
        '
        'ЕдизмеренияBindingSource
        '
        Me.ЕдизмеренияBindingSource.DataMember = "Ед_измерения"
        Me.ЕдизмеренияBindingSource.DataSource = Me.DipIPDataSet
        '
        'Ед_измеренияTableAdapter
        '
        Me.Ед_измеренияTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_material"
        Me.DataGridViewTextBoxColumn1.HeaderText = "№"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Материал"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Материал"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "стоимость"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Стоимость (сом)"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ед_измерения"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.ЕдизмеренияBindingSource
        Me.DataGridViewTextBoxColumn4.DisplayMember = "Ед_измерения"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ед измерения"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "ID_ed"
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 400)
        Me.Controls.Add(Me.МатериалыDataGridView)
        Me.Controls.Add(Me.МатериалыBindingNavigator)
        Me.Name = "Form10"
        Me.Text = "Материалы"
        CType(Me.DipIPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.МатериалыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.МатериалыBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.МатериалыBindingNavigator.ResumeLayout(False)
        Me.МатериалыBindingNavigator.PerformLayout()
        CType(Me.МатериалыDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЕдизмеренияBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DipIPDataSet As DipIPDataSet
    Friend WithEvents МатериалыBindingSource As BindingSource
    Friend WithEvents МатериалыTableAdapter As DipIPDataSetTableAdapters.МатериалыTableAdapter
    Friend WithEvents TableAdapterManager As DipIPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents МатериалыBindingNavigator As BindingNavigator
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
    Friend WithEvents МатериалыBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents МатериалыDataGridView As DataGridView
    Friend WithEvents Ед_измеренияTableAdapter As DipIPDataSetTableAdapters.Ед_измеренияTableAdapter
    Friend WithEvents ЕдизмеренияBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewComboBoxColumn
End Class
