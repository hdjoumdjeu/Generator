<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadForm1
    Inherits Telerik.WinControls.UI.RadForm

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
        Me.components = New System.ComponentModel.Container()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.txtgene = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.RadLabelElement1 = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadLabelElement2 = New Telerik.WinControls.UI.RadLabelElement()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.rb1 = New Telerik.WinControls.UI.RadRadioButton()
        Me.rb2 = New Telerik.WinControls.UI.RadRadioButton()
        Me.rb3 = New Telerik.WinControls.UI.RadRadioButton()
        Me.rb4 = New Telerik.WinControls.UI.RadRadioButton()
        Me.rb5 = New Telerik.WinControls.UI.RadRadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtgene, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(-5, 75)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(502, 30)
        Me.RadButton1.TabIndex = 0
        Me.RadButton1.Text = "Generer un bénéficiaire"
        '
        'txtgene
        '
        Me.txtgene.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgene.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.txtgene.Location = New System.Drawing.Point(-1, 104)
        Me.txtgene.Name = "txtgene"
        Me.txtgene.Size = New System.Drawing.Size(493, 80)
        Me.txtgene.TabIndex = 3
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElement1, Me.RadLabelElement2})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 204)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(492, 24)
        Me.RadStatusStrip1.TabIndex = 5
        Me.RadStatusStrip1.Text = "RadStatusStrip1"
        '
        'RadLabelElement1
        '
        Me.RadLabelElement1.AccessibleDescription = "Nombre de tours :"
        Me.RadLabelElement1.AccessibleName = "Nombre de tours :"
        Me.RadLabelElement1.Name = "RadLabelElement1"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement1, False)
        Me.RadLabelElement1.Text = "Nombre de tours :"
        Me.RadLabelElement1.TextWrap = True
        Me.RadLabelElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadLabelElement2
        '
        Me.RadLabelElement2.Name = "RadLabelElement2"
        Me.RadStatusStrip1.SetSpring(Me.RadLabelElement2, False)
        Me.RadLabelElement2.Text = ""
        Me.RadLabelElement2.TextWrap = True
        Me.RadLabelElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(419, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(45, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Ajouter"
        '
        'rb1
        '
        Me.rb1.Location = New System.Drawing.Point(167, 54)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(15, 15)
        Me.rb1.TabIndex = 7
        '
        'rb2
        '
        Me.rb2.Location = New System.Drawing.Point(202, 54)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(15, 15)
        Me.rb2.TabIndex = 8
        '
        'rb3
        '
        Me.rb3.Location = New System.Drawing.Point(237, 54)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(15, 15)
        Me.rb3.TabIndex = 8
        '
        'rb4
        '
        Me.rb4.Location = New System.Drawing.Point(272, 54)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(15, 15)
        Me.rb4.TabIndex = 9
        '
        'rb5
        '
        Me.rb5.Location = New System.Drawing.Point(307, 54)
        Me.rb5.Name = "rb5"
        Me.rb5.Size = New System.Drawing.Size(15, 15)
        Me.rb5.TabIndex = 10
        '
        'Timer1
        '
        '
        'RadForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 228)
        Me.Controls.Add(Me.rb5)
        Me.Controls.Add(Me.rb4)
        Me.Controls.Add(Me.rb2)
        Me.Controls.Add(Me.rb3)
        Me.Controls.Add(Me.rb1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.txtgene)
        Me.Controls.Add(Me.RadButton1)
        Me.Name = "RadForm1"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "RadForm1"
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtgene, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtgene As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents RadLabelElement1 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RadLabelElement2 As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents rb1 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rb2 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rb3 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rb4 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rb5 As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class

