<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reviewpage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reviewpage))
        Me.Back = New System.Windows.Forms.Button()
        Me.reviewbox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.BackgroundImage = CType(resources.GetObject("Back.BackgroundImage"), System.Drawing.Image)
        Me.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Back.Location = New System.Drawing.Point(25, 32)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(30, 23)
        Me.Back.TabIndex = 0
        Me.Back.UseVisualStyleBackColor = True
        '
        'reviewbox
        '
        Me.reviewbox.BackColor = System.Drawing.SystemColors.Info
        Me.reviewbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reviewbox.FormattingEnabled = True
        Me.reviewbox.ItemHeight = 20
        Me.reviewbox.Location = New System.Drawing.Point(132, 51)
        Me.reviewbox.Name = "reviewbox"
        Me.reviewbox.Size = New System.Drawing.Size(555, 324)
        Me.reviewbox.TabIndex = 1
        '
        'reviewpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(791, 387)
        Me.Controls.Add(Me.reviewbox)
        Me.Controls.Add(Me.Back)
        Me.Name = "reviewpage"
        Me.Text = "reviewpage"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Back As Button
    Friend WithEvents reviewbox As ListBox
End Class
