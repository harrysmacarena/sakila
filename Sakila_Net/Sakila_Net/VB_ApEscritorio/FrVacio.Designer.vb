<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrVacio
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
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.lbData = New System.Windows.Forms.ListBox()
        Me.lvData = New System.Windows.Forms.ListView()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(32, 33)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(240, 150)
        Me.dgvData.TabIndex = 0
        '
        'lbData
        '
        Me.lbData.FormattingEnabled = True
        Me.lbData.Location = New System.Drawing.Point(337, 33)
        Me.lbData.Name = "lbData"
        Me.lbData.Size = New System.Drawing.Size(200, 147)
        Me.lbData.TabIndex = 2
        '
        'lvData
        '
        Me.lvData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvData.Location = New System.Drawing.Point(591, 33)
        Me.lvData.Name = "lvData"
        Me.lvData.Size = New System.Drawing.Size(243, 147)
        Me.lvData.TabIndex = 3
        Me.lvData.UseCompatibleStateImageBehavior = False
        '
        'FrVacio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 501)
        Me.Controls.Add(Me.lvData)
        Me.Controls.Add(Me.lbData)
        Me.Controls.Add(Me.dgvData)
        Me.Name = "FrVacio"
        Me.Text = "FrVacio"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvData As DataGridView
    Friend WithEvents lbData As ListBox
    Friend WithEvents lvData As ListView
End Class
