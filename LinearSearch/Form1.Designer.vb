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
        btnLinearSearch = New Button()
        SuspendLayout()
        ' 
        ' btnLinearSearch
        ' 
        btnLinearSearch.AccessibleName = "btnLinearSearch"
        btnLinearSearch.Location = New Point(154, 102)
        btnLinearSearch.Name = "btnLinearSearch"
        btnLinearSearch.Size = New Size(222, 130)
        btnLinearSearch.TabIndex = 0
        btnLinearSearch.Text = "Linear Search"
        btnLinearSearch.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(578, 383)
        Controls.Add(btnLinearSearch)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnLinearSearch As Button

End Class
