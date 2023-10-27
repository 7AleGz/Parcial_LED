<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConvert
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConvert))
        Me.Title = New System.Windows.Forms.Label()
        Me.USDCant = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.operationStatus = New System.Windows.Forms.Label()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LabelValue = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnHistory = New System.Windows.Forms.Button()
        Me.ARSCant = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Title.Location = New System.Drawing.Point(205, 61)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(253, 25)
        Me.Title.TabIndex = 1
        Me.Title.Text = "Conversión Dólar a Peso Argentino"
        '
        'USDCant
        '
        Me.USDCant.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.USDCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.USDCant.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USDCant.ForeColor = System.Drawing.SystemColors.Window
        Me.USDCant.Location = New System.Drawing.Point(225, 174)
        Me.USDCant.Name = "USDCant"
        Me.USDCant.Size = New System.Drawing.Size(100, 23)
        Me.USDCant.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Valor Dólar Blue: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(260, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "USD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(372, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ARS"
        '
        'operationStatus
        '
        Me.operationStatus.AutoSize = True
        Me.operationStatus.Location = New System.Drawing.Point(588, 201)
        Me.operationStatus.Name = "operationStatus"
        Me.operationStatus.Size = New System.Drawing.Size(0, 13)
        Me.operationStatus.TabIndex = 10
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.Firebrick
        Me.BtnReset.BackgroundImage = CType(resources.GetObject("BtnReset.BackgroundImage"), System.Drawing.Image)
        Me.BtnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReset.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.BtnReset.FlatAppearance.BorderSize = 0
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReset.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnReset.Location = New System.Drawing.Point(455, 174)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(25, 23)
        Me.BtnReset.TabIndex = 14
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'BtnConvert
        '
        Me.BtnConvert.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnConvert.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.BtnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConvert.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConvert.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnConvert.Location = New System.Drawing.Point(285, 213)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(93, 28)
        Me.BtnConvert.TabIndex = 15
        Me.BtnConvert.Text = "CONVERTIR"
        Me.BtnConvert.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.DimGray
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnClose.Location = New System.Drawing.Point(600, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(63, 30)
        Me.BtnClose.TabIndex = 16
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'LabelValue
        '
        Me.LabelValue.AutoSize = True
        Me.LabelValue.BackColor = System.Drawing.Color.Transparent
        Me.LabelValue.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelValue.ForeColor = System.Drawing.Color.LimeGreen
        Me.LabelValue.Location = New System.Drawing.Point(107, 27)
        Me.LabelValue.Name = "LabelValue"
        Me.LabelValue.Size = New System.Drawing.Size(45, 19)
        Me.LabelValue.TabIndex = 17
        Me.LabelValue.Text = "{valor}"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(542, 179)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 115)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'BtnHistory
        '
        Me.BtnHistory.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnHistory.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHistory.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHistory.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnHistory.Location = New System.Drawing.Point(8, 266)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(93, 28)
        Me.BtnHistory.TabIndex = 19
        Me.BtnHistory.Text = "HISTORIAL"
        Me.BtnHistory.UseVisualStyleBackColor = False
        '
        'ARSCant
        '
        Me.ARSCant.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ARSCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ARSCant.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ARSCant.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ARSCant.Location = New System.Drawing.Point(337, 174)
        Me.ARSCant.Name = "ARSCant"
        Me.ARSCant.Size = New System.Drawing.Size(100, 23)
        Me.ARSCant.TabIndex = 20
        '
        'FrmConvert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.App.My.Resources.Resources.banner
        Me.ClientSize = New System.Drawing.Size(663, 301)
        Me.Controls.Add(Me.ARSCant)
        Me.Controls.Add(Me.BtnHistory)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelValue)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.operationStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.USDCant)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmConvert"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "g"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title As Label
    Friend WithEvents USDCant As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents operationStatus As Label
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnConvert As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents LabelValue As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnHistory As Button
    Friend WithEvents ARSCant As Label
End Class
