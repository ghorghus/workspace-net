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
        btnRowWise = New Button()
        btncolumnwise = New Button()
        btnallatonce = New Button()
        btnsearch = New Button()
        SuspendLayout()
        ' 
        ' btnRowWise
        ' 
        btnRowWise.AccessibleName = "btnRowWise"
        btnRowWise.Location = New Point(253, 44)
        btnRowWise.Name = "btnRowWise"
        btnRowWise.Size = New Size(242, 81)
        btnRowWise.TabIndex = 0
        btnRowWise.Text = "Display data items row wise"
        btnRowWise.UseVisualStyleBackColor = True
        ' 
        ' btncolumnwise
        ' 
        btncolumnwise.AccessibleName = "btncolumnwise"
        btncolumnwise.Location = New Point(253, 163)
        btncolumnwise.Name = "btncolumnwise"
        btncolumnwise.Size = New Size(242, 81)
        btncolumnwise.TabIndex = 1
        btncolumnwise.Text = "Display data items column wise"
        btncolumnwise.UseVisualStyleBackColor = True
        ' 
        ' btnallatonce
        ' 
        btnallatonce.AccessibleName = "btnallatonce"
        btnallatonce.Location = New Point(253, 282)
        btnallatonce.Name = "btnallatonce"
        btnallatonce.Size = New Size(242, 81)
        btnallatonce.TabIndex = 2
        btnallatonce.Text = "Display all data items at once"
        btnallatonce.UseVisualStyleBackColor = True
        ' 
        ' btnsearch
        ' 
        btnsearch.AccessibleName = "btnsearch"
        btnsearch.Location = New Point(253, 391)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(242, 81)
        btnsearch.TabIndex = 3
        btnsearch.Text = "Search for a person"
        btnsearch.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(749, 562)
        Controls.Add(btnsearch)
        Controls.Add(btnallatonce)
        Controls.Add(btncolumnwise)
        Controls.Add(btnRowWise)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnRowWise As Button
    Friend WithEvents btncolumnwise As Button
    Friend WithEvents btnallatonce As Button
    Friend WithEvents btnsearch As Button

End Class
