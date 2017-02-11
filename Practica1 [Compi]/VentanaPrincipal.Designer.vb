<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaPrincipal))
        Me.RTB1 = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BotonJugar = New System.Windows.Forms.Button()
        Me.BotonSalir = New System.Windows.Forms.Button()
        Me.botCargar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RTB1
        '
        Me.RTB1.BackColor = System.Drawing.SystemColors.MenuText
        Me.RTB1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTB1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.RTB1.Location = New System.Drawing.Point(46, 332)
        Me.RTB1.Name = "RTB1"
        Me.RTB1.Size = New System.Drawing.Size(609, 66)
        Me.RTB1.TabIndex = 0
        Me.RTB1.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BotonJugar
        '
        Me.BotonJugar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BotonJugar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonJugar.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BotonJugar.Location = New System.Drawing.Point(268, 120)
        Me.BotonJugar.Name = "BotonJugar"
        Me.BotonJugar.Size = New System.Drawing.Size(156, 46)
        Me.BotonJugar.TabIndex = 1
        Me.BotonJugar.Text = "Jugar"
        Me.BotonJugar.UseVisualStyleBackColor = False
        '
        'BotonSalir
        '
        Me.BotonSalir.BackColor = System.Drawing.SystemColors.MenuText
        Me.BotonSalir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonSalir.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.BotonSalir.Location = New System.Drawing.Point(268, 267)
        Me.BotonSalir.Name = "BotonSalir"
        Me.BotonSalir.Size = New System.Drawing.Size(156, 44)
        Me.BotonSalir.TabIndex = 2
        Me.BotonSalir.Text = "Salir"
        Me.BotonSalir.UseVisualStyleBackColor = False
        '
        'botCargar
        '
        Me.botCargar.BackColor = System.Drawing.SystemColors.MenuText
        Me.botCargar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botCargar.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.botCargar.Location = New System.Drawing.Point(268, 24)
        Me.botCargar.Name = "botCargar"
        Me.botCargar.Size = New System.Drawing.Size(156, 44)
        Me.botCargar.TabIndex = 3
        Me.botCargar.Text = "Cargar "
        Me.botCargar.UseVisualStyleBackColor = False
        '
        'VentanaPrincipal
        '
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(692, 410)
        Me.Controls.Add(Me.botCargar)
        Me.Controls.Add(Me.BotonSalir)
        Me.Controls.Add(Me.BotonJugar)
        Me.Controls.Add(Me.RTB1)
        Me.Name = "VentanaPrincipal"
        Me.Text = "Practica 1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Rtb As RichTextBox
    Friend WithEvents btnAnalizar As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents RTB1 As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BotonJugar As Button
    Friend WithEvents BotonSalir As Button
    Friend WithEvents botCargar As Button
End Class
