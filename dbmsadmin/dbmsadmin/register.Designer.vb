<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register_page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register_page))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.uname = New System.Windows.Forms.TextBox()
        Me.userId = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.rpassword = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.register_but = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(359, 174)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(338, 212)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Admin Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(332, 247)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(270, 282)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Reenter Password"
        '
        'uname
        '
        Me.uname.Location = New System.Drawing.Point(465, 174)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(152, 26)
        Me.uname.TabIndex = 4
        '
        'userId
        '
        Me.userId.Location = New System.Drawing.Point(465, 206)
        Me.userId.Name = "userId"
        Me.userId.Size = New System.Drawing.Size(152, 26)
        Me.userId.TabIndex = 5
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(465, 244)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(152, 26)
        Me.password.TabIndex = 6
        '
        'rpassword
        '
        Me.rpassword.Location = New System.Drawing.Point(465, 276)
        Me.rpassword.Name = "rpassword"
        Me.rpassword.Size = New System.Drawing.Size(152, 26)
        Me.rpassword.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(623, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 26)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = True
        '
        'register_but
        '
        Me.register_but.Location = New System.Drawing.Point(388, 334)
        Me.register_but.Name = "register_but"
        Me.register_but.Size = New System.Drawing.Size(142, 31)
        Me.register_but.TabIndex = 9
        Me.register_but.Text = "Register"
        Me.register_but.UseVisualStyleBackColor = True
        '
        'register_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(974, 485)
        Me.Controls.Add(Me.register_but)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rpassword)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.userId)
        Me.Controls.Add(Me.uname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "register_page"
        Me.Text = "register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents uname As TextBox
    Friend WithEvents userId As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents rpassword As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents register_but As Button
End Class
