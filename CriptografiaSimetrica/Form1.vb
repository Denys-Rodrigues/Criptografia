Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Public Class Form1

    Dim textoCifrado As Byte()
    Dim sal() As Byte = {&H0, &H1, &H2, &H3, &H4, &H5, &H6, &H5, &H4, &H3, &H2, &H1, &H0}
    Dim senha As String = ""
    Dim mensagem As String = ""

    Private Sub btnCriptografar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCriptografar.Click

        senha = txtSenha.Text
        mensagem = txtMensagem.Text

        Dim chave As New Rfc2898DeriveBytes(senha, sal)
        ' criptografa os dados
        Dim algoritmo = New RijndaelManaged()

        algoritmo.Key = chave.GetBytes(16)
        algoritmo.IV = chave.GetBytes(16)

        Dim fonteBytes() As Byte = New System.Text.UnicodeEncoding().GetBytes(mensagem)

        Using StreamFonte = New MemoryStream(fonteBytes)
            Using StreamDestino As New MemoryStream()
                Using crypto As New CryptoStream(StreamFonte, algoritmo.CreateEncryptor(), CryptoStreamMode.Read)
                    moveBytes(crypto, StreamDestino)
                    textoCifrado = StreamDestino.ToArray()
                End Using
            End Using
        End Using

        'MessageBox.Show(String.Format("Mensagem : {0}{1} Criptografada : {2}", mensagem, Environment.NewLine, Convert.ToBase64String(textoCifrado)))

        txtResultado.Text = txtResultado.Text + Convert.ToBase64String(textoCifrado) + "    ::  senha => " + txtSenha.Text + Environment.NewLine

    End Sub

    Private Sub moveBytes(ByVal fonte As Stream, ByVal destino As Stream)
        Dim bytes(2048) As Byte
        Dim contador = fonte.Read(bytes, 0, bytes.Length - 1)
        While (0 <> contador)
            destino.Write(bytes, 0, contador)
            contador = fonte.Read(bytes, 0, bytes.Length - 1)
        End While
    End Sub

    Private Sub btnDescriptografar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDescriptografar.Click

        If (textoCifrado Is Nothing) Then
            MessageBox.Show("Os dados não estão criptografados!")
            Return
        End If

        Dim chave As New Rfc2898DeriveBytes(senha, sal)
        Dim algoritmo = New RijndaelManaged()

        algoritmo.Key = chave.GetBytes(16)
        algoritmo.IV = chave.GetBytes(16)
        Using StreamFonte = New MemoryStream(textoCifrado)
            Using StreamDestino As New MemoryStream()
                Using crypto As New CryptoStream(StreamFonte, algoritmo.CreateDecryptor(), CryptoStreamMode.Read)
                    moveBytes(crypto, StreamDestino)
                    Dim bytesDescriptografados() As Byte = StreamDestino.ToArray()
                    Dim mensagemDescriptografada = New UnicodeEncoding().GetString(bytesDescriptografados)
                    txtMensagemDescriptografada.Text = mensagemDescriptografada
                End Using
            End Using
        End Using
    End Sub

    Private Sub txtMensagem_TextChanged(sender As Object, e As EventArgs) Handles txtMensagem.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
