Public Class frmLogicalOperator

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' we declare dimension a and b as integer
        Dim a, b As Integer

        If IsNumeric(tbA.Text) = True And IsNumeric(tbB.Text) = True Then
            ' we assign variables to textbox
            a = CInt(tbA.Text)
            b = CInt(tbB.Text)

            ' we make logical operator to identitfy if a is bigger than b
            If a > b Then
                MessageBox.Show("A is bigger than B")
                ' we make logical operator to identitfy if b is bigger than a
            ElseIf b > a Then
                MessageBox.Show("B is bigger than A")
            Else
                MessageBox.Show("Equal")
            End If
        Else
            MessageBox.Show("Please input numeric type")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim intAge As Integer

        If IsNumeric(tbAge.Text) = True Then
            intAge = CInt(tbAge.Text)
            Select Case intAge
                Case 0 To 17
                    MessageBox.Show("Minor")
                Case 18 To 59
                    MessageBox.Show("Adult")
                Case Is >= 60
                    MessageBox.Show("Senior")
                Case Else
                    MessageBox.Show("Invalid Input")
            End Select
        Else
            MessageBox.Show("Please input numeric type")
        End If

    End Sub
End Class
