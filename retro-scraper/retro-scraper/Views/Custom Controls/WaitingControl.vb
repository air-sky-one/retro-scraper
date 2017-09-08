Public Class WaitingControl

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Me._waitingLabel.Text = String.Empty
        Me._detailsTextBox.Text = String.Empty

    End Sub

    ''' <summary>
    ''' Get or Set the Waiting Header Label 
    ''' </summary>
    Public Property WaitingTitle() As Label
        Get
            Return Me._waitingLabel
        End Get
        Set(ByVal value As Label)
            Me._waitingLabel = value
        End Set
    End Property

    ''' <summary>
    ''' Get or Set the progresBar
    ''' </summary>
    ''' <returns></returns>
    Public Property WaitingProgressBar() As ProgressBar
        Get
            Return Me._waitingProgressBar
        End Get
        Set(ByVal value As ProgressBar)
            Me._waitingProgressBar = value
        End Set
    End Property

    ''' <summary>
    ''' Get or Set the details text
    ''' </summary>
    ''' <returns></returns>
    Public Property DetailsText() As TextBox
        Get
            Return Me._detailsTextBox
        End Get
        Set(ByVal value As TextBox)
            Me._detailsTextBox = value
        End Set
    End Property

End Class
