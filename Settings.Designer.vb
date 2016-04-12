<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtServerLink = New System.Windows.Forms.TextBox()
        Me.txtTimeOut = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server link:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(287, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TimeOut of response:"
        '
        'txtServerLink
        '
        Me.txtServerLink.Location = New System.Drawing.Point(329, 30)
        Me.txtServerLink.Name = "txtServerLink"
        Me.txtServerLink.Size = New System.Drawing.Size(772, 38)
        Me.txtServerLink.TabIndex = 2
        '
        'txtTimeOut
        '
        Me.txtTimeOut.Location = New System.Drawing.Point(329, 83)
        Me.txtTimeOut.Name = "txtTimeOut"
        Me.txtTimeOut.Size = New System.Drawing.Size(772, 38)
        Me.txtTimeOut.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(740, 151)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(350, 53)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 216)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtTimeOut)
        Me.Controls.Add(Me.txtServerLink)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtServerLink As TextBox
    Friend WithEvents txtTimeOut As TextBox
    Friend WithEvents btnSave As Button
End Class
