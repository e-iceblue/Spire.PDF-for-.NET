Namespace SimpleList
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.button1 = New System.Windows.Forms.Button
            Me.label1 = New System.Windows.Forms.Label
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = Global.My.Resources.Resources.Icon
            Me.pictureBox1.Location = New System.Drawing.Point(12, 12)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(56, 56)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pictureBox1.TabIndex = 0
            Me.pictureBox1.TabStop = False
            '
            'button1
            '
            Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button1.BackColor = System.Drawing.Color.Transparent
            Me.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
            Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.Location = New System.Drawing.Point(349, 95)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(96, 27)
            Me.button1.TabIndex = 63
            Me.button1.Text = "Run"
            Me.button1.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!)
            Me.label1.Location = New System.Drawing.Point(85, 12)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(360, 63)
            Me.label1.TabIndex = 64
            Me.label1.Text = resources.GetString("label1.Text")
            '
            'Form1
            '
            Me.AutoSize = True
            Me.ClientSize = New System.Drawing.Size(457, 134)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.pictureBox1)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Simple List"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private pictureBox1 As PictureBox
		Private WithEvents button1 As Button
		Private label1 As Label
	End Class
End Namespace

