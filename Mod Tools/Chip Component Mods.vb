Imports GCExt

Public Class Chip_Component_Mods

    Private Sub Arrow33_Click(sender As Object, e As EventArgs) Handles Arrow33.Click
        Gf.CreateHomePlate(GCB_HOMEPLATE_PATTERN.POINTED_END_INWARD, Scan.Checked, False, New EDistance(33), False, New EDistance(0), False)
        Me.Close()
    End Sub

    Private Sub Arrow50_Click(sender As Object, e As EventArgs) Handles Arrow50.Click
        Gf.CreateHomePlate(GCB_HOMEPLATE_PATTERN.POINTED_END_INWARD, Scan.Checked, False, New EDistance(50), False, New EDistance(0), False)
        Me.Close()
    End Sub

    Private Sub Wendy50_Click(sender As Object, e As EventArgs) Handles Wendy50.Click
        Gf.CreateHomePlate(GCB_HOMEPLATE_PATTERN.FLAT_END_INWARD, Scan.Checked, False, New EDistance(50), False, New EDistance(50), False)
        Me.Close()
    End Sub

    Private Sub Invert25_Click(sender As Object, e As EventArgs) Handles Invert25.Click
        Gf.CreateCPad(GCB_CPAD_PATTERN.POINTED_BOTTOM_INWARD, Scan.Checked, False, New EDistance(25), False, New EDistance(98), False)
        Me.Close()
    End Sub

    Private Sub Invert50_Click(sender As Object, e As EventArgs) Handles Invert50.Click
        Gf.CreateCPad(GCB_CPAD_PATTERN.POINTED_BOTTOM_INWARD, Scan.Checked, False, New EDistance(50), False, New EDistance(98), False)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class