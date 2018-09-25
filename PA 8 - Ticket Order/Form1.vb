Public Class Form1

    Private Sub butTicketComposer_Click(sender As Object, e As EventArgs) Handles butTicketComposer.Click
        If (cmbTicketPrices.SelectedItem = "$20") Then
            MessageBox.Show(txtFirstName.Text & " " & txtLastName.Text & " ordered " & nudNumberOfTickets.Value & " tickets for a total cost of $" & nudNumberOfTickets.Value * 20 & ".")
        End If
        If (cmbTicketPrices.SelectedItem = "$30") Then
            MessageBox.Show(txtFirstName.Text & " " & txtLastName.Text & " ordered " & nudNumberOfTickets.Value & " tickets for a total cost of $" & nudNumberOfTickets.Value * 30 & ".")
        End If
        If (cmbTicketPrices.SelectedItem= "$50") Then
            MessageBox.Show(txtFirstName.Text & " " & txtLastName.Text & " ordered " & nudNumberOfTickets.Value & " tickets for a total cost of $" & nudNumberOfTickets.Value * 50 & ".")
        End If
    End Sub
End Class
