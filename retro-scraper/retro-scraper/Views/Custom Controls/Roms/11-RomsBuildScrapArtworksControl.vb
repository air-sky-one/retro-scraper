Public Class _11_RomsBuildScrapArtworksControl

    ''' <summary>
    ''' Parent container control
    ''' </summary>
    Private _parent As RomsContainerControl

    ''' <summary>
    ''' List of grid view columns
    ''' </summary>
    Private _gridViewColumnsCollection As New List(Of DataGridViewCheckBoxColumn)

    ''' <summary>
    ''' Datagrid
    ''' </summary>
    ''' <returns></returns>
    Public Property Datagrid() As DataGridView
        Get
            Return Me.MainDataGridView
        End Get
        Set(ByVal value As DataGridView)
            Me.MainDataGridView = value
        End Set
    End Property

    ''' <summary>
    ''' Component initialization
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _11_RomsBuildScrapArtworksControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me._parent = TryCast(Me.Parent.Parent, RomsContainerControl)

            If Me._parent Is Nothing Then Throw New Exception("Unexpected error")

            Me.CheckboxFlowLayoutPanel.Visible = False
            Me.MainDataGridView.Visible = False

            Me.MediaTypesComboBox.DataSource = Me._parent.RomsArtworks.Select("AssociatedMediaType <> ''")
            Me.MediaTypesComboBox.SelectedIndex = -1

            Me.LabelMediaType.Visible = False
            Me.ButtonReset.Visible = False

            Me.IsmediascreenshotDataGridViewCheckBoxColumn.Visible = False
            Me.IsmediascreenshottitleDataGridViewCheckBoxColumn.Visible = False
            Me.IsmediafanartDataGridViewCheckBoxColumn.Visible = False
            Me.IsmediavideoDataGridViewCheckBoxColumn.Visible = False
            Me.IsmediawheelusDataGridViewCheckBoxColumn.Visible = False
            Me.IsmediawheeljpDataGridViewCheckBoxColumn.Visible = False
            Me.IsmediawheelworDataGridViewCheckBoxColumn.Visible = False
            Me.IsmediawheelcarbonusDataGridViewCheckBoxColumn.Visible = False
            Me.IsmediawheelcarbonjpDataGridViewCheckBoxColumn.Visible = False
            Me.IsmediawheelcarbonworDataGridViewCheckBoxColumn.Visible = False
            Me.IsmediawheelsteelusDataGridViewCheckBoxColumn.Visible = False
            Me.IsmediawheelsteeljpDataGridViewCheckBoxColumn.Visible = False
            Me.IsmediawheelsteelworDataGridViewCheckBoxColumn.Visible = False
            Me.IsmediaboxtextureusDataGridViewCheckBoxColumn.Visible = False
            Me.IsmediaboxtexturejpDataGridViewCheckBoxColumn.Visible = False
            Me.IsmediaboxtextureeuDataGridViewCheckBoxColumn.Visible = False
            Me.Ismediabox2dusDataGridViewCheckBoxColumn.Visible = False
            Me.Ismediabox2djpDataGridViewCheckBoxColumn.Visible = False
            Me.Ismediabox2deuDataGridViewCheckBoxColumn.Visible = False
            Me.Ismediabox2dsideusDataGridViewCheckBoxColumn.Visible = False
            Me.Ismediabox2dsidejpDataGridViewCheckBoxColumn.Visible = False
            Me.Ismediabox2dsideeuDataGridViewCheckBoxColumn.Visible = False
            Me.Ismediabox2dbackusDataGridViewCheckBoxColumn.Visible = False
            Me.Ismediabox2dbackjpDataGridViewCheckBoxColumn.Visible = False
            Me.Ismediabox2dbackeuDataGridViewCheckBoxColumn.Visible = False
            Me.Ismediabox3dusDataGridViewCheckBoxColumn.Visible = False
            Me.Ismediabox3djpDataGridViewCheckBoxColumn.Visible = False
            Me.Ismediabox3deuDataGridViewCheckBoxColumn.Visible = False
            Me.IsmediasupporttextureusDataGridViewCheckBoxColumn.Visible = False
            Me.IsmediasupporttexturejpDataGridViewCheckBoxColumn.Visible = False
            Me.IsmediasupporttextureeuDataGridViewCheckBoxColumn.Visible = False
            Me.Issmediaupport2dusDataGridViewCheckBoxColumn.Visible = False
            Me.Ismediasupport2djpDataGridViewCheckBoxColumn.Visible = False
            Me.Ismediasupport2deuDataGridViewCheckBoxColumn.Visible = False

            Me.IsmediascreenshotDataGridViewCheckBoxColumn.Tag = "media_screenshot"
            Me.IsmediascreenshottitleDataGridViewCheckBoxColumn.Tag = "media_screenshottitle"
            Me.IsmediafanartDataGridViewCheckBoxColumn.Tag = "media_fanart"
            Me.IsmediavideoDataGridViewCheckBoxColumn.Tag = "media_video"
            Me.IsmediawheelusDataGridViewCheckBoxColumn.Tag = "media_wheel_us"
            Me.IsmediawheeljpDataGridViewCheckBoxColumn.Tag = "media_wheel_jp"
            Me.IsmediawheelworDataGridViewCheckBoxColumn.Tag = "media_wheel_wor"
            Me.IsmediawheelcarbonusDataGridViewCheckBoxColumn.Tag = "media_wheelcarbon_us"
            Me.IsmediawheelcarbonjpDataGridViewCheckBoxColumn.Tag = "media_wheelcarbon_jp"
            Me.IsmediawheelcarbonworDataGridViewCheckBoxColumn.Tag = "media_wheelcarbon_wor"
            Me.IsmediawheelsteelusDataGridViewCheckBoxColumn.Tag = "media_wheelsteel_us"
            Me.IsmediawheelsteeljpDataGridViewCheckBoxColumn.Tag = "media_wheelsteel_jp"
            Me.IsmediawheelsteelworDataGridViewCheckBoxColumn.Tag = "media_wheelsteel_wor"
            Me.IsmediaboxtextureusDataGridViewCheckBoxColumn.Tag = "media_boxtexture_us"
            Me.IsmediaboxtexturejpDataGridViewCheckBoxColumn.Tag = "media_boxtexture_jp"
            Me.IsmediaboxtextureeuDataGridViewCheckBoxColumn.Tag = "media_boxtexture_eu"
            Me.Ismediabox2dusDataGridViewCheckBoxColumn.Tag = "media_box2d_us"
            Me.Ismediabox2djpDataGridViewCheckBoxColumn.Tag = "media_box2d_jp"
            Me.Ismediabox2deuDataGridViewCheckBoxColumn.Tag = "media_box2d_eu"
            Me.Ismediabox2dsideusDataGridViewCheckBoxColumn.Tag = "media_box2d_side_us"
            Me.Ismediabox2dsidejpDataGridViewCheckBoxColumn.Tag = "media_box2d_side_jp"
            Me.Ismediabox2dsideeuDataGridViewCheckBoxColumn.Tag = "media_box2d_side_eu"
            Me.Ismediabox2dbackusDataGridViewCheckBoxColumn.Tag = "media_box2d_back_us"
            Me.Ismediabox2dbackjpDataGridViewCheckBoxColumn.Tag = "media_box2d_back_jp"
            Me.Ismediabox2dbackeuDataGridViewCheckBoxColumn.Tag = "media_box2d_back_eu"
            Me.Ismediabox3dusDataGridViewCheckBoxColumn.Tag = "media_box3d_us"
            Me.Ismediabox3djpDataGridViewCheckBoxColumn.Tag = "media_box3d_jp"
            Me.Ismediabox3deuDataGridViewCheckBoxColumn.Tag = "media_box3d_eu"
            Me.IsmediasupporttextureusDataGridViewCheckBoxColumn.Tag = "media_supporttexture_us"
            Me.IsmediasupporttexturejpDataGridViewCheckBoxColumn.Tag = "media_supporttexture_jp"
            Me.IsmediasupporttextureeuDataGridViewCheckBoxColumn.Tag = "media_supporttexture_eu"
            Me.Issmediaupport2dusDataGridViewCheckBoxColumn.Tag = "media_support2d_us"
            Me.Ismediasupport2djpDataGridViewCheckBoxColumn.Tag = "media_support2d_jp"
            Me.Ismediasupport2deuDataGridViewCheckBoxColumn.Tag = "media_support2d_eu"

            Me._gridViewColumnsCollection.Add(Me.IsmediascreenshotDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.IsmediascreenshottitleDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.IsmediafanartDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.IsmediavideoDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.IsmediawheelusDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.IsmediawheeljpDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.IsmediawheelworDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.IsmediawheelcarbonusDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.IsmediawheelcarbonjpDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.IsmediawheelcarbonworDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.IsmediawheelsteelusDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.IsmediawheelsteeljpDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.IsmediawheelsteelworDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.IsmediaboxtextureusDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.IsmediaboxtexturejpDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.IsmediaboxtextureeuDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.Ismediabox2dusDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.Ismediabox2djpDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.Ismediabox2deuDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.Ismediabox2dsideusDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.Ismediabox2dsidejpDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.Ismediabox2dsideeuDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.Ismediabox2dbackusDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.Ismediabox2dbackjpDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.Ismediabox2dbackeuDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.Ismediabox3dusDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.Ismediabox3djpDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.Ismediabox3deuDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.IsmediasupporttextureusDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.IsmediasupporttexturejpDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.IsmediasupporttextureeuDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.Issmediaupport2dusDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.Ismediasupport2djpDataGridViewCheckBoxColumn)
            Me._gridViewColumnsCollection.Add(Me.Ismediasupport2deuDataGridViewCheckBoxColumn)

            Me.MainDataGridView.Visible = False
            Me.CheckboxFlowLayoutPanel.Visible = False

            Me.MainDataGridView.DataSource = Me._parent.RomsData.Select("IsChecked = 'True'")

            For Each c As CheckBox In Me.CheckboxFlowLayoutPanel.Controls
                AddHandler c.CheckedChanged, AddressOf SelectAllCheckBox_CheckedChanged
            Next
        Catch ex As Exception
            ShowErrorMessage(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Selection of media types
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MediaTypesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MediaTypesComboBox.SelectedIndexChanged
        If CType(sender, ComboBox).SelectedValue IsNot Nothing Then

            Dim name As String = CType(sender, ComboBox).SelectedValue
            'CType(CType(CType(sender, ComboBox).SelectedValue, DataRowView).Row, RomsDataSet.ArtworksRow).Name
            
            Me.LabelMediaType.Text = "Screenscraper media type : " & name
            Me.LabelMediaType.Visible = True
            Me.ButtonReset.Visible = True

            Select Case name
                Case "Screenshots"
                    SetCheckboxColumnsVisibility(New List(Of DataGridViewCheckBoxColumn) From {IsmediascreenshotDataGridViewCheckBoxColumn, IsmediascreenshottitleDataGridViewCheckBoxColumn})
                    SetSelectAllCheckboxVisibility(New List(Of CheckBox) From {ckScreenShotInGame, ckScreenShotTitle})
                Case "Fanarts"
                    SetCheckboxColumnsVisibility(New List(Of DataGridViewCheckBoxColumn) From {IsmediafanartDataGridViewCheckBoxColumn})
                    SetSelectAllCheckboxVisibility(New List(Of CheckBox) From {ckFanart})
                Case "Video"
                    SetCheckboxColumnsVisibility(New List(Of DataGridViewCheckBoxColumn) From {IsmediavideoDataGridViewCheckBoxColumn})
                    SetSelectAllCheckboxVisibility(New List(Of CheckBox) From {ckVideo})
                Case "Wheels"
                    SetCheckboxColumnsVisibility(New List(Of DataGridViewCheckBoxColumn) From {Me.IsmediawheelusDataGridViewCheckBoxColumn, Me.IsmediawheeljpDataGridViewCheckBoxColumn, Me.IsmediawheelworDataGridViewCheckBoxColumn})
                    SetSelectAllCheckboxVisibility(New List(Of CheckBox) From {ckWheelUS, ckWheelJP, ckWheelWOR})
                Case "Carbon Wheels"
                    SetCheckboxColumnsVisibility(New List(Of DataGridViewCheckBoxColumn) From {Me.IsmediawheelcarbonusDataGridViewCheckBoxColumn, Me.IsmediawheelcarbonjpDataGridViewCheckBoxColumn, Me.IsmediawheelcarbonworDataGridViewCheckBoxColumn})
                    SetSelectAllCheckboxVisibility(New List(Of CheckBox) From {ckWheelCarbonUS, ckWheelCarbonJP, ckWheelCarbonWOR})
                Case "Steel Wheels"
                    SetCheckboxColumnsVisibility(New List(Of DataGridViewCheckBoxColumn) From {Me.IsmediawheelsteelusDataGridViewCheckBoxColumn, Me.IsmediawheelsteeljpDataGridViewCheckBoxColumn, Me.IsmediawheelsteelworDataGridViewCheckBoxColumn})
                    SetSelectAllCheckboxVisibility(New List(Of CheckBox) From {ckWheelSteelUS, ckWheelSteelJP, ckWheelSteelWOR})
                Case "Box Textures (all sides of the jacket)"
                    SetCheckboxColumnsVisibility(New List(Of DataGridViewCheckBoxColumn) From {Me.IsmediaboxtextureusDataGridViewCheckBoxColumn, Me.IsmediaboxtexturejpDataGridViewCheckBoxColumn, Me.IsmediaboxtextureeuDataGridViewCheckBoxColumn})
                    SetSelectAllCheckboxVisibility(New List(Of CheckBox) From {ckBoxTextureUS, ckBoxTextureJP, ckBoxTextureEU})
                Case "Box 2D (Front side of the jacket)"
                    SetCheckboxColumnsVisibility(New List(Of DataGridViewCheckBoxColumn) From {Me.Ismediabox2dusDataGridViewCheckBoxColumn, Me.Ismediabox2djpDataGridViewCheckBoxColumn, Me.Ismediabox2deuDataGridViewCheckBoxColumn})
                    SetSelectAllCheckboxVisibility(New List(Of CheckBox) From {ckBox2dUS, ckBox2dJP, ckBox2dEU})
                Case "Box 2D Side"
                    SetCheckboxColumnsVisibility(New List(Of DataGridViewCheckBoxColumn) From {Me.Ismediabox2dsideusDataGridViewCheckBoxColumn, Me.Ismediabox2dsidejpDataGridViewCheckBoxColumn, Me.Ismediabox2dsideeuDataGridViewCheckBoxColumn})
                    SetSelectAllCheckboxVisibility(New List(Of CheckBox) From {ckBox2dSideUS, ckBox2dSideJP, ckBox2dSideEU})
                Case "Box 2D Back"
                    SetCheckboxColumnsVisibility(New List(Of DataGridViewCheckBoxColumn) From {Me.Ismediabox2dbackusDataGridViewCheckBoxColumn, Me.Ismediabox2dbackjpDataGridViewCheckBoxColumn, Me.Ismediabox2dbackeuDataGridViewCheckBoxColumn})
                    SetSelectAllCheckboxVisibility(New List(Of CheckBox) From {ckBox2dBackUS, ckBox2dBackJP, ckBox2dBackEU})
                Case "Box 3D"
                    SetCheckboxColumnsVisibility(New List(Of DataGridViewCheckBoxColumn) From {Me.Ismediabox3dusDataGridViewCheckBoxColumn, Me.Ismediabox3djpDataGridViewCheckBoxColumn, Me.Ismediabox3deuDataGridViewCheckBoxColumn})
                    SetSelectAllCheckboxVisibility(New List(Of CheckBox) From {ckBox3dUS, ckBox3dJP, ckBox3dEU})
                Case "Support Texture (Cartridge label)"
                    SetCheckboxColumnsVisibility(New List(Of DataGridViewCheckBoxColumn) From {Me.IsmediasupporttextureusDataGridViewCheckBoxColumn, Me.IsmediasupporttexturejpDataGridViewCheckBoxColumn, Me.IsmediasupporttextureeuDataGridViewCheckBoxColumn})
                    SetSelectAllCheckboxVisibility(New List(Of CheckBox) From {ckSupportTextureUS, ckSupportTextureJP, ckSupportTextureEU})
                Case "Support 2D (Cartridge)"
                    SetCheckboxColumnsVisibility(New List(Of DataGridViewCheckBoxColumn) From {Me.Issmediaupport2dusDataGridViewCheckBoxColumn, Me.Ismediasupport2djpDataGridViewCheckBoxColumn, Me.Ismediasupport2deuDataGridViewCheckBoxColumn})
                    SetSelectAllCheckboxVisibility(New List(Of CheckBox) From {ckSupport2dUS, ckSupport2dJP, ckSupport2dEU})
                Case Else
            End Select

            Me.MainDataGridView.Refresh()

        End If

    End Sub

    ''' <summary>
    ''' Set the checkbox datagrid columns (in)visible
    ''' </summary>
    ''' <param name="params"></param>
    Private Sub SetCheckboxColumnsVisibility(params As List(Of DataGridViewCheckBoxColumn))
        For Each c As DataGridViewCheckBoxColumn In Me._gridViewColumnsCollection
            c.Visible = False
            For Each param As DataGridViewCheckBoxColumn In params
                If c.Equals(param) Then
                    c.Visible = True
                    Exit For
                End If
            Next
        Next

        If Not Me.MainDataGridView.Visible Then Me.MainDataGridView.Visible = True
    End Sub

    ''' <summary>
    ''' Set the select all checkbox (in)visible
    ''' </summary>
    ''' <param name="params"></param>
    Private Sub SetSelectAllCheckboxVisibility(params As List(Of CheckBox))
        For Each c As CheckBox In Me.CheckboxFlowLayoutPanel.Controls
            c.Visible = False
            For Each param As CheckBox In params
                If c.Equals(param) Then
                    c.Visible = True
                    Exit For
                End If
            Next
        Next

        If Not Me.CheckboxFlowLayoutPanel.Visible Then Me.CheckboxFlowLayoutPanel.Visible = True
    End Sub

    ''' <summary>
    ''' Select All games for the desired media
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectAllCheckBox_CheckedChanged(sender As Object, e As EventArgs)
        Dim ck As CheckBox = CType(sender, CheckBox)

        Select Case ck.Name
            Case "ckScreenShotInGame"
                SelectAllDataColumn("is_media_screenshot", New List(Of String) From {"is_media_screenshottitle"}, ck.Checked)
            Case "ckScreenShotTitle"
                SelectAllDataColumn("is_media_screenshottitle", New List(Of String) From {"is_media_screenshot"}, ck.Checked)
            Case "ckFanart"
                SelectAllDataColumn("is_media_fanart", New List(Of String), ck.Checked)
            Case "ckVideo"
                SelectAllDataColumn("is_media_video", New List(Of String), ck.Checked)
            Case "ckWheelUS"
                SelectAllDataColumn("is_media_wheel_us", New List(Of String) From {"is_media_wheel_jp", "is_media_wheel_wor"}, ck.Checked)
            Case "ckWheelJP"
                SelectAllDataColumn("is_media_wheel_jp", New List(Of String) From {"is_media_wheel_us", "is_media_wheel_wor"}, ck.Checked)
            Case "ckWheelWOR"
                SelectAllDataColumn("is_media_wheel_wor", New List(Of String) From {"is_media_wheel_us", "is_media_wheel_jp"}, ck.Checked)
            Case "ckWheelCarbonUS"
                SelectAllDataColumn("is_media_wheelcarbon_us", New List(Of String) From {"is_media_wheelcarbon_jp", "is_media_wheelcarbon_wor"}, ck.Checked)
            Case "ckWheelCarbonJP"
                SelectAllDataColumn("is_media_wheelcarbon_jp", New List(Of String) From {"is_media_wheelcarbon_us", "is_media_wheelcarbon_wor"}, ck.Checked)
            Case "ckWheelCarbonWOR"
                SelectAllDataColumn("is_media_wheelcarbon_wor", New List(Of String) From {"is_media_wheelcarbon_us", "is_media_wheelcarbon_jp"}, ck.Checked)
            Case "ckWheelSteelUS"
                SelectAllDataColumn("is_media_wheelsteel_us", New List(Of String) From {"is_media_wheelsteel_jp", "is_media_wheelsteel_wor"}, ck.Checked)
            Case "ckWheelSteelJP"
                SelectAllDataColumn("is_media_wheelsteel_jp", New List(Of String) From {"is_media_wheelsteel_us", "is_media_wheelsteel_wor"}, ck.Checked)
            Case "ckWheelSteelWOR"
                SelectAllDataColumn("is_media_wheelsteel_wor", New List(Of String) From {"is_media_wheelsteel_us", "is_media_wheelsteel_jp"}, ck.Checked)
            Case "ckBoxTextureUS"
                SelectAllDataColumn("is_media_boxtexture_us", New List(Of String) From {"is_media_boxtexture_jp", "is_media_boxtexture_eu"}, ck.Checked)
            Case "ckBoxTextureJP"
                SelectAllDataColumn("is_media_boxtexture_jp", New List(Of String) From {"is_media_boxtexture_us", "is_media_boxtexture_eu"}, ck.Checked)
            Case "ckBoxTextureEU"
                SelectAllDataColumn("is_media_boxtexture_eu", New List(Of String) From {"is_media_boxtexture_us", "is_media_boxtexture_jp"}, ck.Checked)
            Case "ckBox2dUS"
                SelectAllDataColumn("is_media_box2d_us", New List(Of String) From {"is_media_box2d_jp", "is_media_box2d_eu"}, ck.Checked)
            Case "ckBox2dJP"
                SelectAllDataColumn("is_media_box2d_jp", New List(Of String) From {"is_media_box2d_us", "is_media_box2d_eu"}, ck.Checked)
            Case "ckBox2dEU"
                SelectAllDataColumn("is_media_box2d_eu", New List(Of String) From {"is_media_box2d_us", "is_media_box2d_jp"}, ck.Checked)
            Case "ckBox2dSideUS"
                SelectAllDataColumn("is_media_box2d_side_us", New List(Of String) From {"is_media_box2d_side_jp", "is_media_box2d_side_eu"}, ck.Checked)
            Case "ckBox2dSideJP"
                SelectAllDataColumn("is_media_box2d_side_jp", New List(Of String) From {"is_media_box2d_side_us", "is_media_box2d_side_eu"}, ck.Checked)
            Case "ckBox2dSideEU"
                SelectAllDataColumn("is_media_box2d_side_eu", New List(Of String) From {"is_media_box2d_side_us", "is_media_box2d_side_jp"}, ck.Checked)
            Case "ckBox2dBackUS"
                SelectAllDataColumn("is_media_box2d_back_us", New List(Of String) From {"is_media_box2d_back_jp", "is_media_box2d_back_eu"}, ck.Checked)
            Case "ckBox2dBackJP"
                SelectAllDataColumn("is_media_box2d_back_jp", New List(Of String) From {"is_media_box2d_back_us", "is_media_box2d_back_eu"}, ck.Checked)
            Case "ckBox2dBackEU"
                SelectAllDataColumn("is_media_box2d_back_eu", New List(Of String) From {"is_media_box2d_back_us", "is_media_box2d_back_jp"}, ck.Checked)
            Case "ckBox3dUS"
                SelectAllDataColumn("is_media_box3d_us", New List(Of String) From {"is_media_box3d_jp", "is_media_box3d_eu"}, ck.Checked)
            Case "ckBox3dJP"
                SelectAllDataColumn("is_media_box3d_jp", New List(Of String) From {"is_media_box3d_us", "is_media_box3d_eu"}, ck.Checked)
            Case "ckBox3dEU"
                SelectAllDataColumn("is_media_box3d_eu", New List(Of String) From {"is_media_box3d_us", "is_media_box3d_jp"}, ck.Checked)
            Case "ckSupportTextureUS"
                SelectAllDataColumn("is_media_supporttexture_us", New List(Of String) From {"is_media_supporttexture_jp", "is_media_supporttexture_eu"}, ck.Checked)
            Case "ckSupportTextureJP"
                SelectAllDataColumn("is_media_supporttexture_jp", New List(Of String) From {"is_media_supporttexture_us", "is_media_supporttexture_eu"}, ck.Checked)
            Case "ckSupportTextureEU"
                SelectAllDataColumn("is_media_supporttexture_eu", New List(Of String) From {"is_media_supporttexture_us", "is_media_supporttexture_jp"}, ck.Checked)
            Case "ckSupport2dUS"
                SelectAllDataColumn("is_media_support2d_us", New List(Of String) From {"is_media_support2d_jp", "is_media_support2d_eu"}, ck.Checked)
            Case "ckSupport2dJP"
                SelectAllDataColumn("is_media_support2d_jp", New List(Of String) From {"is_media_support2d_us", "is_media_support2d_eu"}, ck.Checked)
            Case "ckSupport2dEU"
                SelectAllDataColumn("is_media_support2d_eu", New List(Of String) From {"is_media_support2d_us", "is_media_support2d_jp"}, ck.Checked)
            Case Else
        End Select
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="colName"></param>
    ''' <param name="associatedColumnsNames"></param>
    ''' <param name="value"></param>
    Private Sub SelectAllDataColumn(colName As String, associatedColumnsNames As List(Of String), value As Boolean)
        For Each g As RomsDataSet.SSRomsRow In Me._parent.RomsData.Select("IsChecked = 'True'")
            Dim indexValue As Integer
            Dim dontTouch As Boolean = False

            indexValue = Me._parent.RomsData.Columns(colName).Ordinal + 1

            If Not String.IsNullOrEmpty(g(indexValue).ToString) Then
                g(colName) = value
            Else
                g(colName) = False
                dontTouch = True
            End If

            If value Then
                For Each associatedCol As String In associatedColumnsNames
                    If Not dontTouch Then g(associatedCol) = False
                Next
            End If
        Next

        Me.MainDataGridView.Refresh()
    End Sub

    ''' <summary>
    ''' Format datagrid cells when no data are available on screenscraper.fr
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MainDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MainDataGridView.CellFormatting
        Me.MainDataGridView.SuspendLayout()

        If e.ColumnIndex > 0 Then
            If Me.MainDataGridView.Columns(e.ColumnIndex).Visible Then
                Dim datagridViewColTag As String = Me.MainDataGridView.Columns(e.ColumnIndex).Tag.ToString

                Dim i As Integer = Me._parent.RomsData.Columns(datagridViewColTag).Ordinal

                If String.IsNullOrEmpty(Me._parent.RomsData(e.RowIndex)(i).ToString) Then
                    Me.MainDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = True
                    e.CellStyle.ForeColor = Color.IndianRed
                    e.CellStyle.BackColor = Color.IndianRed
                End If
            End If
        End If

        Me.MainDataGridView.ResumeLayout()
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        For Each g As RomsDataSet.SSRomsRow In Me._parent.RomsData.Select("IsChecked = 'True'")
            g.is_media_screenshot = False
            g.is_media_screenshottitle = False
            g.is_media_fanart = False
            g.is_media_video = False
            g.is_media_wheel_us = False
            g.is_media_wheel_jp = False
            g.is_media_wheel_wor = False
            g.is_media_wheelcarbon_us = False
            g.is_media_wheelcarbon_jp = False
            g.is_media_wheelcarbon_wor = False
            g.is_media_wheelsteel_us = False
            g.is_media_wheelsteel_jp = False
            g.is_media_wheelsteel_wor = False
            g.is_media_boxtexture_us = False
            g.is_media_boxtexture_jp = False
            g.is_media_boxtexture_eu = False
            g.is_media_box2d_us = False
            g.is_media_box2d_jp = False
            g.is_media_box2d_eu = False
            g.is_media_box2d_side_us = False
            g.is_media_box2d_side_jp = False
            g.is_media_box2d_side_eu = False
            g.is_media_box2d_back_us = False
            g.is_media_box2d_back_jp = False
            g.is_media_box2d_back_eu = False
            g.is_media_box3d_us = False
            g.is_media_box3d_jp = False
            g.is_media_box3d_eu = False
            g.is_media_supporttexture_us = False
            g.is_media_supporttexture_jp = False
            g.is_media_supporttexture_eu = False
            g.is_media_support2d_us = False
            g.is_media_support2d_jp = False
            g.is_media_support2d_eu = False
        Next

        Me.MainDataGridView.Refresh()
    End Sub
End Class
