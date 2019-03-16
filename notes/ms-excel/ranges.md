# MS Excel Objects

## Ranges

The [`Range`](https://msdn.microsoft.com/en-us/vba/excel-vba/articles/range-object-excel) object represents one or more cells in a given worksheet.

### Reading Values and Properties

To read the value and other properties of a cell:

```vb
Range("A1").Value ' --> "Hello World"
Range("A1").Address ' --> "$A$1"
Range("A2").Formula ' --> "=B2+C2"
```

By default, ranges are referenced relative to the current sheet. If you need to reference a range on another sheet or a specific sheet, include the sheet name as part of the reference:

```vb
Worksheets("Sheet1").Range("A1").Value ' --> "Hello from Sheet 1"
Worksheets("Sheet2").Range("A1").Value ' --> "Hello from Sheet 2"
```

> EDITOR'S NOTE: there was some content about a worksheet's Used Ranges here, but that content has moved [here](/notes/ms-excel/worksheets.md#used-range-of-cells-in-a-worksheet), where it makes more contextual sense. Just know you can do anything with a Used Range that you could otherwise do with any Range object. Like display its address, count its rows, etc.

### Writing Values

To write a value to a cell:

```vb
Range("A1").Value = "fun times"
```

### Clearing Contents

To clear the contents of one or more cells:

```vb
Range("A1:C5").ClearContents ' clears contents, but does not clear formatting
Range("A1:C5").Clear ' clears all contents and formatting
```

### Cells in a Range

Access all cells in a given range:

```vb
Range("A1:C5").Cells.Count ' --> 15
```

After studying [loops](/notes/visual-basic/loops.md), you can use one to iterate through all cells in a given range:

```vb
Dim MyCell As Range

For Each MyCell In Range("A1:C5").Cells
    MsgBox (MyCell.Address)
Next MyCell
```

### Rows in a Range

Access all rows in a given range:

```vb
Range("A1:C5").Rows.Count ' --> 5
```

Iterate through all rows in a given range:

```vb
For Each MyRow In Range("A1:C5").Rows
    MsgBox (MyRow.Address)
Next MyRow
```

### Columns in a Range

Access all columns in a given range:

```vb
Range("A1:C5").Columns.Count ' --> 3
```

Iterate through all columns in a given range:

```vb
For Each MyCol In Range("A1:C5").Columns
    MsgBox (MyCol.Address)
Next MyCol
```

### Selecting Relative Ranges

You can select relative ranges by leveraging the [`Range.End` property](https://docs.microsoft.com/en-us/office/vba/api/Excel.Range.End), in conjunction with a [direction](https://docs.microsoft.com/en-us/office/vba/api/excel.xldirection) relative to the given range.

The result "represents the cell at the end of the region that contains the source range (equivalent to pressing `END+UP ARROW`, `END+DOWN ARROW`, `END+LEFT ARROW`, or `END+RIGHT ARROW`)."

Example:

```vb
Range("A1").End(xlDown).Select
```

### Copying Ranges

To copy the contents of one range of cells to another, simultaneously read and write to and from the appropriate ranges:

```vb
Range("A1").Value = Range("B1").Value ' copies contents of B1 into A1
```

You can do this for multiple cells, or even entire rows/columns:

```vb
Range("A1:A10").Value = Range("B1:B10").Value ' copies contents of B1:B10 into range A1:A10
Range("A:A").Value = Range("B:B").Value ' copies contents of column B into column A
```

You can also do this from one workbook or worksheet to another:

```vb
Worksheets("Sheet1").Range("A1").Value = Worksheets("Sheet2").Range("A1").Value ' copies contents of A1 on Sheet2 into A1 on Sheet1
```
