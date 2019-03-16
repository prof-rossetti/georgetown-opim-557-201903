'
' OptionButton Solution (Original)
'

Private Sub OptionButton1_Click()
    Dim OptGrpCell As Range
    Set OptGrpCell = Range("G9")
    MsgBox ("You have selected: " & OptionButton1.Caption & ". Updating the value of cell: " & OptGrpCell.Address & "...")
    OptGrpCell.Value = OptionButton1.Caption
End Sub

Private Sub OptionButton2_Click()
    Dim OptGrpCell As Range
    Set OptGrpCell = Range("G9")
    MsgBox ("You have selected: " & OptionButton2.Caption & ". Updating the value of cell: " & OptGrpCell.Address & "...")
    OptGrpCell.Value = OptionButton2.Caption
End Sub

Private Sub OptionButton3_Click()
    Dim OptGrpCell As Range
    Set OptGrpCell = Range("G9")
    MsgBox ("You have selected: " & OptionButton3.Caption & ". Updating the value of cell: " & OptGrpCell.Address & "...")
    OptGrpCell.Value = OptionButton3.Caption
End Sub

Private Sub OptionButton4_Click()
    Dim OptGrpCell As Range
    Set OptGrpCell = Range("G9")
    MsgBox ("You have selected: " & OptionButton4.Caption & ". Updating the value of cell: " & OptGrpCell.Address & "...")
    OptGrpCell.Value = OptionButton4.Caption
End Sub
