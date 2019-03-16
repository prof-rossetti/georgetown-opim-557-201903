# "Processing Spreadsheet Files" Exercise

## Learning Objectives

  1. Find practical applications for learning new interface elements like the file-selection dialogue, and VBA programming concepts like workbook operations.
  2. Gain familiarity with processing data saved in MS Excel Spreadsheets (XLSX format).

## Instructions

First, download these [example spreadsheet files](/exercises/processing-spreadsheet-files/data/) (a.k.a. data files) representing historical market returns, and save them on your Desktop or somewhere else you will remember. Open one or more of them to inspect their contents, then close them.

>NOTE: For any of these files, it is safe to assume the first sheet is named "Data", and the first two columns of data on that sheet represent years and annual investment return rates, respectively.

Next, create a new macro-enabled workbook named "processing-sheets.xlsm" (a.k.a. the exercise workbook). Rename the first sheet "Interface" and add a command-button there which will trigger the processes below. Create a second sheet called "Data".

When the user clicks the button on the "Interface" sheet, the program should prompt them to select one of the data files, using a native file-selection dialogue.

After confirming their file selection, the program should import/copy the contents of the selected data file's "Data" sheet into the exercise workbook's "Data" sheet.

Finally, after importing/copying the data, the program should process the data to calculate the average, minimum, and maximum interest rates, and display the results in a message box.
