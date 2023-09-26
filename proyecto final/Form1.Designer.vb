<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class proyecto
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(proyecto))
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        resources.ApplyResources(Button1, "Button1")
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Name = "Button1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        resources.ApplyResources(Button2, "Button2")
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.Name = "Button2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        resources.ApplyResources(Button3, "Button3")
        Button3.BackColor = SystemColors.ActiveCaption
        Button3.Name = "Button3"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' proyecto
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Cursor = Cursors.SizeAll
        Name = "proyecto"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
