Imports GCExt
Imports System.IO

Module Main_Routines



    Public Count, Temp, Temp2 As Integer
    Public Pnum, PadNum, AlistNum As Integer
    Public Dim_x, Dim_y As Double

    Public MyPadList As New EPadList
    Public P As New EPhysicalLayers
    Public PhysTemp As New EPhysicalLayer
    Public Dattemp As New EDatalayer
    Public A As New EALists
    Public Alist_a As New EAList
    Public Apr As New EAper

    Public Units As String
    Public User_Units As GCB_UNITS
    Public Shape As String
    Public gShape As GCB_APER_TYPE
    Public gUnits As GCB_UNITS


    Sub Web()

        Dim Web_X, Web_Y As Integer

        Gf.JobUnit = GCB_UNITS.MM

        Dim_x = Apr.Dim1
        Dim_y = Apr.Dim2

        If Not Str(Val(Apr.Type)) < 6 Then
            MsgBox("Error: Cannot web this shape")
            Stop
        End If

        Web_X = Dim_x \ 4.5
        Web_Y = Dim_y \ 4.5

        Dim f As New Webbing_Mods
        f.lblDimX.Text = "X:" & Dim_x & " mm"
        f.lblDimY.Text = "Y:" & Dim_y & " mm"
        f.txtWebX.Text = Web_X
        f.txtWebY.Text = Web_Y
        f.ShowDialog()

    End Sub


    Sub Absolute_Reduction(NewX As Double, NewY As Double, NewShape As String, Optional LeaveVisible As Boolean = False)
        Dim OldX, OldY As Double
        Dim Oldshape As String

        OldX = Dim_x
        OldY = Dim_y
        Oldshape = Shape


        If (Val(NewX) / OldX) > 1.5 Or (Val(NewY) / OldY) > 1.5 Then
            If MsgBox("Are you sure you want to increase the size this much? " & Str(OldX) & " x " & Str(OldY) & " --> " & NewX & " x " & NewY, MsgBoxStyle.OkCancel, "Are you mad!") = MsgBoxResult.Cancel Then Stop
        End If

        If (Val(NewX) / OldX) < 0.5 Or (Val(NewY) / OldY) < 0.5 Then
            If MsgBox("Are you sure you want to reduce the size this much? " & Str(OldX) & " x " & Str(OldY) & " --> " & NewX & " x " & NewY, MsgBoxStyle.OkCancel, "Are you mad!") = MsgBoxResult.Cancel Then Stop
        End If

        Select Case NewShape
            Case "Draw"
                Apr.SetNonCustom(GCB_APER_TYPE.DRAW, NewX, NewY)
                Apr.IsVisible = LeaveVisible
            Case "Round"
                Apr.SetNonCustom(GCB_APER_TYPE.ROUND, NewX, NewY)
                Apr.IsVisible = LeaveVisible
            Case "Square"
                Apr.SetNonCustom(GCB_APER_TYPE.SQUARE, NewX, NewY)
                Apr.IsVisible = LeaveVisible
            Case "Rectangle"
                Apr.SetNonCustom(GCB_APER_TYPE.RECTANGLE, NewX, NewY)
                Apr.IsVisible = LeaveVisible
            Case "Oblong"
                Apr.SetNonCustom(GCB_APER_TYPE.OBLONG, NewX, NewY)
                Apr.IsVisible = LeaveVisible
            Case Else
                MsgBox("Error: Unknown shape!")
                Stop
        End Select
    End Sub

    Sub Percentage_Reduction(PercentX As Double, PercentY As Double, NewShape As String, Optional LeaveVisible As Boolean = False)
        Dim OldX, NewX, OldY, NewY As Double
        Dim Oldshape As String

        OldX = Dim_x
        OldY = Dim_y
        Oldshape = Shape

        NewX = Math.Round(OldX * (PercentX / 100), 3)
        NewY = Math.Round(OldY * (PercentY / 100), 3)

        If PercentX > 150 Or PercentY > 150 Then
            If MsgBox("Are you sure you want to increase the size this much? " & Str(PercentX) & "% in x & " & Str(PercentY) & "% in y", MsgBoxStyle.OkCancel, "Are you mad!") = MsgBoxResult.Cancel Then Stop
        End If

        If PercentX < 60 Or PercentY < 60 Then
            If MsgBox("Are you sure you want to reduce the size this much? " & Str(PercentX) & "% in x & " & Str(PercentY) & "% in y", MsgBoxStyle.OkCancel, "Are you mad!") = MsgBoxResult.Cancel Then Stop
        End If

        Select Case NewShape
            Case "Draw"
                Apr.SetNonCustom(GCB_APER_TYPE.DRAW, NewX, NewY)
                Apr.IsVisible = LeaveVisible
            Case "Round"
                Apr.SetNonCustom(GCB_APER_TYPE.ROUND, NewX, NewY)
                Apr.IsVisible = LeaveVisible
            Case "Square"
                Apr.SetNonCustom(GCB_APER_TYPE.SQUARE, NewX, NewY)
                Apr.IsVisible = LeaveVisible
            Case "Rectangle"
                Apr.SetNonCustom(GCB_APER_TYPE.RECTANGLE, NewX, NewY)
                Apr.IsVisible = LeaveVisible
            Case "Oblong"
                Apr.SetNonCustom(GCB_APER_TYPE.OBLONG, NewX, NewY)
                Apr.IsVisible = LeaveVisible
            Case Else
                MsgBox("Error: Unknown shape!")
                Stop
        End Select

    End Sub
    Public Sub Get_Apr_Info(Changeunits As Boolean, Optional newunits As GCB_UNITS = GCB_UNITS.MM)

        Pnum = Find_Pnum("Working Layer")
        PhysTemp = P.Item(Pnum)
        Dattemp = PhysTemp.GetNthDataLayer(1)
        MyPadList = Dattemp.CreatePadList()

        While MyPadList.Next() = True
            If MyPadList.IsMarked = True Then
                PadNum = MyPadList.PadToolNum
            End If
        End While

        AlistNum = Dattemp.ToolListNum
        Alist_a = A.Item(AlistNum)


        If Changeunits = False Then User_Units = Gf.JobUnit 'saved for later use
        If Changeunits = True Then Gf.JobUnit = newunits

        gUnits = Gf.JobUnit

        Select Case gUnits
            Case GCB_UNITS.MM
                Units = "mm"
            Case GCB_UNITS.INCH
                Units = "inches"
            Case GCB_UNITS.MIL
                Units = "thou"
            Case Else
                MsgBox("Error: Unknown units in aperture list!" & Chr(13) & "Cannot continue!")
                Stop
        End Select

        Apr = Alist_a.Item(PadNum)

        Dim_x = Apr.Dim1
        Dim_y = Apr.Dim2

        gShape = Apr.Type
        Select Case gShape
            Case GCB_APER_TYPE.DRAW
                Shape = "Draw"
            Case GCB_APER_TYPE.ROUND
                Shape = "Round"
            Case GCB_APER_TYPE.SQUARE
                Shape = "Square"
            Case GCB_APER_TYPE.RECTANGLE
                Shape = "Rectangle"
            Case GCB_APER_TYPE.OBLONG
                Shape = "Oblong"
            Case GCB_APER_TYPE.CUSTOM
                If MsgBox("Warning: Custom apertures will be treated as rectangles - custom shape will be lost!" & Chr(13) & "Continue with Reductions?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Stop
                Shape = "Rectangle"
            Case Else
                If MsgBox("Warning: Unsupported Aperture Type - Shape will be treated as rectangle" & Chr(13) & "Continue with Reductions?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Stop
                Shape = "Rectangle"
        End Select

    End Sub
End Module
