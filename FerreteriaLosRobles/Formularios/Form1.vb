Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Probar conexión primero
        Dim msg As String = ""
        If ConexionBD.ProbarConexion(msg) Then
            MessageBox.Show("¡Conexión exitosa a MariaDB!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Cargar los productos en la tabla
            Dim repo As New ProductoRepositorio()
            DataGridView1.DataSource = repo.ListarProductos()
        Else
            MessageBox.Show("Error de conexión: " & msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim nuevoProducto As New Producto()
            nuevoProducto.codigo = TextBoxCodigo.Text
            nuevoProducto.nombre = TextBoxNombre.Text
            nuevoProducto.id_categoria = 1
            nuevoProducto.unidad = "Unidad"
            nuevoProducto.precio = 50.0
            nuevoProducto.existencia = 10
            nuevoProducto.activo = True

            Dim repo As New ProductoRepositorio()
            repo.InsertarProducto(nuevoProducto)

            MessageBox.Show("¡Producto guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            DataGridView1.DataSource = repo.ListarProductos()

        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class