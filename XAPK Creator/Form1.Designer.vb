<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutXAPKCreatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhatIsXAPKFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecryptAndroidManifestxmlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtApplicationPackageName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtApplicationName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtApplicationVerCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtApplicationVerName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MinimalSDKCombo = New System.Windows.Forms.ComboBox()
        Me.TargetSDKCombo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BrowseIconBtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtAndroidPermissionName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnAddPermission = New System.Windows.Forms.Button()
        Me.BtnResetPermissions = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BtnAddLastPermission = New System.Windows.Forms.Button()
        Me.TxtAndroidPermissionsList = New System.Windows.Forms.TextBox()
        Me.BrowseAPKBtn = New System.Windows.Forms.Button()
        Me.TxtAPKPath = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PatchOBBFileBrowseBtn = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PatchOBBInstallPathTxt = New System.Windows.Forms.TextBox()
        Me.TxtPatchOBBFilePath = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PatchOBBInstallLocationTxt = New System.Windows.Forms.TextBox()
        Me.MainOBBInstallPathTxt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MainOBBInstallLocationTxt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MainOBBFileBrowseBtn = New System.Windows.Forms.Button()
        Me.TxtMainOBBFilePath = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TotalXAPKSizeinKylobytesTxt = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.XAPKVersionCombo = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.XAPKNameExportedTxt = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BtnBuildXAPK = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.XAPKCreationDirTxt = New System.Windows.Forms.TextBox()
        Me.XAPKCreationDirBrowseBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(726, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutXAPKCreatorToolStripMenuItem, Me.WhatIsXAPKFileToolStripMenuItem, Me.DecryptAndroidManifestxmlToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'AboutXAPKCreatorToolStripMenuItem
        '
        Me.AboutXAPKCreatorToolStripMenuItem.Name = "AboutXAPKCreatorToolStripMenuItem"
        Me.AboutXAPKCreatorToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.AboutXAPKCreatorToolStripMenuItem.Text = "About XAPK Creator"
        '
        'WhatIsXAPKFileToolStripMenuItem
        '
        Me.WhatIsXAPKFileToolStripMenuItem.Name = "WhatIsXAPKFileToolStripMenuItem"
        Me.WhatIsXAPKFileToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.WhatIsXAPKFileToolStripMenuItem.Text = "What is XAPK file?"
        '
        'DecryptAndroidManifestxmlToolStripMenuItem
        '
        Me.DecryptAndroidManifestxmlToolStripMenuItem.Name = "DecryptAndroidManifestxmlToolStripMenuItem"
        Me.DecryptAndroidManifestxmlToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.DecryptAndroidManifestxmlToolStripMenuItem.Text = "Decrypt AndroidManifest.xml"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Application Package Name:"
        '
        'TxtApplicationPackageName
        '
        Me.TxtApplicationPackageName.Location = New System.Drawing.Point(9, 32)
        Me.TxtApplicationPackageName.Name = "TxtApplicationPackageName"
        Me.TxtApplicationPackageName.Size = New System.Drawing.Size(233, 20)
        Me.TxtApplicationPackageName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Application Name:"
        '
        'TxtApplicationName
        '
        Me.TxtApplicationName.Location = New System.Drawing.Point(257, 32)
        Me.TxtApplicationName.Name = "TxtApplicationName"
        Me.TxtApplicationName.Size = New System.Drawing.Size(223, 20)
        Me.TxtApplicationName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(595, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "XAPK Icon"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(598, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Version Code:"
        '
        'TxtApplicationVerCode
        '
        Me.TxtApplicationVerCode.Location = New System.Drawing.Point(9, 84)
        Me.TxtApplicationVerCode.Name = "TxtApplicationVerCode"
        Me.TxtApplicationVerCode.Size = New System.Drawing.Size(60, 20)
        Me.TxtApplicationVerCode.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(115, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Version Name:"
        '
        'TxtApplicationVerName
        '
        Me.TxtApplicationVerName.Location = New System.Drawing.Point(118, 84)
        Me.TxtApplicationVerName.Name = "TxtApplicationVerName"
        Me.TxtApplicationVerName.Size = New System.Drawing.Size(100, 20)
        Me.TxtApplicationVerName.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(254, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Minimal SDK Version:"
        '
        'MinimalSDKCombo
        '
        Me.MinimalSDKCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MinimalSDKCombo.FormattingEnabled = True
        Me.MinimalSDKCombo.Items.AddRange(New Object() {"33", "32", "31", "30", "29", "28", "27", "26", "25", "24", "23", "22", "21", "20", "19", "18", "17", "16", "15", "14", "13", "12", "11", "10", "9"})
        Me.MinimalSDKCombo.Location = New System.Drawing.Point(257, 83)
        Me.MinimalSDKCombo.Name = "MinimalSDKCombo"
        Me.MinimalSDKCombo.Size = New System.Drawing.Size(121, 21)
        Me.MinimalSDKCombo.TabIndex = 12
        '
        'TargetSDKCombo
        '
        Me.TargetSDKCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TargetSDKCombo.FormattingEnabled = True
        Me.TargetSDKCombo.Items.AddRange(New Object() {"33", "32", "31", "30", "29", "28", "27", "26", "25", "24", "23", "22", "21", "20", "19", "18", "17", "16", "15", "14", "13", "12", "11", "10", "9"})
        Me.TargetSDKCombo.Location = New System.Drawing.Point(399, 84)
        Me.TargetSDKCombo.Name = "TargetSDKCombo"
        Me.TargetSDKCombo.Size = New System.Drawing.Size(121, 21)
        Me.TargetSDKCombo.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(396, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Target SDK Version:"
        '
        'BrowseIconBtn
        '
        Me.BrowseIconBtn.Location = New System.Drawing.Point(598, 106)
        Me.BrowseIconBtn.Name = "BrowseIconBtn"
        Me.BrowseIconBtn.Size = New System.Drawing.Size(85, 23)
        Me.BrowseIconBtn.TabIndex = 15
        Me.BrowseIconBtn.Text = "Browse..."
        Me.BrowseIconBtn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Application Permissions:"
        '
        'TxtAndroidPermissionName
        '
        Me.TxtAndroidPermissionName.Location = New System.Drawing.Point(12, 362)
        Me.TxtAndroidPermissionName.Name = "TxtAndroidPermissionName"
        Me.TxtAndroidPermissionName.Size = New System.Drawing.Size(268, 20)
        Me.TxtAndroidPermissionName.TabIndex = 18
        Me.TxtAndroidPermissionName.Text = "android.permission."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 346)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Permission Name:"
        '
        'BtnAddPermission
        '
        Me.BtnAddPermission.Location = New System.Drawing.Point(286, 360)
        Me.BtnAddPermission.Name = "BtnAddPermission"
        Me.BtnAddPermission.Size = New System.Drawing.Size(75, 23)
        Me.BtnAddPermission.TabIndex = 20
        Me.BtnAddPermission.Text = "Add"
        Me.BtnAddPermission.UseVisualStyleBackColor = True
        '
        'BtnResetPermissions
        '
        Me.BtnResetPermissions.Location = New System.Drawing.Point(448, 360)
        Me.BtnResetPermissions.Name = "BtnResetPermissions"
        Me.BtnResetPermissions.Size = New System.Drawing.Size(75, 23)
        Me.BtnResetPermissions.TabIndex = 21
        Me.BtnResetPermissions.Text = "Reset"
        Me.BtnResetPermissions.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.BtnAddLastPermission)
        Me.GroupBox1.Controls.Add(Me.TxtAndroidPermissionsList)
        Me.GroupBox1.Controls.Add(Me.BrowseAPKBtn)
        Me.GroupBox1.Controls.Add(Me.TxtAPKPath)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnResetPermissions)
        Me.GroupBox1.Controls.Add(Me.TxtApplicationPackageName)
        Me.GroupBox1.Controls.Add(Me.BtnAddPermission)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtApplicationName)
        Me.GroupBox1.Controls.Add(Me.TxtAndroidPermissionName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BrowseIconBtn)
        Me.GroupBox1.Controls.Add(Me.TxtApplicationVerCode)
        Me.GroupBox1.Controls.Add(Me.TargetSDKCombo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtApplicationVerName)
        Me.GroupBox1.Controls.Add(Me.MinimalSDKCombo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(702, 434)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Application Info"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(600, 349)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(80, 17)
        Me.CheckBox2.TabIndex = 29
        Me.CheckBox2.Text = "Enable Edit"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(161, 111)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(420, 13)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Most of this information you can get by decrypting the AndroidManifest.xml from t" & _
    "he APK"
        '
        'BtnAddLastPermission
        '
        Me.BtnAddLastPermission.Location = New System.Drawing.Point(367, 360)
        Me.BtnAddLastPermission.Name = "BtnAddLastPermission"
        Me.BtnAddLastPermission.Size = New System.Drawing.Size(75, 23)
        Me.BtnAddLastPermission.TabIndex = 27
        Me.BtnAddLastPermission.Text = "Add Last"
        Me.BtnAddLastPermission.UseVisualStyleBackColor = True
        '
        'TxtAndroidPermissionsList
        '
        Me.TxtAndroidPermissionsList.Location = New System.Drawing.Point(12, 131)
        Me.TxtAndroidPermissionsList.Multiline = True
        Me.TxtAndroidPermissionsList.Name = "TxtAndroidPermissionsList"
        Me.TxtAndroidPermissionsList.ReadOnly = True
        Me.TxtAndroidPermissionsList.Size = New System.Drawing.Size(671, 212)
        Me.TxtAndroidPermissionsList.TabIndex = 26
        '
        'BrowseAPKBtn
        '
        Me.BrowseAPKBtn.Location = New System.Drawing.Point(597, 392)
        Me.BrowseAPKBtn.Name = "BrowseAPKBtn"
        Me.BrowseAPKBtn.Size = New System.Drawing.Size(75, 23)
        Me.BrowseAPKBtn.TabIndex = 24
        Me.BrowseAPKBtn.Text = "Browse..."
        Me.BrowseAPKBtn.UseVisualStyleBackColor = True
        '
        'TxtAPKPath
        '
        Me.TxtAPKPath.Location = New System.Drawing.Point(123, 395)
        Me.TxtAPKPath.Name = "TxtAPKPath"
        Me.TxtAPKPath.ReadOnly = True
        Me.TxtAPKPath.Size = New System.Drawing.Size(468, 20)
        Me.TxtAPKPath.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 398)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Application APK File:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.MainOBBInstallPathTxt)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.MainOBBInstallLocationTxt)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.MainOBBFileBrowseBtn)
        Me.GroupBox2.Controls.Add(Me.TxtMainOBBFilePath)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 467)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(702, 254)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Application Additional Files"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PatchOBBFileBrowseBtn)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.PatchOBBInstallPathTxt)
        Me.Panel1.Controls.Add(Me.TxtPatchOBBFilePath)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.PatchOBBInstallLocationTxt)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(12, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(671, 100)
        Me.Panel1.TabIndex = 14
        '
        'PatchOBBFileBrowseBtn
        '
        Me.PatchOBBFileBrowseBtn.Location = New System.Drawing.Point(588, 6)
        Me.PatchOBBFileBrowseBtn.Name = "PatchOBBFileBrowseBtn"
        Me.PatchOBBFileBrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.PatchOBBFileBrowseBtn.TabIndex = 15
        Me.PatchOBBFileBrowseBtn.Text = "Browse..."
        Me.PatchOBBFileBrowseBtn.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Patch OBB File:"
        '
        'PatchOBBInstallPathTxt
        '
        Me.PatchOBBInstallPathTxt.Location = New System.Drawing.Point(90, 65)
        Me.PatchOBBInstallPathTxt.Name = "PatchOBBInstallPathTxt"
        Me.PatchOBBInstallPathTxt.Size = New System.Drawing.Size(263, 20)
        Me.PatchOBBInstallPathTxt.TabIndex = 13
        '
        'TxtPatchOBBFilePath
        '
        Me.TxtPatchOBBFilePath.Location = New System.Drawing.Point(86, 8)
        Me.TxtPatchOBBFilePath.Name = "TxtPatchOBBFilePath"
        Me.TxtPatchOBBFilePath.ReadOnly = True
        Me.TxtPatchOBBFilePath.Size = New System.Drawing.Size(496, 20)
        Me.TxtPatchOBBFilePath.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Install Path:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Install Location:"
        '
        'PatchOBBInstallLocationTxt
        '
        Me.PatchOBBInstallLocationTxt.Location = New System.Drawing.Point(90, 39)
        Me.PatchOBBInstallLocationTxt.Name = "PatchOBBInstallLocationTxt"
        Me.PatchOBBInstallLocationTxt.Size = New System.Drawing.Size(166, 20)
        Me.PatchOBBInstallLocationTxt.TabIndex = 11
        Me.PatchOBBInstallLocationTxt.Text = "EXTERNAL_STORAGE"
        '
        'MainOBBInstallPathTxt
        '
        Me.MainOBBInstallPathTxt.Location = New System.Drawing.Point(99, 118)
        Me.MainOBBInstallPathTxt.Name = "MainOBBInstallPathTxt"
        Me.MainOBBInstallPathTxt.Size = New System.Drawing.Size(263, 20)
        Me.MainOBBInstallPathTxt.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Install Path:"
        '
        'MainOBBInstallLocationTxt
        '
        Me.MainOBBInstallLocationTxt.Location = New System.Drawing.Point(99, 92)
        Me.MainOBBInstallLocationTxt.Name = "MainOBBInstallLocationTxt"
        Me.MainOBBInstallLocationTxt.Size = New System.Drawing.Size(166, 20)
        Me.MainOBBInstallLocationTxt.TabIndex = 5
        Me.MainOBBInstallLocationTxt.Text = "EXTERNAL_STORAGE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Install Location:"
        '
        'MainOBBFileBrowseBtn
        '
        Me.MainOBBFileBrowseBtn.Location = New System.Drawing.Point(598, 59)
        Me.MainOBBFileBrowseBtn.Name = "MainOBBFileBrowseBtn"
        Me.MainOBBFileBrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.MainOBBFileBrowseBtn.TabIndex = 3
        Me.MainOBBFileBrowseBtn.Text = "Browse..."
        Me.MainOBBFileBrowseBtn.UseVisualStyleBackColor = True
        '
        'TxtMainOBBFilePath
        '
        Me.TxtMainOBBFilePath.Location = New System.Drawing.Point(95, 61)
        Me.TxtMainOBBFilePath.Name = "TxtMainOBBFilePath"
        Me.TxtMainOBBFilePath.ReadOnly = True
        Me.TxtMainOBBFilePath.Size = New System.Drawing.Size(496, 20)
        Me.TxtMainOBBFilePath.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Main OBB File:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(15, 29)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(203, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "My application contains two OBB files"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TotalXAPKSizeinKylobytesTxt)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.XAPKVersionCombo)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.XAPKNameExportedTxt)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 727)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(702, 85)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "XAPK Configuration"
        '
        'TotalXAPKSizeinKylobytesTxt
        '
        Me.TotalXAPKSizeinKylobytesTxt.Location = New System.Drawing.Point(259, 47)
        Me.TotalXAPKSizeinKylobytesTxt.Name = "TotalXAPKSizeinKylobytesTxt"
        Me.TotalXAPKSizeinKylobytesTxt.Size = New System.Drawing.Size(221, 20)
        Me.TotalXAPKSizeinKylobytesTxt.TabIndex = 5
        Me.TotalXAPKSizeinKylobytesTxt.Text = "65536"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(256, 31)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(154, 13)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Total XAPK Size (In Kylobytes):"
        '
        'XAPKVersionCombo
        '
        Me.XAPKVersionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.XAPKVersionCombo.FormattingEnabled = True
        Me.XAPKVersionCombo.Items.AddRange(New Object() {"1", "2"})
        Me.XAPKVersionCombo.Location = New System.Drawing.Point(500, 46)
        Me.XAPKVersionCombo.Name = "XAPKVersionCombo"
        Me.XAPKVersionCombo.Size = New System.Drawing.Size(121, 21)
        Me.XAPKVersionCombo.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(497, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "XAPK Version:"
        '
        'XAPKNameExportedTxt
        '
        Me.XAPKNameExportedTxt.Location = New System.Drawing.Point(18, 47)
        Me.XAPKNameExportedTxt.Name = "XAPKNameExportedTxt"
        Me.XAPKNameExportedTxt.Size = New System.Drawing.Size(224, 20)
        Me.XAPKNameExportedTxt.TabIndex = 1
        Me.XAPKNameExportedTxt.Text = "app.xapk"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(114, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "XAPK Exported Name:"
        '
        'BtnBuildXAPK
        '
        Me.BtnBuildXAPK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuildXAPK.Location = New System.Drawing.Point(572, 836)
        Me.BtnBuildXAPK.Name = "BtnBuildXAPK"
        Me.BtnBuildXAPK.Size = New System.Drawing.Size(140, 36)
        Me.BtnBuildXAPK.TabIndex = 25
        Me.BtnBuildXAPK.Text = "Build XAPK"
        Me.BtnBuildXAPK.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 836)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 13)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "XAPK Creation Dir:"
        '
        'XAPKCreationDirTxt
        '
        Me.XAPKCreationDirTxt.Location = New System.Drawing.Point(18, 852)
        Me.XAPKCreationDirTxt.Name = "XAPKCreationDirTxt"
        Me.XAPKCreationDirTxt.ReadOnly = True
        Me.XAPKCreationDirTxt.Size = New System.Drawing.Size(292, 20)
        Me.XAPKCreationDirTxt.TabIndex = 27
        '
        'XAPKCreationDirBrowseBtn
        '
        Me.XAPKCreationDirBrowseBtn.Location = New System.Drawing.Point(316, 849)
        Me.XAPKCreationDirBrowseBtn.Name = "XAPKCreationDirBrowseBtn"
        Me.XAPKCreationDirBrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.XAPKCreationDirBrowseBtn.TabIndex = 28
        Me.XAPKCreationDirBrowseBtn.Text = "Browse..."
        Me.XAPKCreationDirBrowseBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(409, 849)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Open XAPKs Folder"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(320, 826)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(246, 17)
        Me.CheckBox3.TabIndex = 6
        Me.CheckBox3.Text = "Delete the folder with XAPK data after creation"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 885)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.XAPKCreationDirBrowseBtn)
        Me.Controls.Add(Me.XAPKCreationDirTxt)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.BtnBuildXAPK)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XAPK Creator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutXAPKCreatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WhatIsXAPKFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtApplicationPackageName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtApplicationName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtApplicationVerCode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtApplicationVerName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MinimalSDKCombo As System.Windows.Forms.ComboBox
    Friend WithEvents TargetSDKCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BrowseIconBtn As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtAndroidPermissionName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnAddPermission As System.Windows.Forms.Button
    Friend WithEvents BtnResetPermissions As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BrowseAPKBtn As System.Windows.Forms.Button
    Friend WithEvents TxtAPKPath As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MainOBBFileBrowseBtn As System.Windows.Forms.Button
    Friend WithEvents TxtMainOBBFilePath As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PatchOBBInstallPathTxt As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatchOBBFilePath As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PatchOBBInstallLocationTxt As System.Windows.Forms.TextBox
    Friend WithEvents MainOBBInstallPathTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents MainOBBInstallLocationTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TotalXAPKSizeinKylobytesTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents XAPKVersionCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents XAPKNameExportedTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BtnBuildXAPK As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents XAPKCreationDirTxt As System.Windows.Forms.TextBox
    Friend WithEvents XAPKCreationDirBrowseBtn As System.Windows.Forms.Button
    Friend WithEvents TxtAndroidPermissionsList As System.Windows.Forms.TextBox
    Friend WithEvents BtnAddLastPermission As System.Windows.Forms.Button
    Friend WithEvents PatchOBBFileBrowseBtn As System.Windows.Forms.Button
    Friend WithEvents DecryptAndroidManifestxmlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox

End Class
