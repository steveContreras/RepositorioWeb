<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaElegirEscenario
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
        Me.lblEtiqueta = New System.Windows.Forms.Label()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.btnAnterior = New System.Windows.Forms.Button()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEtiqueta
        '
        Me.lblEtiqueta.AutoSize = True
        Me.lblEtiqueta.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEtiqueta.Font = New System.Drawing.Font("Gill Sans MT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEtiqueta.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblEtiqueta.Location = New System.Drawing.Point(12, 9)
        Me.lblEtiqueta.Name = "lblEtiqueta"
        Me.lblEtiqueta.Size = New System.Drawing.Size(276, 34)
        Me.lblEtiqueta.TabIndex = 3
        Me.lblEtiqueta.Text = "Selecciona el escenario"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnSeleccionar.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnSeleccionar.Location = New System.Drawing.Point(120, 452)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(132, 40)
        Me.btnSeleccionar.TabIndex = 8
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSiguiente.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnSiguiente.Location = New System.Drawing.Point(224, 394)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(132, 40)
        Me.btnSiguiente.TabIndex = 7
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'Picture
        '
        Me.Picture.Location = New System.Drawing.Point(30, 64)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(310, 310)
        Me.Picture.TabIndex = 6
        Me.Picture.TabStop = False
        '
        'btnAnterior
        '
        Me.btnAnterior.BackColor = System.Drawing.SystemColors.InfoText
        Me.btnAnterior.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnAnterior.Location = New System.Drawing.Point(15, 394)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(132, 40)
        Me.btnAnterior.TabIndex = 5
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = False
        '
        'VentanaElegirEscenario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(364, 501)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.Picture)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.lblEtiqueta)
        Me.Name = "VentanaElegirEscenario"
        Me.Text = "Elegir escenario"
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEtiqueta As Label
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents Picture As PictureBox
    Friend WithEvents btnAnterior As Button
End Class
