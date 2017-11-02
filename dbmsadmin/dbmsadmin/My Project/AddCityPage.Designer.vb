<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCityPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCityPage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cityid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.state = New System.Windows.Forms.TextBox()
        Me.cityname = New System.Windows.Forms.TextBox()
        Me.cityabt = New System.Windows.Forms.TextBox()
        Me.Enter = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Browse = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "City ID"
        '
        'cityid
        '
        Me.cityid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityid.Location = New System.Drawing.Point(153, 62)
        Me.cityid.Name = "cityid"
        Me.cityid.Size = New System.Drawing.Size(100, 29)
        Me.cityid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "State"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "City Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "City About"
        '
        'state
        '
        Me.state.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.state.Location = New System.Drawing.Point(153, 153)
        Me.state.Name = "state"
        Me.state.Size = New System.Drawing.Size(100, 29)
        Me.state.TabIndex = 6
        '
        'cityname
        '
        Me.cityname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityname.Location = New System.Drawing.Point(153, 245)
        Me.cityname.Name = "cityname"
        Me.cityname.Size = New System.Drawing.Size(100, 29)
        Me.cityname.TabIndex = 7
        '
        'cityabt
        '
        Me.cityabt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityabt.Location = New System.Drawing.Point(30, 327)
        Me.cityabt.Multiline = True
        Me.cityabt.Name = "cityabt"
        Me.cityabt.Size = New System.Drawing.Size(695, 152)
        Me.cityabt.TabIndex = 9
        '
        'Enter
        '
        Me.Enter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enter.Location = New System.Drawing.Point(338, 485)
        Me.Enter.Name = "Enter"
        Me.Enter.Size = New System.Drawing.Size(87, 36)
        Me.Enter.TabIndex = 10
        Me.Enter.Text = "Insert"
        Me.Enter.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(465, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "CityImage"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(351, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(339, 176)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Browse
        '
        Me.Browse.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse.Location = New System.Drawing.Point(445, 245)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(153, 31)
        Me.Browse.TabIndex = 13
        Me.Browse.Text = "Browse"
        Me.Browse.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(171, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(360, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Insert data of the city you would like to add"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(29, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AddCityPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(842, 531)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Browse)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Enter)
        Me.Controls.Add(Me.cityabt)
        Me.Controls.Add(Me.cityname)
        Me.Controls.Add(Me.state)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cityid)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AddCityPage"
        Me.Text = "AddCityPage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cityid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents state As TextBox
    Friend WithEvents cityname As TextBox
    Friend WithEvents cityabt As TextBox
    Friend WithEvents Enter As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Browse As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
End Class
