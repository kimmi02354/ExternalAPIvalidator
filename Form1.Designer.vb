<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstFunctions = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AGXml = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExtXML = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.ConsTxt = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1792, 49)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(137, 45)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'lstFunctions
        '
        Me.lstFunctions.FormattingEnabled = True
        Me.lstFunctions.ItemHeight = 31
        Me.lstFunctions.Items.AddRange(New Object() {"AuthenticatePlayer", "GetBalance", "AddBet", "AddWin", "AddRefund"})
        Me.lstFunctions.Location = New System.Drawing.Point(36, 79)
        Me.lstFunctions.Name = "lstFunctions"
        Me.lstFunctions.Size = New System.Drawing.Size(322, 624)
        Me.lstFunctions.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(375, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "XML from AuthenticGaming:"
        '
        'AGXml
        '
        Me.AGXml.Location = New System.Drawing.Point(381, 115)
        Me.AGXml.Multiline = True
        Me.AGXml.Name = "AGXml"
        Me.AGXml.Size = New System.Drawing.Size(1387, 261)
        Me.AGXml.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(381, 392)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Your returned XML:"
        '
        'ExtXML
        '
        Me.ExtXML.Location = New System.Drawing.Point(387, 442)
        Me.ExtXML.Multiline = True
        Me.ExtXML.Name = "ExtXML"
        Me.ExtXML.Size = New System.Drawing.Size(1387, 261)
        Me.ExtXML.TabIndex = 5
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(1502, 709)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(272, 63)
        Me.btnSend.TabIndex = 6
        Me.btnSend.Text = "SEND"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'ConsTxt
        '
        Me.ConsTxt.Location = New System.Drawing.Point(36, 710)
        Me.ConsTxt.Multiline = True
        Me.ConsTxt.Name = "ConsTxt"
        Me.ConsTxt.Size = New System.Drawing.Size(1244, 62)
        Me.ConsTxt.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1792, 786)
        Me.Controls.Add(Me.ConsTxt)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.ExtXML)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AGXml)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstFunctions)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "AG Integration helper"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstFunctions As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AGXml As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ExtXML As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents ConsTxt As TextBox
End Class
