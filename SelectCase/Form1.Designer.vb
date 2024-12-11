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
        txtTemperature = New TextBox()
        btnCheck = New Button()
        SuspendLayout()
        ' 
        ' txtTemperature
        ' 
        txtTemperature.AccessibleName = "txtTemperature"
        txtTemperature.Location = New Point(201, 88)
        txtTemperature.Name = "txtTemperature"
        txtTemperature.Size = New Size(199, 23)
        txtTemperature.TabIndex = 0
        ' 
        ' btnCheck
        ' 
        btnCheck.AccessibleName = "btnCheck"
        btnCheck.Location = New Point(201, 139)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(216, 96)
        btnCheck.TabIndex = 1
        btnCheck.Text = "Check Temperature"
        btnCheck.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCheck)
        Controls.Add(txtTemperature)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents btnCheck As Button

End Class
