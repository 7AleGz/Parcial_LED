<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModalUSDValue
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
        Me.Price = New System.Windows.Forms.TextBox()
        Me.BtnDone = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Title.Location = New System.Drawing.Point(101, 64)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(297, 25)
        Me.Title.TabIndex = 1
        Me.Title.Text = "Ingrese la cotización del dólar a la fecha"
        '
        'Price
        '
        Me.Price.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Price.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price.ForeColor = System.Drawing.SystemColors.Window
        Me.Price.Location = New System.Drawing.Point(184, 128)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(130, 27)
        Me.Price.TabIndex = 0
        '
        'BtnDone
        '
        Me.BtnDone.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnDone.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.BtnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDone.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDone.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnDone.Location = New System.Drawing.Point(203, 188)
        Me.BtnDone.Name = "BtnDone"
        Me.BtnDone.Size = New System.Drawing.Size(93, 28)
        Me.BtnDone.TabIndex = 16
        Me.BtnDone.Text = "CONTINUAR"
        Me.BtnDone.UseVisualStyleBackColor = False
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
        Me.BtnClose.Location = New System.Drawing.Point(436, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(63, 30)
        Me.BtnClose.TabIndex = 17
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'ModalUSDValue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.App.My.Resources.Resources.banner
        Me.ClientSize = New System.Drawing.Size(499, 276)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnDone)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModalUSDValue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "git "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title As Label
    Friend WithEvents Price As TextBox
    Friend WithEvents BtnDone As Button
    Friend WithEvents BtnClose As Button
End Class
