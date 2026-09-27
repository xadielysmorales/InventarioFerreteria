<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        TextBoxCodigo = New TextBox()
        Button2 = New Button()
        TextBoxNombre = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(28, 189)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(742, 231)
        DataGridView1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(133, 136)
        Button1.Name = "Button1"
        Button1.Size = New Size(158, 29)
        Button1.TabIndex = 2
        Button1.Text = "Cargar Productos"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBoxCodigo
        ' 
        TextBoxCodigo.Location = New Point(133, 50)
        TextBoxCodigo.Name = "TextBoxCodigo"
        TextBoxCodigo.Size = New Size(161, 27)
        TextBoxCodigo.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(505, 136)
        Button2.Name = "Button2"
        Button2.Size = New Size(151, 29)
        Button2.TabIndex = 4
        Button2.Text = "Guardar Producto"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Location = New Point(463, 47)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(218, 27)
        TextBoxNombre.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(59, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 20)
        Label1.TabIndex = 6
        Label1.Text = "Código :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(377, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 20)
        Label2.TabIndex = 7
        Label2.Text = "Nombre :"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBoxNombre)
        Controls.Add(Button2)
        Controls.Add(TextBoxCodigo)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Name = "Form1"
        Text = "FerreteriaLosRobles - Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxCodigo As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
