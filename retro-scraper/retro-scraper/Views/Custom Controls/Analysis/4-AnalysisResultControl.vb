Imports System.ComponentModel
Imports System.IO
Imports System.Text

Public Class _4_AnalysisResultControl

    ''' <summary>
    ''' Parent con tainer control
    ''' </summary>
    Private _parent As AnalysisContainerControl

    ''' <summary>
    ''' Component initialization
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _4_AnalysisResultControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me._parent = TryCast(Me.Parent.Parent, AnalysisContainerControl)

            If Me._parent Is Nothing Then Throw New Exception("Unexpected error")

            Me.ContentDataGridView.DataSource = Me._parent.RomsData

            Me.ContentDataGridView.Sort(Me.ContentDataGridView.Columns(0), ListSortDirection.Ascending)

            Me._parent.ButtonNext.Visible = False
            Me._parent.ButtonPrevious.Visible = False

        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Format datagrid cells when no media are present
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ContentDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ContentDataGridView.CellFormatting
        Me.ContentDataGridView.SuspendLayout()

        Me.ContentDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = True

        If e.ColumnIndex > 0 Then
            If (Me.ContentDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)).Value.ToString.Equals("False") Then
                e.CellStyle.ForeColor = Color.IndianRed
                e.CellStyle.BackColor = Color.IndianRed
            Else
                e.CellStyle.ForeColor = Color.White
                e.CellStyle.BackColor = Color.White
            End If
        End If

        Me.ContentDataGridView.ResumeLayout()
    End Sub

End Class
