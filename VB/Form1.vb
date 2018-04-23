Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository

Namespace SetPopupSize
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub gridLookUpEdit1_QueryPopUp(ByVal sender As Object, ByVal e As CancelEventArgs) Handles gridLookUpEdit1.QueryPopUp
			Dim editor As GridLookUpEdit = CType(sender, GridLookUpEdit)
			Dim properties As RepositoryItemGridLookUpEdit = editor.Properties
			properties.PopupFormSize = New Size(editor.Width - 4, properties.PopupFormSize.Height)
		End Sub
	End Class
End Namespace
