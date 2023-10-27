<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Title = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnM2 = New System.Windows.Forms.Button()
        Me.BtnExchange = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Title.Location = New System.Drawing.Point(138, 77)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(279, 25)
        Me.Title.TabIndex = 3
        Me.Title.Text = "Para continuar, seleccione una opción"
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
        Me.BtnClose.Location = New System.Drawing.Point(491, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(63, 30)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnM2
        '
        Me.BtnM2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnM2.FlatAppearance.BorderSize = 0
        Me.BtnM2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnM2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnM2.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnM2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnM2.Location = New System.Drawing.Point(167, 137)
        Me.BtnM2.Name = "BtnM2"
        Me.BtnM2.Size = New System.Drawing.Size(217, 47)
        Me.BtnM2.TabIndex = 5
        Me.BtnM2.Text = "CALCULO DE SUPERFICIE DE LOTES"
        Me.BtnM2.UseVisualStyleBackColor = False
        '
        'BtnExchange
        '
        Me.BtnExchange.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnExchange.FlatAppearance.BorderSize = 0
        Me.BtnExchange.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExchange.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExchange.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnExchange.Location = New System.Drawing.Point(167, 227)
        Me.BtnExchange.Name = "BtnExchange"
        Me.BtnExchange.Size = New System.Drawing.Size(217, 47)
        Me.BtnExchange.TabIndex = 6
        Me.BtnExchange.Text = "CASA DE CAMBIO"
        Me.BtnExchange.UseVisualStyleBackColor = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.App.My.Resources.Resources.banner
        Me.ClientSize = New System.Drawing.Size(555, 335)
        Me.Controls.Add(Me.BtnExchange)
        Me.Controls.Add(Me.BtnM2)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnM2 As Button
    Friend WithEvents BtnExchange As Button
End Class
