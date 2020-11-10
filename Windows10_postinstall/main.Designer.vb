<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.pictureApp = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.linkGithub = New System.Windows.Forms.LinkLabel()
        Me.lblInspiration = New System.Windows.Forms.Label()
        Me.listTweaks = New System.Windows.Forms.CheckedListBox()
        Me.btnDisableSel = New System.Windows.Forms.Button()
        Me.btnDisableAll = New System.Windows.Forms.Button()
        Me.btnRestore = New System.Windows.Forms.Button()
        CType(Me.pictureApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureApp
        '
        Me.pictureApp.Image = CType(resources.GetObject("pictureApp.Image"), System.Drawing.Image)
        Me.pictureApp.Location = New System.Drawing.Point(14, 14)
        Me.pictureApp.Name = "pictureApp"
        Me.pictureApp.Size = New System.Drawing.Size(64, 64)
        Me.pictureApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureApp.TabIndex = 0
        Me.pictureApp.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(90, 14)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(364, 30)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Windows 10 Post-installation utility"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(95, 48)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(170, 15)
        Me.lblAuthor.TabIndex = 2
        Me.lblAuthor.Text = "by Federico Arduini (faffolao) -"
        '
        'linkGithub
        '
        Me.linkGithub.AutoSize = True
        Me.linkGithub.Location = New System.Drawing.Point(261, 48)
        Me.linkGithub.Name = "linkGithub"
        Me.linkGithub.Size = New System.Drawing.Size(280, 15)
        Me.linkGithub.TabIndex = 3
        Me.linkGithub.TabStop = True
        Me.linkGithub.Text = "https://github.com/faffolao/Windows10_postinstall"
        '
        'lblInspiration
        '
        Me.lblInspiration.AutoSize = True
        Me.lblInspiration.Location = New System.Drawing.Point(95, 63)
        Me.lblInspiration.Name = "lblInspiration"
        Me.lblInspiration.Size = New System.Drawing.Size(292, 15)
        Me.lblInspiration.TabIndex = 4
        Me.lblInspiration.Text = "based on Win10-Initial-Setup-Script by Disassembler0."
        '
        'listTweaks
        '
        Me.listTweaks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listTweaks.CheckOnClick = True
        Me.listTweaks.FormattingEnabled = True
        Me.listTweaks.Items.AddRange(New Object() {"Test1", "Test2"})
        Me.listTweaks.Location = New System.Drawing.Point(14, 95)
        Me.listTweaks.Name = "listTweaks"
        Me.listTweaks.Size = New System.Drawing.Size(527, 346)
        Me.listTweaks.TabIndex = 5
        '
        'btnDisableSel
        '
        Me.btnDisableSel.Location = New System.Drawing.Point(14, 447)
        Me.btnDisableSel.Name = "btnDisableSel"
        Me.btnDisableSel.Size = New System.Drawing.Size(119, 23)
        Me.btnDisableSel.TabIndex = 6
        Me.btnDisableSel.Text = "Disable selected"
        Me.btnDisableSel.UseVisualStyleBackColor = True
        '
        'btnDisableAll
        '
        Me.btnDisableAll.Location = New System.Drawing.Point(351, 447)
        Me.btnDisableAll.Name = "btnDisableAll"
        Me.btnDisableAll.Size = New System.Drawing.Size(75, 23)
        Me.btnDisableAll.TabIndex = 7
        Me.btnDisableAll.Text = "Disable all"
        Me.btnDisableAll.UseVisualStyleBackColor = True
        '
        'btnRestore
        '
        Me.btnRestore.Location = New System.Drawing.Point(432, 447)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(109, 23)
        Me.btnRestore.TabIndex = 8
        Me.btnRestore.Text = "Revert changes"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(555, 482)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnDisableAll)
        Me.Controls.Add(Me.btnDisableSel)
        Me.Controls.Add(Me.listTweaks)
        Me.Controls.Add(Me.lblInspiration)
        Me.Controls.Add(Me.linkGithub)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pictureApp)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windows 10 Post-install utility"
        CType(Me.pictureApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pictureApp As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents linkGithub As LinkLabel
    Friend WithEvents lblInspiration As Label
    Friend WithEvents listTweaks As CheckedListBox
    Friend WithEvents btnDisableSel As Button
    Friend WithEvents btnDisableAll As Button
    Friend WithEvents btnRestore As Button
End Class
