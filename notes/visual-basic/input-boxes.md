# Input Boxes

Use VBA's built-in [`InputBox` function](https://msdn.microsoft.com/en-us/vba/excel-vba/articles/application-inputbox-method-excel) to capture a user input. Pass a textual message as the function's primary parameter. Store the resulting value in a variable to make further use of it:

```vb
Dim MyName As String
MyName = InputBox("Please input your name: ")
MsgBox(MyName)
```

## Datatypes of `InputBox` Values

When you use an `InputBox` to capture a user input, beware the default datatype of the resulting value will be a `String`. If you would like to change the default datatype to be numeric, pass a `Type` parameter value of `1` and the resulting value will instead be a `Double`:

```vb
Dim MyInput
MyInput = Application.InputBox(prompt:="Please enter your birth year: ", Type:=1)
```

> NOTE: yes, to get this to work you may have to use `Application.InputBox` instead of the normal `InputBox`.

See also: [Datatypes](datatypes.md).
