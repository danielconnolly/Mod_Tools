Imports GCExt


Public Class Reductions



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Absolute_Reduction(txtAbsX.Text, txtAbsY.Text, cboAbsShapes.SelectedItem, True)
        Web()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Percentage_Reduction(txtPercentX.Text, txtPercentX.Text, cboAbsShapes.SelectedItem, True)
        Web()
        Me.Close()
    End Sub

    Private Sub btnPercentRed_Click(sender As Object, e As EventArgs) Handles btnPercentRed.Click
        Percentage_Reduction(txtPercentX.Text, txtPercentY.Text, cboAbsShapes.SelectedItem)
        Me.Close()
    End Sub

    Private Sub btnAbsRed_Click(sender As Object, e As EventArgs) Handles btnAbsRed.Click
        Absolute_Reduction(txtAbsX.Text, txtAbsY.Text, cboAbsShapes.SelectedItem)
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUnits.SelectedIndexChanged
        Select Case cboUnits.SelectedItem
            Case "mm"
                Get_Apr_Info(True, GCB_UNITS.MM)
            Case "inches"
                Get_Apr_Info(True, GCB_UNITS.INCH)
            Case "thou"
                Get_Apr_Info(True, GCB_UNITS.MIL)
        End Select
        Update_Info()
    End Sub

    Private Sub Reductions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Get_Apr_Info(False)
        Update_Info()
    End Sub

    Sub Update_Info()

        txtAbsX.Text = Dim_x
        txtAbsY.Text = Dim_y
        cboAbsShapes.SelectedItem = Shape
        cboPercentShape.SelectedItem = Shape
        cboUnits.SelectedItem = Units
        lblAbsUnitsX.Text = " " & Units
        lblAbsUnitsY.Text = " " & Units
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class