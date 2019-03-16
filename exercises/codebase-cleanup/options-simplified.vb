'
' OptionButton Solution (Simplified)
'

Private Sub OptionButton1_Click()
    Call HandleRadioClick(OptionButton1)
End Sub

Private Sub OptionButton2_Click()
    Call HandleRadioClick(OptionButton2)
End Sub

Private Sub OptionButton3_Click()
    Call HandleRadioClick(OptionButton3)
End Sub

Private Sub OptionButton4_Click()
    Call HandleRadioClick(OptionButton4)
End Sub

Private Sub HandleRadioClick(ByVal MyRadio As Object)
    Dim OptGrpCell As Range
    Set OptGrpCell = Range("G9")

    MsgBox ("You have selected: " & MyRadio.Caption & _ ". Updating the value of cell: " & OptGrpCell.Address & "..." _)

    OptGrpCell.Value = MyRadio.Caption
End Sub
