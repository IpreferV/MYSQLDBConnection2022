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
        btnTest = New Button()
        SuspendLayout()
        ' 
        ' btnTest
        ' 
        btnTest.Location = New Point(277, 143)
        btnTest.Name = "btnTest"
        btnTest.Size = New Size(156, 38)
        btnTest.TabIndex = 0
        btnTest.Text = "MYSQL TEST"
        btnTest.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1257, 660)
        Controls.Add(btnTest)
        Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(5, 4, 5, 4)
        Name = "Form1"
        Text = "MYSQL DATABASE CONNECTION"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnTest As Button

End Class
