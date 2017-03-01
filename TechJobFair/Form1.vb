Public Class frmTechJobFair
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblJobFairDtls.Click

    End Sub

    Private Sub btnVwJobFairDtls_Click(sender As Object, e As EventArgs) Handles btnVwJobFairDtls.Click
        lblJobFairDtls.Visible = True
        btnVwJobFairDtls.Enabled = False

    End Sub

    Private Sub frmTechJobFair_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

End Class
