﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        privatetext = New TextBox()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        PictureBox4 = New PictureBox()
        Label1 = New Label()
        Loginbtn = New TextBox()
        Forgotpasstxt = New Label()
        Remembertxt = New Label()
        Tboxpass = New TextBox()
        PictureBox2 = New PictureBox()
        Tboxuser = New TextBox()
        PictureBox3 = New PictureBox()
        Passwordtxt = New Label()
        Usernametxt = New Label()
        logintxt = New Label()
        EnterUsertxt = New Label()
        Panel2 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' privatetext
        ' 
        privatetext.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        privatetext.BackColor = Color.White
        privatetext.BorderStyle = BorderStyle.None
        privatetext.Font = New Font("Microsoft PhagsPa", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        privatetext.Location = New Point(410, 299)
        privatetext.Margin = New Padding(3, 4, 3, 4)
        privatetext.Multiline = True
        privatetext.Name = "privatetext"
        privatetext.Size = New Size(490, 48)
        privatetext.TabIndex = 1
        privatetext.Text = "This is a private database. Unauthorized access, use, or disclosure of any information contained herein is strictly prohibited. "
        privatetext.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Enabled = False
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(397, 109)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(464, 181)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(162), CByte(213), CByte(255))
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Loginbtn)
        Panel1.Controls.Add(Forgotpasstxt)
        Panel1.Controls.Add(Remembertxt)
        Panel1.Controls.Add(Tboxpass)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Tboxuser)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(Passwordtxt)
        Panel1.Controls.Add(Usernametxt)
        Panel1.Controls.Add(logintxt)
        Panel1.Location = New Point(358, 355)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(592, 411)
        Panel1.TabIndex = 2
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(193, 252)
        PictureBox4.Margin = New Padding(3, 4, 3, 4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(13, 15)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(39), CByte(158), CByte(255))
        Label1.Font = New Font("Microsoft PhagsPa", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(290, 320)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 22)
        Label1.TabIndex = 10
        Label1.Text = "LOGIN"
        ' 
        ' Loginbtn
        ' 
        Loginbtn.BackColor = Color.FromArgb(CByte(39), CByte(158), CByte(255))
        Loginbtn.BorderStyle = BorderStyle.None
        Loginbtn.Font = New Font("Microsoft PhagsPa", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Loginbtn.ForeColor = Color.White
        Loginbtn.ImeMode = ImeMode.On
        Loginbtn.Location = New Point(193, 316)
        Loginbtn.Margin = New Padding(3, 4, 3, 4)
        Loginbtn.Multiline = True
        Loginbtn.Name = "Loginbtn"
        Loginbtn.Size = New Size(253, 41)
        Loginbtn.TabIndex = 9
        Loginbtn.TextAlign = HorizontalAlignment.Center
        ' 
        ' Forgotpasstxt
        ' 
        Forgotpasstxt.AutoSize = True
        Forgotpasstxt.Font = New Font("Microsoft PhagsPa", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Forgotpasstxt.ForeColor = Color.FromArgb(CByte(39), CByte(158), CByte(255))
        Forgotpasstxt.Location = New Point(310, 248)
        Forgotpasstxt.Name = "Forgotpasstxt"
        Forgotpasstxt.Size = New Size(153, 18)
        Forgotpasstxt.TabIndex = 8
        Forgotpasstxt.Text = "Forgot your password ?"
        ' 
        ' Remembertxt
        ' 
        Remembertxt.AutoSize = True
        Remembertxt.Font = New Font("Microsoft PhagsPa", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Remembertxt.ForeColor = Color.FromArgb(CByte(103), CByte(103), CByte(103))
        Remembertxt.Location = New Point(207, 248)
        Remembertxt.Name = "Remembertxt"
        Remembertxt.Size = New Size(97, 18)
        Remembertxt.TabIndex = 6
        Remembertxt.Text = "Remember me"
        ' 
        ' Tboxpass
        ' 
        Tboxpass.BorderStyle = BorderStyle.None
        Tboxpass.ImeMode = ImeMode.On
        Tboxpass.Location = New Point(193, 203)
        Tboxpass.Margin = New Padding(3, 4, 3, 4)
        Tboxpass.Multiline = True
        Tboxpass.Name = "Tboxpass"
        Tboxpass.Size = New Size(253, 41)
        Tboxpass.TabIndex = 5
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(161, 203)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(25, 31)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Tboxuser
        ' 
        Tboxuser.BackColor = Color.White
        Tboxuser.BorderStyle = BorderStyle.None
        Tboxuser.ImeMode = ImeMode.On
        Tboxuser.Location = New Point(193, 117)
        Tboxuser.Margin = New Padding(3, 4, 3, 4)
        Tboxuser.Multiline = True
        Tboxuser.Name = "Tboxuser"
        Tboxuser.Size = New Size(253, 41)
        Tboxuser.TabIndex = 4
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(161, 117)
        PictureBox3.Margin = New Padding(3, 4, 3, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(25, 31)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 5
        PictureBox3.TabStop = False
        ' 
        ' Passwordtxt
        ' 
        Passwordtxt.AutoSize = True
        Passwordtxt.Font = New Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Passwordtxt.ForeColor = Color.FromArgb(CByte(103), CByte(103), CByte(103))
        Passwordtxt.Location = New Point(193, 177)
        Passwordtxt.Name = "Passwordtxt"
        Passwordtxt.Size = New Size(71, 20)
        Passwordtxt.TabIndex = 4
        Passwordtxt.Text = "Password"
        ' 
        ' Usernametxt
        ' 
        Usernametxt.AutoSize = True
        Usernametxt.Font = New Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Usernametxt.ForeColor = Color.FromArgb(CByte(103), CByte(103), CByte(103))
        Usernametxt.Location = New Point(193, 91)
        Usernametxt.Name = "Usernametxt"
        Usernametxt.Size = New Size(75, 20)
        Usernametxt.TabIndex = 1
        Usernametxt.Text = "Username"
        ' 
        ' logintxt
        ' 
        logintxt.AutoSize = True
        logintxt.Font = New Font("Microsoft PhagsPa", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        logintxt.Location = New Point(246, 31)
        logintxt.Name = "logintxt"
        logintxt.Size = New Size(120, 49)
        logintxt.TabIndex = 0
        logintxt.Text = "Login"
        ' 
        ' EnterUsertxt
        ' 
        EnterUsertxt.AutoSize = True
        EnterUsertxt.BackColor = Color.White
        EnterUsertxt.Font = New Font("Microsoft PhagsPa", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        EnterUsertxt.ForeColor = Color.Gainsboro
        EnterUsertxt.Location = New Point(824, 509)
        EnterUsertxt.Name = "EnterUsertxt"
        EnterUsertxt.Size = New Size(171, 22)
        EnterUsertxt.TabIndex = 4
        EnterUsertxt.Text = "Enter your Username"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(12), CByte(53), CByte(106))
        Panel2.Location = New Point(-15, 0)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1314, 101)
        Panel2.TabIndex = 3
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1285, 972)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(privatetext)
        Controls.Add(PictureBox1)
        Controls.Add(EnterUsertxt)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Login"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents privatetext As TextBox
    Public WithEvents PictureBox1 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents logintxt As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Usernametxt As Label
    Friend WithEvents Passwordtxt As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Tboxpass As TextBox
    Friend WithEvents Remembertxt As Label
    Friend WithEvents EnterUsertxt As Label
    Friend WithEvents Forgotpasstxt As Label
    Friend WithEvents Loginbtn As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Private WithEvents Tboxuser As TextBox
End Class
