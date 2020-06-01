Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form

		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i Mod 30), i, 3 - i Mod 40, DateTime.Now.AddDays(i Mod 10) })
			Next i
			Return tbl
		End Function

		Private Function CreateCollectionDataSouce(ByVal rowCount As Integer) As Object
			Dim bl As New BindingList(Of Customer)()

			For i As Integer = 0 To rowCount - 1
				bl.Add(New Customer With {
					.FirstName = String.Format("FirstName{0}", i Mod 30),
					.LastName = String.Format("FirstName{0}", i Mod 30),
					.ID=i
				})
			Next i
			Return bl
		End Function
		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = CreateTable(200)
			gridControl3.DataSource = CreateCollectionDataSouce(200)
		End Sub


	End Class
End Namespace
