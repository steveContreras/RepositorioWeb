<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaDeJuego
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
        Me.components = New System.ComponentModel.Container()
        Me.MoverNave = New System.Windows.Forms.Timer(Me.components)
        Me.imgNave = New System.Windows.Forms.PictureBox()
        Me.lblScore = New System.Windows.Forms.Label()
        CType(Me.imgNave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MoverNave
        '
        Me.MoverNave.Interval = 10
        '
        'imgNave
        '
        Me.imgNave.Location = New System.Drawing.Point(357, 419)
        Me.imgNave.Name = "imgNave"
        Me.imgNave.Size = New System.Drawing.Size(60, 80)
        Me.imgNave.TabIndex = 0
        Me.imgNave.TabStop = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblScore.Font = New System.Drawing.Font("Kristen ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblScore.Location = New System.Drawing.Point(1, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(781, 27)
        Me.lblScore.TabIndex = 1
        Me.lblScore.Text = "Jugador:                                 Vida:                           Punteo  " &
    "                 "
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'VentanaDeJuego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(784, 511)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.imgNave)
        Me.KeyPreview = True
        Me.Name = "VentanaDeJuego"
        Me.Text = "VentanaDeJuego"
        CType(Me.imgNave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MoverNave As Timer
    Friend WithEvents imgNave As PictureBox
    Friend WithEvents lblScore As Label
End Class
