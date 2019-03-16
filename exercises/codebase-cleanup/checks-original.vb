'
' CheckBox Solution (Original)
'

Private Sub CheckBox1_Click()
    Dim Selections As String
    Selections = ""

    If CheckBox1.Value = True Then
        Selections = Selections + " CheckBox1 "
    End If

    If CheckBox2.Value = True Then
        Selections = Selections + " CheckBox2 "
    End If

    If CheckBox3.Value = True Then
        Selections = Selections + " CheckBox3 "
    End If

    If CheckBox4.Value = True Then
        Selections = Selections + " CheckBox4 "
    End If

    MsgBox ("You checked/unchecked " & CheckBox1.Caption & " value to be: " & CheckBox1.Value _
            & " and now the checked boxes include: " & Selections & "." _
    )

    Set CheckGrpCell = Range("G25")
    CheckGrpCell.Value = Selections
End Sub

Private Sub CheckBox2_Click()
    Dim Selections As String
    Selections = ""

    If CheckBox1.Value = True Then
        Selections = Selections + " CheckBox1 "
    End If

    If CheckBox2.Value = True Then
        Selections = Selections + " CheckBox2 "
    End If

    If CheckBox3.Value = True Then
        Selections = Selections + " CheckBox3 "
    End If

    If CheckBox4.Value = True Then
        Selections = Selections + " CheckBox4 "
    End If

    MsgBox ("You checked/unchecked " & CheckBox2.Caption & " value to be: " & CheckBox2.Value _
            & " and now the checked boxes include: " & Selections & "." _
    )

    Set CheckGrpCell = Range("G25")
    CheckGrpCell.Value = Selections
End Sub

Private Sub CheckBox3_Click()
    Dim Selections As String
    Selections = ""

    If CheckBox1.Value = True Then
        Selections = Selections + " CheckBox1 "
    End If

    If CheckBox2.Value = True Then
        Selections = Selections + " CheckBox2 "
    End If

    If CheckBox3.Value = True Then
        Selections = Selections + " CheckBox3 "
    End If

    If CheckBox4.Value = True Then
        Selections = Selections + " CheckBox4 "
    End If

    MsgBox ("You checked/unchecked " & CheckBox3.Caption & " value to be: " & CheckBox3.Value _
            & " and now the checked boxes include: " & Selections & "." _
    )

    Set CheckGrpCell = Range("G25")
    CheckGrpCell.Value = Selections
End Sub

Private Sub CheckBox4_Click()
    Dim Selections As String
    Selections = ""

    If CheckBox1.Value = True Then
        Selections = Selections + " CheckBox1 "
    End If

    If CheckBox2.Value = True Then
        Selections = Selections + " CheckBox2 "
    End If

    If CheckBox3.Value = True Then
        Selections = Selections + " CheckBox3 "
    End If

    If CheckBox4.Value = True Then
        Selections = Selections + " CheckBox4 "
    End If

    MsgBox ("You checked/unchecked " & CheckBox4.Caption & " value to be: " & CheckBox4.Value _
            & " and now the checked boxes include: " & Selections & "." _
    )

    Set CheckGrpCell = Range("G25")
    CheckGrpCell.Value = Selections
End Sub
