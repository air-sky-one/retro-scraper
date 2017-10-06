<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DevToolsContainerControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.StepsProgressBar = New System.Windows.Forms.ProgressBar()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ActionFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.JSonToDataTableButton = New System.Windows.Forms.Button()
        Me.VisualControlsTestButton = New System.Windows.Forms.Button()
        Me.CheckAlreadyAvailableMediaButton = New System.Windows.Forms.Button()
        Me.MainTableLayoutPanel.SuspendLayout()
        Me.ActionFlowLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainTableLayoutPanel
        '
        Me.MainTableLayoutPanel.ColumnCount = 1
        Me.MainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTableLayoutPanel.Controls.Add(Me.StepsProgressBar, 0, 1)
        Me.MainTableLayoutPanel.Controls.Add(Me.HeaderLabel, 0, 0)
        Me.MainTableLayoutPanel.Controls.Add(Me.ActionFlowLayoutPanel, 0, 2)
        Me.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainTableLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MainTableLayoutPanel.Name = "MainTableLayoutPanel"
        Me.MainTableLayoutPanel.RowCount = 3
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.MainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainTableLayoutPanel.Size = New System.Drawing.Size(878, 787)
        Me.MainTableLayoutPanel.TabIndex = 0
        '
        'StepsProgressBar
        '
        Me.StepsProgressBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StepsProgressBar.Location = New System.Drawing.Point(0, 25)
        Me.StepsProgressBar.Margin = New System.Windows.Forms.Padding(0)
        Me.StepsProgressBar.Maximum = 8
        Me.StepsProgressBar.Name = "StepsProgressBar"
        Me.StepsProgressBar.Size = New System.Drawing.Size(878, 5)
        Me.StepsProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.StepsProgressBar.TabIndex = 1
        '
        'HeaderLabel
        '
        Me.HeaderLabel.BackColor = System.Drawing.Color.DarkOrange
        Me.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderLabel.Font = New System.Drawing.Font("Ubuntu Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HeaderLabel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.HeaderLabel.Size = New System.Drawing.Size(878, 25)
        Me.HeaderLabel.TabIndex = 0
        Me.HeaderLabel.Text = "Developper's Tool"
        Me.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ActionFlowLayoutPanel
        '
        Me.ActionFlowLayoutPanel.BackColor = System.Drawing.Color.White
        Me.ActionFlowLayoutPanel.Controls.Add(Me.JSonToDataTableButton)
        Me.ActionFlowLayoutPanel.Controls.Add(Me.VisualControlsTestButton)
        Me.ActionFlowLayoutPanel.Controls.Add(Me.CheckAlreadyAvailableMediaButton)
        Me.ActionFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ActionFlowLayoutPanel.Location = New System.Drawing.Point(3, 33)
        Me.ActionFlowLayoutPanel.Name = "ActionFlowLayoutPanel"
        Me.ActionFlowLayoutPanel.Size = New System.Drawing.Size(872, 751)
        Me.ActionFlowLayoutPanel.TabIndex = 2
        '
        'JSonToDataTableButton
        '
        Me.JSonToDataTableButton.AutoSize = True
        Me.JSonToDataTableButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JSonToDataTableButton.Location = New System.Drawing.Point(3, 3)
        Me.JSonToDataTableButton.Name = "JSonToDataTableButton"
        Me.JSonToDataTableButton.Size = New System.Drawing.Size(201, 26)
        Me.JSonToDataTableButton.TabIndex = 0
        Me.JSonToDataTableButton.Text = "Create DataTable from JSon Result "
        Me.JSonToDataTableButton.UseVisualStyleBackColor = True
        '
        'VisualControlsTestButton
        '
        Me.VisualControlsTestButton.AutoSize = True
        Me.VisualControlsTestButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VisualControlsTestButton.Location = New System.Drawing.Point(210, 3)
        Me.VisualControlsTestButton.Name = "VisualControlsTestButton"
        Me.VisualControlsTestButton.Size = New System.Drawing.Size(201, 26)
        Me.VisualControlsTestButton.TabIndex = 1
        Me.VisualControlsTestButton.Text = "Visual Controls Tests"
        Me.VisualControlsTestButton.UseVisualStyleBackColor = True
        '
        'CheckAlreadyAvailableMediaButton
        '
        Me.CheckAlreadyAvailableMediaButton.AutoSize = True
        Me.CheckAlreadyAvailableMediaButton.Font = New System.Drawing.Font("Ubuntu Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckAlreadyAvailableMediaButton.Location = New System.Drawing.Point(417, 3)
        Me.CheckAlreadyAvailableMediaButton.Name = "CheckAlreadyAvailableMediaButton"
        Me.CheckAlreadyAvailableMediaButton.Size = New System.Drawing.Size(201, 26)
        Me.CheckAlreadyAvailableMediaButton.TabIndex = 2
        Me.CheckAlreadyAvailableMediaButton.Text = "Check Already  Available Media"
        Me.CheckAlreadyAvailableMediaButton.UseVisualStyleBackColor = True
        '
        'DevToolsContainerControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.MainTableLayoutPanel)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "DevToolsContainerControl"
        Me.Size = New System.Drawing.Size(878, 787)
        Me.MainTableLayoutPanel.ResumeLayout(False)
        Me.ActionFlowLayoutPanel.ResumeLayout(False)
        Me.ActionFlowLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents StepsProgressBar As ProgressBar
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents ActionFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents JSonToDataTableButton As Button
    Friend WithEvents VisualControlsTestButton As Button
    Friend WithEvents CheckAlreadyAvailableMediaButton As Button
End Class
