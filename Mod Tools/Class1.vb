Imports GCExt
Imports System.IO

Public Class Class1
    Implements IGCPlugin





    Public Property Name As String Implements GCExt.IGCPlugin.Name
        Get
            Return "VB test"
        End Get
        Set(value As String)

        End Set
    End Property

    Public Shared SONum As String

    Public Sub Run(iApp As GCExt.IGCApp) Implements GCExt.IGCPlugin.Run
        Dim doc As IGCDoc = iApp.GetDocument()



        If Gf.GCBNumMarkedTraces <> 0 Then
            MsgBox("Unselect all traces!!!")
            Stop
        Else
            Select Case Gf.GCBNumMarkedPartsAndPads
                Case 0
                    MsgBox("Please select at least one aperture")
                'Stop
                Case 1
                    Get_Apr_Info(False)
                    Dim f As New Reductions
                    f.ShowDialog()
                Case 2
                    'Get_Apr_Info(False)
                    Dim f As New Chip_Component_Mods
                    f.ShowDialog()
                Case Else
                    MsgBox("Too many pads selected")
                    'Stop
            End Select
        End If
        Gf.Unmark()


    End Sub
End Class