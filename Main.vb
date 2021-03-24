#Region "To-Do List"
'Create UI
'Create Slash Screen

#End Region


Public Class Main

#Region "Variables"
    Private cw As New cold_war
#End Region

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If txtWeapon.Text IsNot String.Empty Then
            txtWeapon.Text = String.Empty
            txtField.Text = String.Empty
            txtAmmo.Text = String.Empty
            cw.loadout()

        Else
            cw.loadout()
        End If

    End Sub

End Class
