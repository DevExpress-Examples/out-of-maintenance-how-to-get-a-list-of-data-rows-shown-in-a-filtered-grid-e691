Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridViewDataTable = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.filteredDataSource_DataTable = New System.Windows.Forms.BindingSource(Me.components)
			Me.gridViewFilteredDataView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.filteredDataSourceHelper_DataTable = New WindowsApplication1.FilteredDataSourceHelperComponent()
			Me.groupControl3 = New DevExpress.XtraEditors.GroupControl()
			Me.splitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.gridControl3 = New DevExpress.XtraGrid.GridControl()
			Me.gridViewBindingList = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.groupControl4 = New DevExpress.XtraEditors.GroupControl()
			Me.gridControl4 = New DevExpress.XtraGrid.GridControl()
			Me.gridViewFilteredBindingList = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.filteredDataSourceHelper_BindingList = New WindowsApplication1.FilteredDataSourceHelperComponent()
			Me.filteredDataSource_BindingList = New System.Windows.Forms.BindingSource(Me.components)
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridViewDataTable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.filteredDataSource_DataTable, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridViewFilteredDataView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl3.SuspendLayout()
			CType(Me.splitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl2.SuspendLayout()
			CType(Me.gridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridViewBindingList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl4.SuspendLayout()
			CType(Me.gridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridViewFilteredBindingList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView8, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.filteredDataSource_BindingList, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.splitContainerControl1)
			Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.groupControl1.Location = New System.Drawing.Point(0, 0)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(394, 547)
			Me.groupControl1.TabIndex = 0
			Me.groupControl1.Text = "DataSet"
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Horizontal = False
			Me.splitContainerControl1.Location = New System.Drawing.Point(2, 21)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.gridControl1)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.groupControl2)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(390, 524)
			Me.splitContainerControl1.SplitterPosition = 231
			Me.splitContainerControl1.TabIndex = 0
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridViewDataTable
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(390, 231)
			Me.gridControl1.TabIndex = 7
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridViewDataTable, Me.gridView2})
			' 
			' gridViewDataTable
			' 
			Me.gridViewDataTable.GridControl = Me.gridControl1
			Me.gridViewDataTable.Name = "gridViewDataTable"
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' groupControl2
			' 
			Me.groupControl2.Controls.Add(Me.gridControl2)
			Me.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupControl2.Location = New System.Drawing.Point(0, 0)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Size = New System.Drawing.Size(390, 288)
			Me.groupControl2.TabIndex = 0
			Me.groupControl2.Text = "GridControl bound to a filtered datasource"
			' 
			' gridControl2
			' 
			Me.gridControl2.DataSource = Me.filteredDataSource_DataTable
			Me.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl2.Location = New System.Drawing.Point(2, 21)
			Me.gridControl2.MainView = Me.gridViewFilteredDataView
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.Size = New System.Drawing.Size(386, 265)
			Me.gridControl2.TabIndex = 9
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridViewFilteredDataView, Me.gridView4})
			' 
			' gridViewFilteredDataView
			' 
			Me.gridViewFilteredDataView.GridControl = Me.gridControl2
			Me.gridViewFilteredDataView.Name = "gridViewFilteredDataView"
			' 
			' gridView4
			' 
			Me.gridView4.GridControl = Me.gridControl2
			Me.gridView4.Name = "gridView4"
			' 
			' filteredDataSourceHelper_DataTable
			' 
			Me.filteredDataSourceHelper_DataTable.FilteredDataSource = Me.filteredDataSource_DataTable
			Me.filteredDataSourceHelper_DataTable.View = Me.gridViewDataTable
			' 
			' groupControl3
			' 
			Me.groupControl3.Controls.Add(Me.splitContainerControl2)
			Me.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupControl3.Location = New System.Drawing.Point(394, 0)
			Me.groupControl3.Name = "groupControl3"
			Me.groupControl3.Size = New System.Drawing.Size(457, 547)
			Me.groupControl3.TabIndex = 1
			Me.groupControl3.Text = "BindingList"
			' 
			' splitContainerControl2
			' 
			Me.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl2.Horizontal = False
			Me.splitContainerControl2.Location = New System.Drawing.Point(2, 21)
			Me.splitContainerControl2.Name = "splitContainerControl2"
			Me.splitContainerControl2.Panel1.Controls.Add(Me.gridControl3)
			Me.splitContainerControl2.Panel1.Text = "Panel1"
			Me.splitContainerControl2.Panel2.Controls.Add(Me.groupControl4)
			Me.splitContainerControl2.Panel2.Text = "Panel2"
			Me.splitContainerControl2.Size = New System.Drawing.Size(453, 524)
			Me.splitContainerControl2.SplitterPosition = 231
			Me.splitContainerControl2.TabIndex = 0
			Me.splitContainerControl2.Text = "splitContainerControl2"
			' 
			' gridControl3
			' 
			Me.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl3.Location = New System.Drawing.Point(0, 0)
			Me.gridControl3.MainView = Me.gridViewBindingList
			Me.gridControl3.Name = "gridControl3"
			Me.gridControl3.Size = New System.Drawing.Size(453, 231)
			Me.gridControl3.TabIndex = 7
			Me.gridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridViewBindingList, Me.gridView6})
			' 
			' gridViewBindingList
			' 
			Me.gridViewBindingList.GridControl = Me.gridControl3
			Me.gridViewBindingList.Name = "gridViewBindingList"
			' 
			' gridView6
			' 
			Me.gridView6.GridControl = Me.gridControl3
			Me.gridView6.Name = "gridView6"
			' 
			' groupControl4
			' 
			Me.groupControl4.Controls.Add(Me.gridControl4)
			Me.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupControl4.Location = New System.Drawing.Point(0, 0)
			Me.groupControl4.Name = "groupControl4"
			Me.groupControl4.Size = New System.Drawing.Size(453, 288)
			Me.groupControl4.TabIndex = 0
			Me.groupControl4.Text = "GridControl bound to a filtered datasource"
			' 
			' gridControl4
			' 
			Me.gridControl4.DataSource = Me.filteredDataSource_BindingList
			Me.gridControl4.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl4.Location = New System.Drawing.Point(2, 21)
			Me.gridControl4.MainView = Me.gridViewFilteredBindingList
			Me.gridControl4.Name = "gridControl4"
			Me.gridControl4.Size = New System.Drawing.Size(449, 265)
			Me.gridControl4.TabIndex = 9
			Me.gridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridViewFilteredBindingList, Me.gridView8})
			' 
			' gridViewFilteredBindingList
			' 
			Me.gridViewFilteredBindingList.GridControl = Me.gridControl4
			Me.gridViewFilteredBindingList.Name = "gridViewFilteredBindingList"
			' 
			' gridView8
			' 
			Me.gridView8.GridControl = Me.gridControl4
			Me.gridView8.Name = "gridView8"
			' 
			' filteredDataSourceHelper_BindingList
			' 
			Me.filteredDataSourceHelper_BindingList.FilteredDataSource = Me.filteredDataSource_BindingList
			Me.filteredDataSourceHelper_BindingList.View = Me.gridViewBindingList
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(851, 547)
			Me.Controls.Add(Me.groupControl3)
			Me.Controls.Add(Me.groupControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridViewDataTable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.filteredDataSource_DataTable, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridViewFilteredDataView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl3.ResumeLayout(False)
			CType(Me.splitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl2.ResumeLayout(False)
			CType(Me.gridControl3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridViewBindingList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl4.ResumeLayout(False)
			CType(Me.gridControl4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridViewFilteredBindingList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView8, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.filteredDataSource_BindingList, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridViewDataTable As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private filteredDataSourceHelper_DataTable As FilteredDataSourceHelperComponent
		Private filteredDataSource_DataTable As System.Windows.Forms.BindingSource
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private gridViewFilteredDataView As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView4 As DevExpress.XtraGrid.Views.Grid.GridView
		Private groupControl3 As DevExpress.XtraEditors.GroupControl
		Private splitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
		Private gridControl3 As DevExpress.XtraGrid.GridControl
		Private gridViewBindingList As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView6 As DevExpress.XtraGrid.Views.Grid.GridView
		Private groupControl4 As DevExpress.XtraEditors.GroupControl
		Private gridControl4 As DevExpress.XtraGrid.GridControl
		Private gridViewFilteredBindingList As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView8 As DevExpress.XtraGrid.Views.Grid.GridView
		Private filteredDataSourceHelper_BindingList As FilteredDataSourceHelperComponent
		Private filteredDataSource_BindingList As System.Windows.Forms.BindingSource

	End Class
End Namespace

