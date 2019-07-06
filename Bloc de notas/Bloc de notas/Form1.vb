Public Class Form1
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Documento.Clear()
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim Open As New OpenFileDialog()
        Dim myStreamReader As System.IO.StreamReader
        Open.Filter = "Text (*.txt)|*.txt|HTML(*.html*)|*.html|PHP(*.php*)|*.php*|All files(*.*)|*.*"
        Open.CheckPathExists = True
        Open.Title = "Abrir archivo"
        Open.ShowDialog(Me)
        Try
            myStreamReader = System.IO.File.OpenText(Open.FileName)
            Documento.Text = myStreamReader.ReadToEnd()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim Save As New SaveFileDialog()
        Dim myStreamWriter As System.IO.StreamWriter
        Save.Filter = "Text (*.txt)|*.txt|HTML(*.html*)|*.html|PHP(*.php*)|*.php*|All files(*.*)|*.*"
        Save.CheckPathExists = True
        Save.Title = "Guardar como"
        Save.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.AppendText(Save.FileName)
            myStreamWriter.Write(Documento.Text)
            myStreamWriter.Flush()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click
        Dim Save As New SaveFileDialog()
        Dim myStreamWriter As System.IO.StreamWriter
        Save.Filter = "Text (*.txt)|*.txt|HTML(*.html*)|*.html|PHP(*.php*)|*.php*|All files(*.*)|*.*"
        Save.CheckPathExists = True
        Save.Title = "Guardar como"
        Save.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.AppendText(Save.FileName)
            myStreamWriter.Write(Documento.Text)
            myStreamWriter.Flush()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Documento_TextChanged(sender As Object, e As EventArgs) Handles Documento.TextChanged

    End Sub

    Private Sub AtrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtrasToolStripMenuItem.Click
        Documento.Undo()
    End Sub

    Private Sub AdelanteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdelanteToolStripMenuItem.Click
        Documento.Redo()
    End Sub

    Private Sub CopearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopearToolStripMenuItem.Click
        Documento.Copy()
    End Sub

    Private Sub CortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        Documento.Cut()
    End Sub

    Private Sub PegarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegarToolStripMenuItem.Click
        Documento.Paste()
    End Sub

    Private Sub SeleccionarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodoToolStripMenuItem.Click
        Documento.Select()
    End Sub

    Private Sub DeshacerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeshacerToolStripMenuItem.Click
        Documento.Clear()
    End Sub

    Private Sub FuenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuenteToolStripMenuItem.Click
        Try
            Dim dlg As FontDialog = New FontDialog
            dlg.Font = Documento.Font
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Documento.Font = dlg.Font
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        Dim dlg As ColorDialog = New ColorDialog
        dlg.Color = Documento.ForeColor
        If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Documento.ForeColor = dlg.Color
        End If
    End Sub
End Class
