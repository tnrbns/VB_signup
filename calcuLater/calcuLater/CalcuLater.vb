Public Class frmCalculater
    Dim x As Decimal
    Dim y As Decimal
    Dim answer As Decimal


    Private Sub lblX_Click(sender As Object, e As EventArgs) Handles lblX.Click

    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        x = Val(txbX.Text)
        y = Val(txbY.Text)
        answer = Val(lblAns.Text)

        lblAns.Text = x + y
    End Sub

    Private Sub lblAns_Click(sender As Object, e As EventArgs) Handles lblAns.Click

    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        x = Val(txbX.Text)
        y = Val(txbY.Text)
        answer = Val(lblAns.Text)

        lblAns.Text = x - y

    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        x = Val(txbX.Text)
        y = Val(txbY.Text)
        answer = Val(lblAns.Text)

        lblAns.Text = x * y
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        x = Val(txbX.Text)
        y = Val(txbY.Text)
        answer = Val(lblAns.Text)

        lblAns.Text = x / y
    End Sub

    Private Sub frmCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub txbX_TextChanged(sender As Object, e As EventArgs) Handles txbX.TextChanged

    End Sub
End Class
