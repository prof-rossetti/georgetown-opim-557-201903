# Check Boxes

The [`CheckBox` control](https://msdn.microsoft.com/en-us/VBA/Language-Reference-VBA/articles/checkbox-control) represents a checkable box belonging to a specified group from which zero or more may be selected at any given time.

![a screenshot depicting two of four checked boxes](/img/notes/ms-excel/activex-controls/check-box.png)

## Insertion

For each box: click "Developer" > "Insert" > "ActiveX Controls" > "Check Box".

## Properties

name | description
--- | ---
`Caption` | A human-friendly name for the checkable option.
`GroupName` | Associates the control with a logical grouping of one or more controls (default: "Sheet1").
`Value` | The current state of the control (i.e. `True` if checked, otherwise `False`).
`LinkedCell` | The address of a specified cell which is bidirectionally associated with control's value.

## Events

name | description
--- | ---
`Click` (default) | Triggers when an option is checked.
`Change` | Triggers when the control's value is changed. Triggers before the `Click` event in the control's event lifecycle.
