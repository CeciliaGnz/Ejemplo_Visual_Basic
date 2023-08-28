<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbOpc6 = New System.Windows.Forms.RadioButton()
        Me.rdbOpc5 = New System.Windows.Forms.RadioButton()
        Me.rdbOpc4 = New System.Windows.Forms.RadioButton()
        Me.rdbOpc3 = New System.Windows.Forms.RadioButton()
        Me.rdbOpc2 = New System.Windows.Forms.RadioButton()
        Me.rdbOpc1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbOpc6)
        Me.GroupBox1.Controls.Add(Me.rdbOpc5)
        Me.GroupBox1.Controls.Add(Me.rdbOpc4)
        Me.GroupBox1.Controls.Add(Me.rdbOpc3)
        Me.GroupBox1.Controls.Add(Me.rdbOpc2)
        Me.GroupBox1.Controls.Add(Me.rdbOpc1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1077, 240)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RadioButton"
        '
        'rdbOpc6
        '
        Me.rdbOpc6.AutoSize = True
        Me.rdbOpc6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbOpc6.Location = New System.Drawing.Point(532, 153)
        Me.rdbOpc6.Name = "rdbOpc6"
        Me.rdbOpc6.Size = New System.Drawing.Size(182, 42)
        Me.rdbOpc6.TabIndex = 5
        Me.rdbOpc6.Text = "Ejemplo 6"
        Me.rdbOpc6.UseVisualStyleBackColor = True
        '
        'rdbOpc5
        '
        Me.rdbOpc5.AutoSize = True
        Me.rdbOpc5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbOpc5.Location = New System.Drawing.Point(287, 153)
        Me.rdbOpc5.Name = "rdbOpc5"
        Me.rdbOpc5.Size = New System.Drawing.Size(182, 42)
        Me.rdbOpc5.TabIndex = 4
        Me.rdbOpc5.Text = "Ejemplo 5"
        Me.rdbOpc5.UseVisualStyleBackColor = True
        '
        'rdbOpc4
        '
        Me.rdbOpc4.AutoSize = True
        Me.rdbOpc4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbOpc4.Location = New System.Drawing.Point(802, 56)
        Me.rdbOpc4.Name = "rdbOpc4"
        Me.rdbOpc4.Size = New System.Drawing.Size(182, 42)
        Me.rdbOpc4.TabIndex = 3
        Me.rdbOpc4.Text = "Ejemplo 4"
        Me.rdbOpc4.UseVisualStyleBackColor = True
        '
        'rdbOpc3
        '
        Me.rdbOpc3.AutoSize = True
        Me.rdbOpc3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbOpc3.Location = New System.Drawing.Point(517, 56)
        Me.rdbOpc3.Name = "rdbOpc3"
        Me.rdbOpc3.Size = New System.Drawing.Size(182, 42)
        Me.rdbOpc3.TabIndex = 2
        Me.rdbOpc3.Text = "Ejemplo 3"
        Me.rdbOpc3.UseVisualStyleBackColor = True
        '
        'rdbOpc2
        '
        Me.rdbOpc2.AutoSize = True
        Me.rdbOpc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbOpc2.Location = New System.Drawing.Point(275, 56)
        Me.rdbOpc2.Name = "rdbOpc2"
        Me.rdbOpc2.Size = New System.Drawing.Size(182, 42)
        Me.rdbOpc2.TabIndex = 1
        Me.rdbOpc2.Text = "Ejemplo 2"
        Me.rdbOpc2.UseVisualStyleBackColor = True
        '
        'rdbOpc1
        '
        Me.rdbOpc1.AutoSize = True
        Me.rdbOpc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbOpc1.Location = New System.Drawing.Point(35, 56)
        Me.rdbOpc1.Name = "rdbOpc1"
        Me.rdbOpc1.Size = New System.Drawing.Size(182, 42)
        Me.rdbOpc1.TabIndex = 0
        Me.rdbOpc1.Text = "Ejemplo 1"
        Me.rdbOpc1.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 523)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbOpc5 As RadioButton
    Friend WithEvents rdbOpc4 As RadioButton
    Friend WithEvents rdbOpc3 As RadioButton
    Friend WithEvents rdbOpc2 As RadioButton
    Friend WithEvents rdbOpc1 As RadioButton
    Friend WithEvents rdbOpc6 As RadioButton
End Class
