'
' SAVINGS CALCULATOR PROJECT > STARTER CODE > VALIDATIONS MODULE
'
' Author: Prof. Rossetti <prof.mj.rossetti@gmail.com>
' Source: https://github.com/prof-rossetti/georgetown-opim-557-201810/blob/master/projects/savings-calc/starter-code/validations-module.vb
' License: Students, feel free but not obligated to use this module in your project as long as you retain this attribution section. If you wrote something like this on your own, no need to attribute. If this code inspired you to write your own code, please still consider providing an attribution link to this file's GitHub URL.
' Note: named statements like HandleInvalid (or whatever custom name you choose) help prevent code duplication.
'

' Helps you understand the recognized datatype of the passed parameter value.
Public Sub LogDatatype(ByVal MyVal)
    MsgBox ("The value is: " & MyVal & " (" & TypeName(MyVal) & ").")
End Sub

' Evaluates whether or not a given value looks like an age value.
Public Function IsValidAge(ByVal MyVal) As Boolean
    Call LogDatatype(MyVal)

    If TypeName(MyVal) = "Double" Then ' expect numeric cell values to be doubles by default, even though some could really be integers
        If Int(MyVal) = MyVal Then ' now try to tell if the value is really an integer
            If MyVal >= 18 And MyVal <= 120 Then ' include this example business logic assumption about the age of our clients
                MsgBox ("Detected valid age: " & MyVal & ".")
                IsValidAge = True
            Else
                GoTo HandleInvalid
            End If
        Else
            GoTo HandleInvalid
        End If
    Else
        GoTo HandleInvalid
    End If

    Exit Function
HandleInvalid:
    MsgBox ("Oh, detected invalid age: " & MyVal & ". Please input a positive whole number between 18 and 120.")
    IsValidAge = False
End Function

' Evaluates whether or not a given value looks like a currency value.
Public Function IsValidUSD(ByVal MyVal) As Boolean
    Call LogDatatype(MyVal)

    If TypeName(MyVal) = "Double" Or TypeName(MyVal) = "Currency" Then
        If MyVal > 0 Then
            MsgBox ("Detected valid price: " & MyVal & ".")
            IsValidUSD = True
        Else
            GoTo HandleInvalid
        End If
    Else
       GoTo HandleInvalid
    End If

    Exit Function
HandleInvalid:
    MsgBox ("Oh, detected invalid value: " & MyVal & ". Please input a positive number instead.")
    IsValidUSD = False
End Function

' Evaluates whether or not a given value looks like a percentage value.
' ... NOTE: the passed parameter should not include a percent sign
Public Function IsValidPct(ByVal MyVal) As Boolean
    Call LogDatatype(MyVal)

    If TypeName(MyVal) = "Double" Then
        If MyVal >= 0 And MyVal <= 0.6 Then
            MsgBox ("Detected valid percentage: " & MyVal & ".")
            IsValidPct = True
        Else
            GoTo HandleInvalid
        End If
    Else
        GoTo HandleInvalid
    End If

    Exit Function
HandleInvalid:
    MsgBox ("Oh, detected invalid value: " & MyVal & ". Please input an interest rate between 0.00 and 0.60 (e.g. 0.15).")
    IsValidPct = False
End Function

' Evaluates whether the retirement age is older than the current age.
Public Function AgesValid(ByVal MyAge As Integer, ByVal MyRetirementAge As Integer) As Boolean
    If MyAge > MyRetirementAge Then
        MsgBox ("Oh, please ensure the desired retirement age is older than the current age.")
        AgesValid = False
    Else
        AgesValid = True
    End If
End Function
