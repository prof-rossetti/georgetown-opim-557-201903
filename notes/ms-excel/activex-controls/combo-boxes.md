# Combo Boxes

The [`ComboBox` control](https://msdn.microsoft.com/en-us/VBA/Language-Reference-VBA/articles/combobox-control) represents a drop-down menu which allows the user to choose one option from a provided list.

![a screenshot of a user selecting an option from a drop-down menu](/img/notes/ms-excel/activex-controls/combo-box-1.png)

## Insertion

Click "Developer" > "Insert" > "ActiveX Controls" > "Combo Box".

## Properties

name | description
--- | ---
`ListFillRange` | The address of a range of cells to populate the control's list of selectable options.
`Value` | The name of the currently-selected list item.
`LinkedCell` | The address of a specified cell which is bidirectionally associated with control's value.

## Events

name | description
--- | ---
`Change` (default) | Triggers when an option is selected from the drop-down.

## Advanced

### Setting Values Programmatically

It is possible to programmatically set a `ComboBox` control's selectable values without using the `ListFillRange` approach, by invoking the control's `AddItem` method instead:

```vb
' clear previously-added items, to prevent unwanted proliferation / duplication
ComboBox1.Clear

' programmatically add selectable options
ComboBox1.AddItem("Option 1")
ComboBox1.AddItem("Option 2")
ComboBox1.AddItem("Option 3")
ComboBox1.AddItem("Option 4")
ComboBox1.AddItem("Option 5")

' specify which option should be selected by default
ComboBox1.Value = "Option 3"
```

> NOTE: you'll probably want to invoke this code inside the workbook open sub-procedure!
