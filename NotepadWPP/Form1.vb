Public Class Form1
	
	Dim openedfile As String = ""
	Dim changesmade As Boolean = False 
	Dim temp As String
	
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
    	changesmade = False
    	openedfile = ""
    	TextBox1.Text = ""
    	TextBox2.Text = ""
    	TextBox3.Text = ""
    	TextBox3.Tag = ""
    	Panel7.Hide()
    End Sub
        
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
    	On Error Resume Next
        OFD1.FileName = ""
        OFD1.ShowDialog()
        If OFD1.FileName <> "" Then
        	temp = System.IO.Path.GetExtension(OFD1.FileName).ToLower()
        	If temp = ".wrd" Or temp = ".rtf" Then
        		TextBox1.LoadFile(OFD1.FileName)
        	Else
        		LoadFileAsText(OFD1.FileName)
        	End If
        	changesmade = False
        	openedfile = OFD1.FileName
        End If
    End Sub
        
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
    	If openedfile <> "" Then
    		temp = System.IO.Path.GetExtension(openedfile).ToLower()
    		If temp = ".wrd" Or temp = ".rtf" Then
    			TextBox1.SaveFile(openedfile)
    		Else
    			SaveFileAsText(openedfile)
    		End If
    		changesmade = False
    	Else
    		Try
    			SFD1.FileName = ""
    			SFD1.ShowDialog()
    			If SFD1.FileName <> "" Then
    				temp = System.IO.Path.GetExtension(SFD1.FileName).ToLower()
    				If temp = ".wrd" Or temp  = ".rtf" Then
    					TextBox1.SaveFile(SFD1.FileName)
    				Else
    					SaveFileAsText(SFD1.FileName)
    				End If
    				changesmade = False
    				openedfile = SFD1.FileName
    			End If
    		Catch ex As Exception
    			Dim RETRY = MsgBox(Err.Description, MsgBoxStyle.Exclamation + MsgBoxStyle.RetryCancel)
    			If RETRY = vbRetry Then Call SaveToolStripMenuItem_Click(sender, e)
    		End Try
    	End If
    End Sub
    
    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Call Button7_Click(sender, e)
    End Sub
        
    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
    	TextBox1.SelectedText = "//------------------------------------------------"
    End Sub
        
    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Dim k As Integer = 0, k1 As Integer = 0, k2 As String = TextBox1.Text + Chr(13)
        While (k <> -1 And k1 <> -1 And k1 <= k2.Length)
            k = k2.IndexOf("//") : k1 = k2.IndexOf(Chr(13), k + 1)
            If k <> -1 And k1 <> -1 Then k2 = k2.Remove(k, k1 - k)
        End While
        k = 0 : k1 = 0
        While (k <> -1 And k1 <> -1 And k1 <= k2.Length)
            k = k2.IndexOf("/*") : k1 = k2.IndexOf("*/", k + 1)
            If k <> -1 And k1 <> -1 Then k2 = k2.Remove(k, k1 - k + 2)
        End While
        k2 = System.Text.RegularExpressions.Regex.Replace(k2, "^\s+$[\r\n]*", "", System.Text.RegularExpressions.RegexOptions.Multiline)
        TextBox1.Text = k2
    End Sub
        
    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        TextBox1.SelectAll()
    End Sub
        
    Private Sub WordWrapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordWrapToolStripMenuItem.Click
        TextBox1.WordWrap = WordWrapToolStripMenuItem.Checked
    End Sub
        
    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
    	If K.ShowDialog = Windows.Forms.DialogResult.OK Then TextBox1.Font = K.Font
    End Sub
        
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
    	MessageBox.Show("Word - Notepad" + vbNewLine + "Version 1.0" + vbNewLine + "Developer: Supriyo Saha", "About Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
          
    Private Sub TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = 13 Then Call Button7_Click(sender, e)
    End Sub
        
    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = 13 Then Call OK_Button_Click(sender, e)
    End Sub
        
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If TextBox3.Text <> "" Then
            Dim s As String = TextBox1.Text.Substring(Val(TextBox3.Tag), TextBox1.Text.Length - Val(TextBox3.Tag))
            Dim k As Integer = s.IndexOf(TextBox3.Text,StringComparison.OrdinalIgnoreCase)
            If TextBox3.Text <> "" And k <> -1 Then
                TextBox1.Focus()
                TextBox1.Select(k + Val(TextBox3.Tag), TextBox3.Text.Length)
                TextBox1.ScrollToCaret() : Button7.Focus()
                TextBox3.Tag = k + Val(TextBox3.Tag) + TextBox3.Text.Length
            Else
                MessageBox.Show("Cannot find " + Chr(34) + TextBox3.Text + Chr(34), My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox3.Tag = ""
            End If
        End If
    End Sub
        
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If TextBox3.Text <> "" Then
            TextBox3.Tag = ""
            TextBox1.Text = TextBox1.Text.Replace(TextBox3.Text, TextBox2.Text)
            MessageBox.Show("Successfully Replaced All Occurances.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
        
    Private Sub Cancel_ButtonClick(sender As Object, e As EventArgs)
    	TextBox2.Text = ""
    	TextBox3.Text = "" 
    	TextBox3.Tag = "" 
    	Panel7.Hide()
    End Sub
        
    Private Sub FindToolStripMenuItem1Click(sender As Object, e As EventArgs)
    	Panel7.Show
    	TextBox3.Focus
    End Sub  
        
    Private Sub ReplaceToolStripMenuItem1Click(sender As Object, e As EventArgs)
    	Panel7.Show  
    	TextBox3.Focus
    End Sub 
        
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If TextBox1.Text <> "" And changesmade = True  Then
            Dim k As Integer = MsgBox("Do you want to save changes to Document?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, My.Application.Info.Title)
            If k = vbCancel Then e.Cancel = True
            If k = vbYes Then Call SaveToolStripMenuItem_Click(sender, e)
        End If
    End Sub    
        
    Private Sub Form1DragDrop(sender As Object, e As DragEventArgs)
    	   Try
            Dim s() As String = e.Data.GetData(DataFormats.FileDrop)
            If s.Length - 1 = 0 Then
            	temp = System.IO.Path.GetExtension(s(s.Length - 1)).ToLower()
            	If temp = ".wrd" Or temp = ".rtf" Then
            		TextBox1.LoadFile(s(s.Length - 1))
            	Else
            		LoadFileAsText(s(s.Length - 1))
            	End If
            	changesmade = False
        		openedfile = s(s.Length - 1)
            End If
    	   Catch ex As Exception
    	   	MsgBox(Err.Description, MsgBoxStyle.Exclamation)
    	   End Try
    End Sub    
        
    Private Sub Form1DragEnter(sender As Object, e As DragEventArgs)
    	If e.Data.GetDataPresent(DataFormats.FileDrop) Then e.Effect = DragDropEffects.Copy
    End Sub
   
    Private Sub TextBox1KeyUp(sender As Object, e As KeyEventArgs)
    	changesmade = True
    End Sub     
    
    Private Sub ToolStripMenuItem1Click(sender As Object, e As EventArgs)
        TextBox1.SelectedText =  Clipboard.GetText()
    End Sub 
        
    Private Sub ToolStripMenuItem7Click(sender As Object, e As EventArgs)
    	If Clipboard.ContainsImage Or Clipboard.ContainsAudio Then
    		TextBox1.Paste()
    	End If
    End Sub
	    
    Private Sub ToolStripMenuItem8Click(sender As Object, e As EventArgs)
    	SendKeys.Send("^+(l)") 'Bullets
    End Sub
        
    Private Sub ToolStripMenuItem9Click(sender As Object, e As EventArgs)
    	Try
    		SFD1.FileName = "" 
    		SFD1.ShowDialog()
            If SFD1.FileName <> "" Then
            	temp = System.IO.Path.GetExtension(SFD1.FileName).ToLower()
            	If temp = ".wrd" Or temp = ".rtf" Then
            		TextBox1.SaveFile(SFD1.FileName)
            	Else
            		SaveFileAsText(SFD1.FileName)
        		End If
            	changesmade = False
            	openedfile = SFD1.FileName
            End If
        Catch ex As Exception
            Dim k = MsgBox(Err.Description, MsgBoxStyle.Exclamation + MsgBoxStyle.RetryCancel)
            If k = vbRetry Then Call SaveToolStripMenuItem_Click(sender, e)
        End Try
    End Sub
       
    Sub TextBox4Click(sender As Object, e As EventArgs)
    	TextBox1.Focus
    End Sub
    
    Public Sub LoadFileAsText(filename As String)
		Dim File As System.IO.StreamReader
		File = My.Computer.FileSystem.OpenTextFileReader(filename)
		TextBox1.Text = File.ReadToEnd()
		File.Close()
	End Sub

	Public Sub SaveFileAsText(filename As String)	
		Dim File = System.IO.File.CreateText(filename)
    	Using Sw As System.IO.StreamWriter = File
    		For Each Line As String In TextBox1.Lines
    			Sw.WriteLine(Line)
    		Next
    	End Using
    	File.Close()
	End Sub
    
    
    Sub ToolStripMenuItem10Click(sender As Object, e As EventArgs)
    	If Clipboard.ContainsImage Or Clipboard.ContainsAudio Then
    		TextBox1.Paste()
    	End If
    End Sub
    
    Sub DeleteToolStripMenuItemClick(sender As Object, e As EventArgs)
    	TextBox1.SelectedText = ""
    End Sub
    
   
    Sub SelectAllToolStripMenuItem1Click(sender As Object, e As EventArgs)
    	TextBox1.SelectAll
    End Sub
    
    Sub InsertLineToolStripMenuItemClick(sender As Object, e As EventArgs)
    	TextBox1.SelectedText = "//------------------------------------------------"
    End Sub
    
    Sub ToggleBulletToolStripMenuItemClick(sender As Object, e As EventArgs)
    	SendKeys.Send("^+(l)") 'Bullets
    End Sub
    
        
    Sub CutToolStripMenuItemClick(sender As Object, e As EventArgs)
    	TextBox1.Cut
    End Sub
    
    Sub CopyToolStripMenuItemClick(sender As Object, e As EventArgs)
    	TextBox1.Copy
    End Sub
    
    Sub PasteToolStripMenuItemClick(sender As Object, e As EventArgs)
    	TextBox1.SelectedText =  Clipboard.GetText()
    End Sub
    
    Sub ToolStripMenuItem13Click(sender As Object, e As EventArgs)
    	TextBox1.Cut
    End Sub
    
    Sub ToolStripMenuItem12Click(sender As Object, e As EventArgs)
    	TextBox1.Copy
    End Sub
    
    Sub ToolStripMenuItem14Click(sender As Object, e As EventArgs)
    	TextBox1.SelectedText = ""
    End Sub
    
    
    Sub ToolStripMenuItem15Click(sender As Object, e As EventArgs)
    	TextBox1.Undo
    End Sub
    
    Sub ToolStripMenuItem16Click(sender As Object, e As EventArgs)
    	TextBox1.Redo
    End Sub
    
    Sub ToolStripMenuItem17Click(sender As Object, e As EventArgs)
    	TextBox1.Paste
    End Sub
    
    Sub ToolStripMenuItem18Click(sender As Object, e As EventArgs)
    	TextBox1.Paste
    End Sub
End Class

Public Class MyRichTextBox : Inherits RichTextBox
<System.Runtime.InteropServices.DllImport("user32.dll")> Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
End Function
Protected Overrides Sub WndProc(ByRef m As Message)
	On Error Resume Next
	If m.Msg = &H20A Then : Dim ud As IntPtr
        If m.WParam.ToInt32 > 0 Then ud = 0 Else ud = 1
        For i = 1 To 3 : SendMessage(Me.Handle, &H115, ud, 0) : Next
    Else : MyBase.WndProc(m) : End If
End Sub
End Class