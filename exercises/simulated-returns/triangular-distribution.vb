
'
' Triangular Distribution Function
' Source: Prof. Dillon Merrill
'

Public Function Triang(Min, Likely, Max) As Double
    Dim MyRand As Double
    MyRand = Rnd()

    If MyRand <= (Likely - Min) / (Max - Min) Then
        Triang = Min + SquareRoot(MyRand * (Max - Min) * (Likely - Min))
    Else
        Triang = Max - SquareRoot((1 - MyRand) * (Max - Min) * (Max - Likely))
    End If
End Function


Public Function SquareRoot(N) As Double
    SquareRoot = N ^ (1 / 2)
End Function
