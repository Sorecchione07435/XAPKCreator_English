Imports System.IO.Compression


Public Class Form1
    Public ApplicationPackageName As String
    Public ApplicationName As String
    Public ApplicationVerCode, ApplicationMinSDKV, ApplicationTargetSDKV As Long
    Public ApplicationVersionName As String
    Public XAPKIconPath As String
    Public XAPKPermissions As String

    Public APKPath As String

    Public MainOBBFile As String
    Public MainOBBInstallLocation As String
    Public MainOBBInstallPath As String

    Public PatchOBBFile As String
    Public PatchOBBInstallLocation As String
    Public PatchOBBInstallPath As String

    Public XAPKExportedName As String
    Public TotalXAPKSize As Long
    Public XAPKVersion As Integer
    Public XAPKCreationDir As String

    Dim OpenIcon As New OpenFileDialog

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApplicationVerCode.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Panel1.Enabled = True
        Else
            Panel1.Enabled = False
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnResetPermissions.Click
        TxtAndroidPermissionsList.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnAddPermission.Click
        If TxtAndroidPermissionsList.Text = Nothing Then
            TxtAndroidPermissionsList.Text = """" & TxtAndroidPermissionName.Text & """" & ","
        Else
            TxtAndroidPermissionsList.Text = TxtAndroidPermissionsList.Text & vbCrLf & """" & TxtAndroidPermissionName.Text & """" & ","
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles BtnAddLastPermission.Click
        If TxtAndroidPermissionsList.Text = Nothing Then
            TxtAndroidPermissionsList.Text = """" & TxtAndroidPermissionName.Text & """"
        Else
            TxtAndroidPermissionsList.Text = TxtAndroidPermissionsList.Text & vbCrLf & """" & TxtAndroidPermissionName.Text & """"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BrowseAPKBtn.Click
        If TxtApplicationPackageName.Text = Nothing Then
            MsgBox("Before inserting the APK file of the application it is necessary to specify its package name", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        Dim fileAPK As New OpenFileDialog
        fileAPK.Filter = "Android Package Kit|*.apk"
        If fileAPK.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not fileAPK.FileName.EndsWith(TxtApplicationPackageName.Text & ".apk") = True Then
                MsgBox("The APK name must match the application package name for its APK to be recognized", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If
            TxtAPKPath.Text = fileAPK.FileName
        End If
    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TotalXAPKSizeinKylobytesTxt.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BtnBuildXAPK.Click
        If XAPKCreationDirTxt.Text = Nothing Then
            MsgBox("Specify the path to the folder where the XAPK will be created", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        ElseIf TxtApplicationPackageName.Text = Nothing Then
            MsgBox("Enter the application package name!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        ElseIf TxtApplicationName.Text = Nothing Then
            MsgBox("Enter the application name!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        ElseIf TxtApplicationVerCode.Text = Nothing Then
            MsgBox("Enter the application version code!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        ElseIf TxtApplicationVerName.Text = Nothing Then
            MsgBox("Enter the application version name!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        ElseIf MinimalSDKCombo.Text = Nothing Then
            MsgBox("Enter the application Minimal Sdk Version!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        ElseIf TargetSDKCombo.Text = Nothing Then
            MsgBox("Enter the application Target Sdk Version!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        ElseIf TxtAndroidPermissionsList.Text = Nothing Then
            MsgBox("Enter at least one permission for the application!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        ElseIf TxtAPKPath.Text = Nothing Then
            MsgBox("Enter the application Apk file!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        End If

        If CheckBox1.Checked = True Then
            If TxtMainOBBFilePath.Text = Nothing Then
                MsgBox("Enter the application main obb file!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
            ElseIf MainOBBInstallLocationTxt.Text = Nothing Then
                MsgBox("Enter the application install location main obb file!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
            ElseIf MainOBBInstallPathTxt.Text = Nothing Then
                MsgBox("Enter the application install path main obb file!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
            End If

            If TxtPatchOBBFilePath.Text = Nothing Then
                MsgBox("Enter the application patch obb file!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
            ElseIf PatchOBBInstallLocationTxt.Text = Nothing Then
                MsgBox("Enter the application install location patch obb file!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
            ElseIf PatchOBBInstallPathTxt.Text = Nothing Then
                MsgBox("Enter the application install path patch obb file!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
            End If
        Else

            If TxtMainOBBFilePath.Text = Nothing Then
                MsgBox("Enter the application main obb file!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
            ElseIf MainOBBInstallLocationTxt.Text = Nothing Then
                MsgBox("Enter the application install location main obb file!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
            ElseIf MainOBBInstallPathTxt.Text = Nothing Then
                MsgBox("Enter the application install path main obb file!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
            End If
        End If

        If XAPKNameExportedTxt.Text = Nothing Then
            MsgBox("Enter the XAPK Exported name!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        ElseIf PictureBox1.Image Is Nothing Then
            MsgBox("Enter the XAPK Icon!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        ElseIf TotalXAPKSizeinKylobytesTxt.Text = Nothing Then
            MsgBox("Enter the XAPK Total Size!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        ElseIf XAPKVersionCombo.Text = Nothing Then
            MsgBox("Enter the XAPK Version!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        End If

        ApplicationPackageName = TxtApplicationPackageName.Text
        ApplicationName = TxtApplicationName.Text
        ApplicationVerCode = TxtApplicationVerCode.Text
        ApplicationVersionName = TxtApplicationVerName.Text
        ApplicationMinSDKV = MinimalSDKCombo.Text
        ApplicationTargetSDKV = TargetSDKCombo.Text
        XAPKPermissions = TxtAndroidPermissionsList.Text
        APKPath = TxtAPKPath.Text
        XAPKIconPath = OpenIcon.FileName

        If CheckBox1.Checked = True Then

            MainOBBFile = TxtMainOBBFilePath.Text
            MainOBBInstallLocation = MainOBBInstallLocationTxt.Text
            MainOBBInstallPath = MainOBBInstallPathTxt.Text

            PatchOBBFile = TxtPatchOBBFilePath.Text
            PatchOBBInstallLocation = PatchOBBInstallLocationTxt.Text
            PatchOBBInstallPath = PatchOBBInstallPathTxt.Text

        Else

            MainOBBFile = TxtMainOBBFilePath.Text
            MainOBBInstallLocation = MainOBBInstallLocationTxt.Text
            MainOBBInstallPath = MainOBBInstallPathTxt.Text

        End If

        XAPKExportedName = XAPKNameExportedTxt.Text
        TotalXAPKSize = TotalXAPKSizeinKylobytesTxt.Text
        XAPKVersion = XAPKVersionCombo.Text

        XAPKCreationDir = XAPKCreationDirTxt.Text
        If Not XAPKExportedName.EndsWith(".xapk") = True Then
            MsgBox("The file name must end with "".xapk""", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        End If


        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\XAPKs\" & XAPKExportedName) = True Then
            MsgBox("A previously created XAPK already has this name, use another name", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        End If

        MsgBox("The creation of the XAPK file is ready, Note!, the bigger the game resources are, the longer the creation will take, the program will freeze during creation" & vbCrLf & vbCrLf & "Press ""OK"" to continue", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Warning")

        'LblStatus.Text = "Copying Data..."
        My.Computer.FileSystem.CopyFile(Me.XAPKIconPath, Me.XAPKCreationDir & "\icon.png")
        My.Computer.FileSystem.CopyFile(Me.APKPath, Me.XAPKCreationDir & "\" & IO.Path.GetFileName(Me.APKPath))

        ' LblStatus.Text = "Creating Android OBB Folder..."

        MkDir(Me.XAPKCreationDir & "\Android\obb\" & Me.ApplicationPackageName)

        ' LblStatus.Text = "Copying Android Main OBB File... (It may take some time)"

        Dim OBBFileName As String = IO.Path.GetFileName(Me.MainOBBFile)
        My.Computer.FileSystem.CopyFile(Me.MainOBBFile, Me.XAPKCreationDir & "\Android\obb\" & Me.ApplicationPackageName & "\" & OBBFileName, True)

        If Me.CheckBox1.Checked = True Then
            'LblStatus.Text = "Copying Android Patch OBB File... (It may take some time)"

            Dim OBBFileName2 As String = IO.Path.GetFileName(Me.PatchOBBFile)
            My.Computer.FileSystem.CopyFile(Me.PatchOBBFile, Me.XAPKCreationDir & "\Android\obb\" & Me.ApplicationPackageName & "\" & OBBFileName2, True)


            ' LblStatus.Text = "Writing Manifest File..."


            Dim manifest1 As String

            manifest1 = "{" & vbCrLf & _
            """xapk_version"":" & Me.XAPKVersion & "," & vbCrLf & _
            """package_name"":" & """" & Me.ApplicationPackageName & """" & "," & vbCrLf & _
            """name"":" & "" & Me.ApplicationName & """" & "," & vbCrLf & _
            """version_code"":" & """" & Me.ApplicationVerCode & """" & "," & vbCrLf & _
            """version_name"":" & """" & Me.ApplicationVersionName & """" & "," & vbCrLf & _
            """min_sdk_version"":" & """" & Me.ApplicationMinSDKV & """" & "," & vbCrLf & _
            """target_sdk_version"":" & """" & Me.ApplicationTargetSDKV & """" & "," & vbCrLf & _
            """permissions"":[" & vbCrLf & _
            Me.XAPKPermissions & vbCrLf & _
            "]," & vbCrLf & _
            """total_size"":" & Me.TotalXAPKSize & "," & vbCrLf & _
            """expansions"":[" & vbCrLf & _
            "{" & vbCrLf & _
            """file"":" & """" & "Android/obb/" & ApplicationPackageName & "/" & IO.Path.GetFileName(Me.MainOBBFile) & """" & "," & vbCrLf & _
            """install_location"":" & """" & Me.MainOBBInstallLocation & """" & "," & vbCrLf & _
            """install_path"":" & """" & Me.MainOBBInstallPath & """" & vbCrLf & _
            "}," & vbCrLf & _
            "{" & vbCrLf & _
            """file"":" & """" & "Android/obb/" & ApplicationPackageName & "/" & IO.Path.GetFileName(Me.PatchOBBFile) & """" & "," & vbCrLf & _
            """install_location"":" & """" & Me.PatchOBBInstallLocation & """" & "," & vbCrLf & _
            """install_path"":" & """" & Me.PatchOBBInstallPath & """" & vbCrLf & _
            "}" & vbCrLf & _
            "]" & vbCrLf & _
            "}"






            My.Computer.FileSystem.WriteAllText(Me.XAPKCreationDir & "\manifest.json", manifest1, False)




        End If

        Dim manifest2 As String

        manifest2 = "{" & vbCrLf & _
          """xapk_version"":" & Me.XAPKVersion & "," & vbCrLf & _
          """package_name"":" & """" & Me.ApplicationPackageName & """" & "," & vbCrLf & _
          """name"":" & """" & Me.ApplicationName & """" & "," & vbCrLf & _
          """version_code"":" & """" & Me.ApplicationVerCode & """" & "," & vbCrLf & _
          """version_name"":" & """" & Me.ApplicationVersionName & """" & "," & vbCrLf & _
          """min_sdk_version"":" & """" & Me.ApplicationMinSDKV & """" & "," & vbCrLf & _
          """target_sdk_version"":" & """" & Me.ApplicationTargetSDKV & """" & "," & vbCrLf & _
          """permissions"":[" & vbCrLf & _
          Me.XAPKPermissions & vbCrLf & _
          "]," & vbCrLf & _
          """total_size"":" & Me.TotalXAPKSize & "," & vbCrLf & _
          """expansions"":[" & vbCrLf & _
          "{" & vbCrLf & _
          """file"":" & """" & "Android/obb/" & ApplicationPackageName & "/" & IO.Path.GetFileName(Me.MainOBBFile) & """" & "," & vbCrLf & _
          """install_location"":" & """" & Me.MainOBBInstallLocation & """" & "," & vbCrLf & _
          """install_path"":" & """" & Me.MainOBBInstallPath & """" & vbCrLf & _
          "}" & vbCrLf & _
          "]" & vbCrLf & _
          "}"


        My.Computer.FileSystem.WriteAllText(Me.XAPKCreationDir & "\manifest.json", manifest2, False)


        ' LblStatus.Text = "Writing Manifest File..."


        ' LblStatus.Text = "Compressing XAPK file..."
        ZipFile.CreateFromDirectory(Me.XAPKCreationDir, Application.StartupPath & "\XAPKs\" & Me.XAPKNameExportedTxt.Text)

        If CheckBox3.Checked = True Then
            My.Computer.FileSystem.DeleteDirectory(Me.XAPKCreationDir, FileIO.DeleteDirectoryOption.DeleteAllContents)

        End If
       
        MsgBox("XAPK Created Successfully!" & vbCrLf & "Stored in " & Application.StartupPath & "\XAPKs\" & Me.XAPKNameExportedTxt.Text, MsgBoxStyle.Information, "Success")


    End Sub

    Private Sub BrowseIconBtn_Click(sender As Object, e As EventArgs) Handles BrowseIconBtn.Click

        OpenIcon.Filter = "PNG Image|*.png"
        If OpenIcon.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = New Bitmap(OpenIcon.FileName)
        End If
    End Sub

    Private Sub DecryptAndroidManifestxmlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecryptAndroidManifestxmlToolStripMenuItem.Click
        DecompileManifest.Show()
    End Sub

    Private Sub XAPKCreationDirBrowseBtn_Click(sender As Object, e As EventArgs) Handles XAPKCreationDirBrowseBtn.Click
        Dim OpenDir As New FolderBrowserDialog
        If OpenDir.ShowDialog = Windows.Forms.DialogResult.OK Then
            XAPKCreationDirTxt.Text = OpenDir.SelectedPath
        End If
    End Sub

    Private Sub MainOBBFileBrowseBtn_Click(sender As Object, e As EventArgs) Handles MainOBBFileBrowseBtn.Click
        Dim MainOBBFile As New OpenFileDialog
        MainOBBFile.Filter = "Android OBB Resource|*.obb"
        If MainOBBFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not MainOBBFile.FileName.Contains(TxtApplicationPackageName.Text) = True Then
                MsgBox("The OBB file must contain the package name of the application", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
            ElseIf Not MainOBBFile.FileName.StartsWith("main") = False Then
                MsgBox("Enter a valid OBB main!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
            End If

            TxtMainOBBFilePath.Text = MainOBBFile.FileName
        End If
    End Sub

    Private Sub PatchOBBFileBrowseBtn_Click(sender As Object, e As EventArgs) Handles PatchOBBFileBrowseBtn.Click
        Dim PatchOBBFile As New OpenFileDialog
        PatchOBBFile.Filter = "Android OBB Resource|*.obb"
        If PatchOBBFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Not PatchOBBFile.FileName.Contains(TxtApplicationPackageName.Text) = True Then
                MsgBox("The OBB file must contain the package name of the application", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
            ElseIf Not PatchOBBFile.FileName.StartsWith("patch") = False Then
                MsgBox("Enter a valid OBB patch!", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
            End If

            TxtPatchOBBFilePath.Text = PatchOBBFile.FileName
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub WhatIsXAPKFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WhatIsXAPKFileToolStripMenuItem.Click
        Process.Start("https://comeaprire.com/extension/xapk")
    End Sub

    Private Sub AboutXAPKCreatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutXAPKCreatorToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TxtAndroidPermissionsList.ReadOnly = False
        Else
            TxtAndroidPermissionsList.ReadOnly = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start(Application.StartupPath & "\XAPKs")
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub
End Class