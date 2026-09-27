Imports MySqlConnector

Public Module ConexionBD

    ' Cadena de conexión a MariaDB (Puerto 3307)
    Private Const CadenaConexion As String =
        "Server=localhost;" &
        "Port=3307;" &
        "Database=ferreteria_db;" &
        "User Id=ferre_app;" &
        "Password=Ferreteria2024*;" &
        "SslMode=None;"

    Public Function ObtenerConexion() As MySqlConnection
        Return New MySqlConnection(CadenaConexion)
    End Function

    Public Function ProbarConexion(ByRef mensaje As String) As Boolean
        Try
            Using cn As MySqlConnection = ObtenerConexion()
                cn.Open()
                mensaje = $"Conectado a MariaDB {cn.ServerVersion}"
                Return True
            End Using
        Catch ex As MySqlException
            mensaje = ex.Message
            Return False
        End Try
    End Function

End Module