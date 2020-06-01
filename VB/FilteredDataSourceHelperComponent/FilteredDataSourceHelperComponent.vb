Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections
Imports System.Windows.Forms

Namespace WindowsApplication1
	<System.ComponentModel.DesignerCategory("")>
	Public Class FilteredDataSourceHelperComponent
		Inherits Component

		' Fields...
		Private _FilteredDataSource As BindingSource
		Private _View As GridView


		Public Property View() As GridView
			Get
				Return _View
			End Get
			Set(ByVal value As GridView)
				Dim prevView As GridView = _View
				_View = value
				OnViewChanged(prevView, _View)
			End Set
		End Property



		Public Property FilteredDataSource() As BindingSource
			Get
				Return _FilteredDataSource
			End Get
			Set(ByVal value As BindingSource)
				_FilteredDataSource = value
			End Set
		End Property

		Private Sub OnViewChanged(ByVal oldValue As GridView, ByVal newValue As GridView)
			UnSubscribeEvents(oldValue)
			SubscribeEvents(newValue)
			UpdateFilteredSource()
		End Sub
		Private Sub UnSubscribeEvents(ByVal gridView As GridView)
			If gridView Is Nothing Then
				Return
			End If
			RemoveHandler gridView.DataSourceChanged, AddressOf gridView_DataSourceChanged
			RemoveHandler gridView.ColumnFilterChanged, AddressOf gridView_ColumnFilterChanged
		End Sub
		Private Sub SubscribeEvents(ByVal gridView As GridView)
			If gridView Is Nothing Then
				Return
			End If
			AddHandler gridView.DataSourceChanged, AddressOf gridView_DataSourceChanged
			AddHandler gridView.ColumnFilterChanged, AddressOf gridView_ColumnFilterChanged
		End Sub

		Private Sub gridView_ColumnFilterChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateFilteredSource()
		End Sub

		Private Sub gridView_DataSourceChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateFilteredSource()
		End Sub

		Private Sub UpdateFilteredSource()
			If _View Is Nothing OrElse _FilteredDataSource Is Nothing Then
				Return
			End If
			_FilteredDataSource.DataSource = _View.GetFilteredDataSource()
		End Sub
	End Class
End Namespace