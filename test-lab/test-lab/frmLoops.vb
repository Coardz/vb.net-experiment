Public Class frmLoops
    Dim stOut As String
    Dim day As Integer
    Dim attempts As Integer = 0
    Dim success As Boolean

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If IsNumeric(tbDay.Text) = True Then
            day = tbDay.Text
            While day <= 7
                MessageBox.Show(day)
                day = day + 1
            End While
        Else
            MessageBox.Show("Invalid Input", "Error")
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        For intCash As Integer = 0 To 250 Step 50
            'explnation for code above
            'we set a new value named intCash as integer and set the value to 0
            'we made a condition that will make it stop if it reach 250
            'Step 50 is increment it means it will increament 50 every loop
            stOut = stOut & intCash & vbNewLine
            ' so let's breakdown the code above
            ' stOut is empty string variable
            'we put it inside the loop
            'so something like this happen 0, 50, 100, 150, 200, 250
            'we add vbNewLine so it would start on new line
        Next

        MessageBox.Show(stOut)
        'this will output the store string in stOut


        'Normal Output
        'For cash As Integer = 0 To 250 Step 50
        '    MessageBox.Show("Balance " & cash)
        'Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Do While True
            Dim code = InputBox("Please input your code")
            attempts += 1

            If code = "2006" Then
                success = True
                Exit Do
            End If

            If attempts = 3 Then
                success = False
                Exit Do
            End If

        Loop

        If success = True Then
            MessageBox.Show("Congrats " & attempts)
        Else
            MessageBox.Show("Failed " & attempts)
        End If
    End Sub
End Class