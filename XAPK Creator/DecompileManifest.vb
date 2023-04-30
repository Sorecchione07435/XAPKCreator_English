Public Class DecompileManifest

    Private Sub DecompileManifest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function runCMD(ByVal Arguments As String) As String
        Try

            Dim My_Process As New Process()
            Dim My_Process_Info As New ProcessStartInfo()

            My_Process_Info.FileName = "axmldec.exe" ' Process filename
            My_Process_Info.Arguments = Arguments ' Process arguments
            My_Process_Info.WorkingDirectory = Application.StartupPath
            My_Process_Info.CreateNoWindow = True  ' Show or hide the process Window
            My_Process_Info.UseShellExecute = False ' Don't use system shell to execute the process
            My_Process_Info.RedirectStandardOutput = True  '  Redirect (1) Output
            My_Process_Info.RedirectStandardError = True  ' Redirect non (1) Output

            My_Process.EnableRaisingEvents = True ' Raise events
            My_Process.StartInfo = My_Process_Info
            My_Process.Start() ' Run the process NOW

            Dim Process_ErrorOutput As String = My_Process.StandardOutput.ReadToEnd() ' Stores the Error Output (If any)
            Dim Process_StandardOutput As String = My_Process.StandardOutput.ReadToEnd() ' Stores the Standard Output (If any)

            ' Return output by priority
            If Process_ErrorOutput IsNot Nothing Then Return Process_ErrorOutput ' Returns the ErrorOutput (if any)
            If Process_StandardOutput IsNot Nothing Then Return Process_StandardOutput ' Returns the StandardOutput (if any)

        Catch ex As Exception
            Return ex.Message
        End Try

        Return "OK"

    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = Nothing Then
            MsgBox("Enter the Android Manifest Path", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        ElseIf TextBox2.Text = Nothing Then
            MsgBox("Enter the Android Manifest Decrypted Path", MsgBoxStyle.Exclamation, "Warning") : Exit Sub
        End If

        runCMD(String.Format("-o ""{0}"" ""{1}""", TextBox2.Text, TextBox1.Text))
        MsgBox("AndroidManifest.xml Decrypted Successfully!", MsgBoxStyle.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
            TextBox2.Text = IO.Path.GetDirectoryName(OpenFileDialog1.FileName) & "\AndroidManifestDecrypted.xml"
        End If
    End Sub
End Class