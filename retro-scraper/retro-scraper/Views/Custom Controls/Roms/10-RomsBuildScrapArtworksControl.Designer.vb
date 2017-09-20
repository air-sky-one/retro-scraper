<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _10_RomsBuildScrapArtworksControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_10_RomsBuildScrapArtworksControl))
        Me.ActionFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CollaspeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'ActionFlowLayoutPanel
        '
        Me.ActionFlowLayoutPanel.AutoScroll = True
        Me.ActionFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActionFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.ActionFlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ActionFlowLayoutPanel.Name = "ActionFlowLayoutPanel"
        Me.ActionFlowLayoutPanel.Size = New System.Drawing.Size(878, 727)
        Me.ActionFlowLayoutPanel.TabIndex = 0
        Me.ActionFlowLayoutPanel.WrapContents = False
        '
        'CollaspeImageList
        '
        Me.CollaspeImageList.ImageStream = CType(resources.GetObject("CollaspeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.CollaspeImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.CollaspeImageList.Images.SetKeyName(0, "20x20 collapse-expand.png")
        Me.CollaspeImageList.Images.SetKeyName(1, "20x20 collapse-reduce.png")
        '
        '_10_RomsBuildScrapArtworksControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ActionFlowLayoutPanel)
        Me.Name = "_10_RomsBuildScrapArtworksControl"
        Me.Size = New System.Drawing.Size(878, 727)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ActionFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents CollaspeImageList As ImageList
End Class
