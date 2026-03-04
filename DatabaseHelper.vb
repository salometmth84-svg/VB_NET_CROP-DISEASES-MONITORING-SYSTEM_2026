Imports Microsoft.Data.Sqlite
Imports System.Security.Cryptography
Imports System.Text

Public Class DatabaseHelper
    Private Shared DbPath As String = "cropdisease.db"

    Private Shared Function GetConnection() As SqliteConnection
        Return New SqliteConnection($"Data Source={DbPath}")
    End Function

    Shared Sub InitializeDatabase()
        Using conn = GetConnection()
            conn.Open()
            Dim sql = "
                CREATE TABLE IF NOT EXISTS Users (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL UNIQUE,
                    PasswordHash TEXT NOT NULL);
                CREATE TABLE IF NOT EXISTS Crops (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    CropName TEXT NOT NULL,
                    FarmerName TEXT NOT NULL);
                CREATE TABLE IF NOT EXISTS Diseases (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    CropID INTEGER NOT NULL,
                    DiseaseName TEXT NOT NULL,
                    Symptoms TEXT,
                    Severity TEXT,
                    DateRecorded TEXT,
                    FOREIGN KEY (CropID) REFERENCES Crops(ID));"
            Dim cmd As New SqliteCommand(sql, conn)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Shared Function HashPassword(password As String) As String
        Using md5 As MD5 = MD5.Create()
            Dim bytes() As Byte =
                md5.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim sb As New StringBuilder()
            For Each b As Byte In bytes
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function

    Shared Function RegisterUser(username As String, password As String) As Boolean
        Try
            Using conn = GetConnection()
                conn.Open()
                Dim sql = "INSERT INTO Users (Username, PasswordHash) VALUES (@u, @p)"
                Dim cmd As New SqliteCommand(sql, conn)
                cmd.Parameters.AddWithValue("@u", username)
                cmd.Parameters.AddWithValue("@p", HashPassword(password))
                cmd.ExecuteNonQuery()
                Return True
            End Using
        Catch ex As SqliteException
            Return False
        End Try
    End Function

    Shared Function ValidateLogin(username As String, password As String) As Boolean
        Using conn = GetConnection()
            conn.Open()
            Dim sql = "SELECT COUNT(*) FROM Users WHERE Username=@u AND PasswordHash=@p"
            Dim cmd As New SqliteCommand(sql, conn)
            cmd.Parameters.AddWithValue("@u", username)
            cmd.Parameters.AddWithValue("@p", HashPassword(password))
            Return CInt(cmd.ExecuteScalar()) > 0
        End Using
    End Function

    Shared Sub AddCrop(cropName As String, farmerName As String)
        Using conn = GetConnection()
            conn.Open()
            Dim sql = "INSERT INTO Crops (CropName, FarmerName) VALUES (@c, @f)"
            Dim cmd As New SqliteCommand(sql, conn)
            cmd.Parameters.AddWithValue("@c", cropName)
            cmd.Parameters.AddWithValue("@f", farmerName)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Shared Function GetCrops() As DataTable
        Dim dt As New DataTable()
        Using conn = GetConnection()
            conn.Open()
            Dim cmd As New SqliteCommand("SELECT ID, CropName FROM Crops", conn)
            Using reader = cmd.ExecuteReader()
                dt.Load(reader)
            End Using
        End Using
        Return dt
    End Function

    Shared Sub AddDisease(cropID As Integer, diseaseName As String,
                   symptoms As String, severity As String,
                   dateRecorded As String)
        Using conn = GetConnection()
            conn.Open()
            Dim sql = "INSERT INTO Diseases (CropID, DiseaseName, Symptoms, Severity, DateRecorded)" &
                      " VALUES (@cid, @dn, @sy, @sev, @dt)"
            Dim cmd As New SqliteCommand(sql, conn)
            cmd.Parameters.AddWithValue("@cid", cropID)
            cmd.Parameters.AddWithValue("@dn", diseaseName)
            cmd.Parameters.AddWithValue("@sy", symptoms)
            cmd.Parameters.AddWithValue("@sev", severity)
            cmd.Parameters.AddWithValue("@dt", dateRecorded)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Shared Function GetDiseases() As DataTable
        Dim dt As New DataTable()
        Using conn = GetConnection()
            conn.Open()
            Dim sql = "SELECT d.ID, c.CropName, d.DiseaseName," &
                      " d.Symptoms, d.Severity, d.DateRecorded" &
                      " FROM Diseases d INNER JOIN Crops c ON d.CropID = c.ID"
            Dim cmd As New SqliteCommand(sql, conn)
            Using reader = cmd.ExecuteReader()
                dt.Load(reader)
            End Using
        End Using
        Return dt
    End Function

End Class
