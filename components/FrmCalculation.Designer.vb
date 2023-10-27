<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCalculation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCalculation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LongSize = New System.Windows.Forms.TextBox()
        Me.WideSize = New System.Windows.Forms.TextBox()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Result = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(39, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "LARGO DEL LOTE"
        '
        'LongSize
        '
        Me.LongSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LongSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LongSize.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LongSize.ForeColor = System.Drawing.SystemColors.Window
        Me.LongSize.Location = New System.Drawing.Point(29, 152)
        Me.LongSize.Name = "LongSize"
        Me.LongSize.Size = New System.Drawing.Size(113, 27)
        Me.LongSize.TabIndex = 0
        '
        'WideSize
        '
        Me.WideSize.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.WideSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WideSize.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WideSize.ForeColor = System.Drawing.SystemColors.Window
        Me.WideSize.Location = New System.Drawing.Point(161, 152)
        Me.WideSize.Name = "WideSize"
        Me.WideSize.Size = New System.Drawing.Size(113, 27)
        Me.WideSize.TabIndex = 1
        '
        'BtnCalculate
        '
        Me.BtnCalculate.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnCalculate.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.BtnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalculate.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCalculate.Location = New System.Drawing.Point(448, 152)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(93, 28)
        Me.BtnCalculate.TabIndex = 2
        Me.BtnCalculate.Text = "CALCULAR"
        Me.BtnCalculate.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(286, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "="
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
        Me.BtnClose.Location = New System.Drawing.Point(545, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(63, 30)
        Me.BtnClose.TabIndex = 11
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(170, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ANCHO DEL LOTE"
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
        Me.BtnReset.Location = New System.Drawing.Point(557, 152)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(28, 28)
        Me.BtnReset.TabIndex = 13
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(490, 196)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 107)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(318, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "METROS CUADRADOS"
        '
        'Result
        '
        Me.Result.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Result.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Result.Location = New System.Drawing.Point(320, 152)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(113, 27)
        Me.Result.TabIndex = 16
        '
        'FrmCalculation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(608, 310)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.WideSize)
        Me.Controls.Add(Me.LongSize)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCalculation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculo de lotes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents LongSize As TextBox
    Friend WithEvents WideSize As TextBox
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnReset As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Result As Label
End Class
