<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnGo = New Button()
        Button1 = New Button()
        btnDataTypes = New Button()
        SuspendLayout()
        ' 
        ' btnGo
        ' 
        btnGo.AccessibleName = "btnGo"
        btnGo.Location = New Point(139, 54)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(231, 121)
        btnGo.TabIndex = 0
        btnGo.Text = "Go"
        btnGo.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.AccessibleName = "Variable Demonstration"
        Button1.Location = New Point(428, 49)
        Button1.Name = "Button1"
        Button1.Size = New Size(228, 120)
        Button1.TabIndex = 1
        Button1.Text = "Variable Demonstration"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnDataTypes
        ' 
        btnDataTypes.AccessibleName = "btnDataTypes"
        btnDataTypes.Location = New Point(152, 227)
        btnDataTypes.Name = "btnDataTypes"
        btnDataTypes.Size = New Size(213, 120)
        btnDataTypes.TabIndex = 2
        btnDataTypes.Text = "btnDataTypes"
        btnDataTypes.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDataTypes)
        Controls.Add(Button1)
        Controls.Add(btnGo)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnDataTypes As Button

End Class
