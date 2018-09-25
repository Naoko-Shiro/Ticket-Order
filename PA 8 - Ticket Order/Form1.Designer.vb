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
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.nudNumberOfTickets = New System.Windows.Forms.NumericUpDown()
        Me.butTicketComposer = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblTickets = New System.Windows.Forms.Label()
        Me.cmbTicketPrices = New System.Windows.Forms.ComboBox()
        Me.lblTicketCombo = New System.Windows.Forms.Label()
        CType(Me.nudNumberOfTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(123, 49)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(113, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(123, 75)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(113, 20)
        Me.txtLastName.TabIndex = 1
        '
        'nudNumberOfTickets
        '
        Me.nudNumberOfTickets.Location = New System.Drawing.Point(136, 101)
        Me.nudNumberOfTickets.Name = "nudNumberOfTickets"
        Me.nudNumberOfTickets.Size = New System.Drawing.Size(90, 20)
        Me.nudNumberOfTickets.TabIndex = 2
        '
        'butTicketComposer
        '
        Me.butTicketComposer.Location = New System.Drawing.Point(136, 163)
        Me.butTicketComposer.Name = "butTicketComposer"
        Me.butTicketComposer.Size = New System.Drawing.Size(90, 28)
        Me.butTicketComposer.TabIndex = 3
        Me.butTicketComposer.Text = "Make Tickets"
        Me.butTicketComposer.UseVisualStyleBackColor = True
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(60, 52)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 4
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(60, 78)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 5
        Me.lblLastName.Text = "Last Name"
        '
        'lblTickets
        '
        Me.lblTickets.AutoSize = True
        Me.lblTickets.Location = New System.Drawing.Point(36, 103)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.Size = New System.Drawing.Size(94, 13)
        Me.lblTickets.TabIndex = 6
        Me.lblTickets.Text = "Number of Tickets"
        '
        'cmbTicketPrices
        '
        Me.cmbTicketPrices.FormattingEnabled = True
        Me.cmbTicketPrices.Items.AddRange(New Object() {"$20", "$30", "$50"})
        Me.cmbTicketPrices.Location = New System.Drawing.Point(123, 136)
        Me.cmbTicketPrices.Name = "cmbTicketPrices"
        Me.cmbTicketPrices.Size = New System.Drawing.Size(127, 21)
        Me.cmbTicketPrices.TabIndex = 7
        '
        'lblTicketCombo
        '
        Me.lblTicketCombo.AutoSize = True
        Me.lblTicketCombo.Location = New System.Drawing.Point(50, 139)
        Me.lblTicketCombo.Name = "lblTicketCombo"
        Me.lblTicketCombo.Size = New System.Drawing.Size(67, 13)
        Me.lblTicketCombo.TabIndex = 8
        Me.lblTicketCombo.Text = "Ticket Deals"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblTicketCombo)
        Me.Controls.Add(Me.cmbTicketPrices)
        Me.Controls.Add(Me.lblTickets)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.butTicketComposer)
        Me.Controls.Add(Me.nudNumberOfTickets)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nudNumberOfTickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents nudNumberOfTickets As System.Windows.Forms.NumericUpDown
    Friend WithEvents butTicketComposer As System.Windows.Forms.Button
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblTickets As System.Windows.Forms.Label
    Friend WithEvents cmbTicketPrices As System.Windows.Forms.ComboBox
    Friend WithEvents lblTicketCombo As System.Windows.Forms.Label

End Class
