Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class AReports
    Dim Ccon As New CGeneral

    Private Sub AReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToplamAylik()
        ToplamBilet()
        FilmGelir()
        EnCokSatanFilmler()
        AylikYiyecekGelirGrafik()
    End Sub

    Public aylar As New Dictionary(Of Integer, String) From {
        {1, "Ocak"}, {2, "Şubat"}, {3, "Mart"}, {4, "Nisan"},
        {5, "Mayıs"}, {6, "Haziran"}, {7, "Temmuz"}, {8, "Ağustos"},
        {9, "Eylül"}, {10, "Ekim"}, {11, "Kasım"}, {12, "Aralık"}}
    Private Sub ToplamAylik()
        Using connection As New SqlConnection(Ccon.connection)
            connection.Open()

            Dim query As String = "SELECT MONTH(ticketdate) AS t_ay, SUM(totalprice) AS t_price FROM Transactions GROUP BY MONTH(ticketdate)"

            Dim command As New SqlCommand(query, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()

            While reader.Read()
                Dim ayNum As Integer = Convert.ToInt32(reader("t_ay"))
                Dim ayAdi As String = aylar(ayNum)
                Dim satis As Decimal = Convert.ToDecimal(reader("t_price"))

                Chart1.Series("Kazanç").Points.AddXY(ayAdi, satis)
            End While

            reader.Close()
        End Using
    End Sub


    Private Sub ToplamBilet()
        Using connection As New SqlConnection(Ccon.connection)
            connection.Open()

            Dim query As String = "SELECT MONTH(tr.ticketdate) AS ay, COUNT(t.id) AS satilmisbilet " &
                                  "FROM Transactions tr " &
                                  "INNER JOIN Tickets t ON tr.Id = t.transaction_id " &
                                  "GROUP BY YEAR(tr.ticketdate), MONTH(tr.ticketdate) " &
                                  "ORDER BY ay"

            Dim command As New SqlCommand(query, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()

            While reader.Read()
                Dim ayNum As Integer = Convert.ToInt32(reader("ay"))
                Dim ayAdi As String = aylar(ayNum)
                Dim satilanBiletSayisi As Integer = Convert.ToInt32(reader("satilmisbilet"))

                Chart2.Series("Satılan Biletler").Points.AddXY(ayAdi, satilanBiletSayisi)
            End While

            reader.Close()
        End Using
    End Sub

    Private Sub FilmGelir()
        Using connection As New SqlConnection(Ccon.connection)
            connection.Open()

            Dim query As String = "
            SELECT
                m.name AS movie_title,
                SUM(tr.totalprice) AS total_revenue
            FROM
                Transactions tr
            INNER JOIN
                Shows sh ON tr.show_id = sh.id
            INNER JOIN
                Movies m ON sh.movie_id = m.id
            GROUP BY
                m.name;"

            Dim command As New SqlCommand(query, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()

            While reader.Read()
                Dim movieTitle As String = reader("movie_title").ToString()
                Dim totalRevenue As Decimal = Convert.ToDecimal(reader("total_revenue"))

                Chart4.Series("Kazanç").Points.AddXY(movieTitle, totalRevenue)
            End While

            reader.Close()
        End Using
    End Sub

    Private Sub EnCokSatanFilmler()
        Using connection As New SqlConnection(Ccon.connection)
            connection.Open()

            Dim query As String = "
            SELECT TOP 3
                m.name AS movie_title,
                COUNT(t.id) AS total_tickets_sold
            FROM 
                Tickets t
            INNER JOIN 
                Transactions tr ON t.transaction_id = tr.Id
            INNER JOIN 
                Shows s ON tr.show_id = s.id
            INNER JOIN 
                Movies m ON s.movie_id = m.id
            GROUP BY 
                m.name
            ORDER BY 
                total_tickets_sold DESC;"

            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)


            Chart3.Series.Add("Satılan Biletler")
            Chart3.Series("Satılan Biletler").ChartType = DataVisualization.Charting.SeriesChartType.Column

            For Each row As DataRow In dataTable.Rows
                Dim movieTitle As String = row("movie_title").ToString()
                Dim totalTicketsSold As Integer = Convert.ToInt32(row("total_tickets_sold"))
                Chart3.Series("Satılan Biletler").Points.AddXY(movieTitle, totalTicketsSold)
            Next

        End Using
    End Sub

    Private Sub AylikYiyecekGelirGrafik()
        Using connection As New SqlConnection(Ccon.connection)
            connection.Open()

            Dim query As String = "
            SELECT
                MONTH(Date) AS ay,
                SUM(Total) AS aylik_gelir
            FROM
                Payments
            GROUP BY
                MONTH(Date)
            ORDER BY
                ay;"

            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)

            Chart5.Series.Clear()
            Chart5.ChartAreas.Clear()
            Chart5.ChartAreas.Add("ChartArea1")
            Chart5.Series.Add("Aylık Gelir")
            Chart5.Series("Aylık Gelir").ChartType = DataVisualization.Charting.SeriesChartType.Column

            For Each row As DataRow In dataTable.Rows
                Dim ay As Integer = Convert.ToInt32(row("ay"))
                Dim aylikGelir As Decimal = Convert.ToDecimal(row("aylik_gelir"))
                Chart5.Series("Aylık Gelir").Points.AddXY(CDate(ay & "/1/2000").ToString("MMM"), aylikGelir)
            Next
        End Using
    End Sub
End Class