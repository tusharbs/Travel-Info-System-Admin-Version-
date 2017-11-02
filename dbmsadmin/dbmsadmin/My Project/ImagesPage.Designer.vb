<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImagesPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImagesPage))
        Me.imagelist = New System.Windows.Forms.ListBox()
        Me.imagebox = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.imagebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imagelist
        '
        Me.imagelist.BackColor = System.Drawing.SystemColors.Info
        Me.imagelist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imagelist.ForeColor = System.Drawing.Color.Maroon
        Me.imagelist.FormattingEnabled = True
        Me.imagelist.ItemHeight = 16
        Me.imagelist.Location = New System.Drawing.Point(3, 78)
        Me.imagelist.Name = "imagelist"
        Me.imagelist.Size = New System.Drawing.Size(169, 212)
        Me.imagelist.TabIndex = 2
        '
        'imagebox
        '
        Me.imagebox.Location = New System.Drawing.Point(328, 78)
        Me.imagebox.Name = "imagebox"
        Me.imagebox.Size = New System.Drawing.Size(240, 190)
        Me.imagebox.TabIndex = 3
        Me.imagebox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 64)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select an element from " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "from the below list of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "userids to display the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "corresp" &
    "onding image" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ImagesPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(736, 319)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imagebox)
        Me.Controls.Add(Me.imagelist)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.Name = "ImagesPage"
        Me.Text = "ImagesPage"
        CType(Me.imagebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imagelist As ListBox
    Friend WithEvents imagebox As PictureBox
    Friend WithEvents Label1 As Label
End Class
