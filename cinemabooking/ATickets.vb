Imports System.Data.SqlClient

Public Class ATickets
    Private Sub btnDelete_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)

    End Sub
    Dim Ccon As New CGeneral
    Dim t_id As Integer

    Private defaultQuery As String = "SELECT t.Id AS ID ,c.name AS ClientName, c.lastname AS ClientLastName, m.name AS MovieName, s.name AS SalonName, " &
                                     "FORMAT(sh.date, 'dd/MM/yyyy') AS ShowDate, sh.time AS ShowTime, t.ticketdate AS TicketDate, t.totalprice AS TotalPrice " &
                                     "FROM Clients AS c " &
                                     "INNER JOIN Transactions AS t ON c.id = t.client_id " &
                                     "INNER JOIN Shows AS sh ON t.show_id = sh.id " &
                                     "INNER JOIN Movies AS m ON sh.movie_id = m.id " &
                                     "INNER JOIN Salons AS s ON sh.salon_id = s.id "


    Private Sub ATickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BaslatListView()
        BaslatListView2()
        YukleVeri()
    End Sub

    Private Sub BaslatListView2()
        lv_tickets.View = View.Details
        lv_tickets.FullRowSelect = True
        lv_tickets.Columns.Add("Koltuk Numarası")
        lv_tickets.Columns.Add("Bilet Fiyatı")
        lv_tickets.Columns.Add("Tarife")


        For Each column As ColumnHeader In lv_tickets.Columns
            column.Width = 100
        Next

        'AddHandler lv_Ticket.SelectedIndexChanged, AddressOf lv_Ticket_SelectedIndexChanged
    End Sub
    Private Sub BaslatListView()
        lv_Ticket.View = View.Details
        lv_Ticket.FullRowSelect = True
        lv_Ticket.Columns.Add("Id")
        lv_Ticket.Columns.Add("Ad Soyad")
        lv_Ticket.Columns.Add("Film Ad")
        lv_Ticket.Columns.Add("Salon Ad")
        lv_Ticket.Columns.Add("Gösterim Tarih/Saat")
        lv_Ticket.Columns.Add("Bilet Kesim Tarih/Saat")
        lv_Ticket.Columns.Add("Toplam Tutar")



        For Each column As ColumnHeader In lv_Ticket.Columns
            column.Width = 80
        Next

        AddHandler lv_Ticket.SelectedIndexChanged, AddressOf lv_Ticket_SelectedIndexChanged
    End Sub

    Private Sub YukleVeri()
        DoldurListView(defaultQuery)
    End Sub

    Private Sub DoldurListView(ByVal query As String)
        Dim con As New SqlConnection(Ccon.connection)
        Dim command As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable()
        adapter.Fill(dataTable)

        lv_Ticket.Items.Clear()

        For Each row As DataRow In dataTable.Rows
            Dim item As New ListViewItem(row("Id").ToString())
            item.SubItems.Add(row("ClientName").ToString() & " " & row("ClientLastName").ToString())
            item.SubItems.Add(row("MovieName").ToString())
            item.SubItems.Add(row("SalonName").ToString())
            item.SubItems.Add(row("ShowDate").ToString() & " " & row("ShowTime").ToString())
            item.SubItems.Add(row("TicketDate").ToString())
            item.SubItems.Add(row("TotalPrice").ToString())

            lv_Ticket.Items.Add(item)
        Next
    End Sub

    Private Sub lv_Ticket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lv_Ticket.SelectedIndexChanged
        If lv_Ticket.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lv_Ticket.SelectedItems(0)
            t_id = selectedItem.SubItems(0).Text
            Label7.Text = selectedItem.SubItems(1).Text
            Label9.Text = selectedItem.SubItems(2).Text
            Label11.Text = selectedItem.SubItems(3).Text
            Label10.Text = selectedItem.SubItems(4).Text
            Label12.Text = selectedItem.SubItems(5).Text
            Label13.Text = selectedItem.SubItems(6).Text
            DoldurTickets()
        End If
    End Sub

    Private Sub DoldurTickets()
        Dim query As String = "SELECT seat, price, tariff FROM Tickets WHERE transaction_id = @transaction_id"

        Using connection As New SqlConnection(Ccon.connection)
            connection.Open()

            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@transaction_id", t_id)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    ' lv_clients tablosunu temizle
                    lv_tickets.Items.Clear()

                    While reader.Read()
                        ' Her bir satırı oku ve lv_clients tablosuna ekle
                        Dim seat As String = reader.GetString(0)
                        Dim price As Decimal = reader.GetDecimal(1)
                        Dim tariff As String = reader.GetString(2)

                        Dim row As New ListViewItem(seat)
                        row.SubItems.Add(price.ToString())
                        row.SubItems.Add(tariff)
                        lv_tickets.Items.Add(row)
                    End While
                End Using
            End Using
        End Using
    End Sub
End Class