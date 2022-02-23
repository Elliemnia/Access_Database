Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Karate_1DataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me._Karate_1DataSet.Members)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.MembersTableAdapter.FillBy(Me._Karate_1DataSet.Members, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            Me.MembersTableAdapter.FillBy(Me._Karate_1DataSet.Members, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class