﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageBoxChange
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessageBoxChange))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.MaxLength = 78
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(330, 22)
        Me.TextBox1.TabIndex = 0
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelButton.Location = New System.Drawing.Point(267, 41)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 2
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OKButton.Location = New System.Drawing.Point(186, 41)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 1
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "You are limited to 78 characters."
        '
        'MessageBoxChange
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(354, 76)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MessageBoxChange"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify Message Box"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class