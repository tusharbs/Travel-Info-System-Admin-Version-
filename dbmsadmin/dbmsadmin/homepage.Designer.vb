<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class homepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homepage))
        Me.AddCity = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.AddPlace = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.aname = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AddCity
        '
        Me.AddCity.BackColor = System.Drawing.SystemColors.Highlight
        Me.AddCity.Location = New System.Drawing.Point(651, 222)
        Me.AddCity.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.AddCity.Name = "AddCity"
        Me.AddCity.Size = New System.Drawing.Size(403, 41)
        Me.AddCity.TabIndex = 3
        Me.AddCity.Text = "Add City Data"
        Me.AddCity.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button5.Location = New System.Drawing.Point(0, 159)
        Me.Button5.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(1235, 44)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Resolve Queries"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'AddPlace
        '
        Me.AddPlace.BackColor = System.Drawing.SystemColors.Highlight
        Me.AddPlace.Location = New System.Drawing.Point(36, 222)
        Me.AddPlace.Name = "AddPlace"
        Me.AddPlace.Size = New System.Drawing.Size(420, 41)
        Me.AddPlace.TabIndex = 7
        Me.AddPlace.Text = "Add Place Data"
        Me.AddPlace.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Location = New System.Drawing.Point(36, 300)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(420, 45)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Update Place Data"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button3.Location = New System.Drawing.Point(651, 300)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(403, 45)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Update City Data"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'aname
        '
        Me.aname.AutoSize = True
        Me.aname.BackColor = System.Drawing.Color.Transparent
        Me.aname.Location = New System.Drawing.Point(31, 7)
        Me.aname.Name = "aname"
        Me.aname.Size = New System.Drawing.Size(77, 25)
        Me.aname.TabIndex = 11
        Me.aname.Text = "Label2"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 41)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(61, 18)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Log Out"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(-5, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Hi,"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(337, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(534, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Welcome to the admin panel of the Travel Info System "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(464, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "What would you like to do?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(438, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 37)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Travel Info System"
        '
        'homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1145, 555)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.aname)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AddPlace)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.AddCity)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "homepage"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "homepage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddCity As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents AddPlace As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents aname As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
