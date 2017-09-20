Public Class VisualControlsTestsForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.Button1.Tag.ToString = "expand" Then
            Me.Button1.Image = Me.ImageList1.Images(1)
            Me.Button1.Tag = "reduce"
        Else
            Me.Button1.Image = Me.ImageList1.Images(0)
            Me.Button1.Tag = "expand"
        End If
    End Sub

    Private Sub VisualControlsTestsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Button1.Image = Me.ImageList1.Images(0)
        Me.Button1.Tag = "expand"

        Me.Button2.Image = Me.ImageList1.Images(0)
        Me.Button2.Tag = "expand"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.Button2.Tag.ToString = "expand" Then
            Me.Button2.Image = Me.ImageList1.Images(1)
            Me.Button2.Tag = "reduce"
        Else
            Me.Button2.Image = Me.ImageList1.Images(0)
            Me.Button2.Tag = "expand"
        End If
    End Sub
End Class