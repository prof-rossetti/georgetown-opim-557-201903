'
' CheckBox Solution (Simplified)
'

Private Sub CheckBox1_Click()
    Call HandleCheckClick(CheckBox1)
End Sub

Private Sub CheckBox2_Click()
    Call HandleCheckClick(CheckBox2)
End Sub

Private Sub CheckBox3_Click()
    Call HandleCheckClick(CheckBox3)
End Sub

Private Sub CheckBox4_Click()
    Call HandleCheckClick(CheckBox4)
End Sub

Private Sub HandleCheckClick(ByVal MyCheckBox As Object)
    Dim Selections As String
    If CheckBox1.Value = True Then Selections = Selections + " CheckBox1 "
    If CheckBox2.Value = True Then Selections = Selections + " CheckBox2 "
    If CheckBox3.Value = True Then Selections = Selections + " CheckBox3 "
    If CheckBox4.Value = True Then Selections = Selections + " CheckBox4 "

    MsgBox ("You checked/unchecked " & MyCheckBox.Caption & " value to be: " & MyCheckBox.Value _
            & " and now the checked boxes include: " & Selections & "." _
    )

    Range("G25").Value = Selections
End Sub
