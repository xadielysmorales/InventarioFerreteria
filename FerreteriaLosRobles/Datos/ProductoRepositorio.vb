Imports MySqlConnector

Public Class ProductoRepositorio

    Public Function ListarProductos() As List(Of Producto)
        Dim lista As New List(Of Producto)()
        Dim query As String = "SELECT id_producto, codigo, nombre, id_categoria, unidad, precio, existencia, activo FROM productos"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(query, cn)
                cn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim p As New Producto()
                        p.id_producto = Convert.ToInt32(reader("id_producto"))
                        p.id_categoria = Convert.ToInt32(reader("id_categoria"))
                        p.codigo = reader("codigo").ToString()
                        p.nombre = reader("nombre").ToString()
                        p.unidad = reader("unidad").ToString()
                        p.precio = Convert.ToDecimal(reader("precio"))
                        p.existencia = Convert.ToInt32(reader("existencia"))
                        p.activo = Convert.ToBoolean(reader("activo"))
                        lista.Add(p)
                    End While
                End Using
            End Using
        End Using
        Return lista
    End Function

    Public Sub InsertarProducto(p As Producto)
        Dim query As String = "INSERT INTO productos (codigo, nombre, id_categoria, unidad, precio, existencia, activo) " &
                              "VALUES (@codigo, @nombre, @id_categoria, @unidad, @precio, @existencia, @activo)"

        Using cn As MySqlConnection = ConexionBD.ObtenerConexion()
            Using cmd As New MySqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@codigo", p.codigo)
                cmd.Parameters.AddWithValue("@nombre", p.nombre)
                cmd.Parameters.AddWithValue("@id_categoria", p.id_categoria)
                cmd.Parameters.AddWithValue("@unidad", p.unidad)
                cmd.Parameters.AddWithValue("@precio", p.precio)
                cmd.Parameters.AddWithValue("@existencia", p.existencia)
                cmd.Parameters.AddWithValue("@activo", p.activo)

                cn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
