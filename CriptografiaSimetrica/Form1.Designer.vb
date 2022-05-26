<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtMensagem = New System.Windows.Forms.TextBox()
        Me.btnCriptografar = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.btnDescriptografar = New System.Windows.Forms.Button()
        Me.txtMensagemDescriptografada = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtMensagem
        '
        Me.txtMensagem.BackColor = System.Drawing.Color.Azure
        Me.txtMensagem.Location = New System.Drawing.Point(12, 28)
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.Size = New System.Drawing.Size(383, 20)
        Me.txtMensagem.TabIndex = 0
        '
        'btnCriptografar
        '
        Me.btnCriptografar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCriptografar.Location = New System.Drawing.Point(12, 54)
        Me.btnCriptografar.Name = "btnCriptografar"
        Me.btnCriptografar.Size = New System.Drawing.Size(144, 23)
        Me.btnCriptografar.TabIndex = 1
        Me.btnCriptografar.Text = "Aplicar Criptografia"
        Me.btnCriptografar.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.BackColor = System.Drawing.Color.Azure
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.Location = New System.Drawing.Point(12, 114)
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(521, 101)
        Me.txtResultado.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mensagem Criptografada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mensagem para Criptografar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(407, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Senha "
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(410, 28)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(123, 20)
        Me.txtSenha.TabIndex = 6
        '
        'btnDescriptografar
        '
        Me.btnDescriptografar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescriptografar.Location = New System.Drawing.Point(12, 237)
        Me.btnDescriptografar.Name = "btnDescriptografar"
        Me.btnDescriptografar.Size = New System.Drawing.Size(179, 23)
        Me.btnDescriptografar.TabIndex = 7
        Me.btnDescriptografar.Text = "Descriptografar a mensagem"
        Me.btnDescriptografar.UseVisualStyleBackColor = True
        '
        'txtMensagemDescriptografada
        '
        Me.txtMensagemDescriptografada.Location = New System.Drawing.Point(12, 289)
        Me.txtMensagemDescriptografada.Name = "txtMensagemDescriptografada"
        Me.txtMensagemDescriptografada.Size = New System.Drawing.Size(518, 20)
        Me.txtMensagemDescriptografada.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Mensagem Descriptografada"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(545, 321)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMensagemDescriptografada)
        Me.Controls.Add(Me.btnDescriptografar)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnCriptografar)
        Me.Controls.Add(Me.txtMensagem)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exemplo de Criptografar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMensagem As System.Windows.Forms.TextBox
    Friend WithEvents btnCriptografar As System.Windows.Forms.Button
    Friend WithEvents txtResultado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents btnDescriptografar As System.Windows.Forms.Button
    Friend WithEvents txtMensagemDescriptografada As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As Label
End Class
