# "ActiveX Controls" Exercise

## Learning Objectives

  1. Gain exposure to programmatically-accessible interface controls in MS Excel, specifically ActiveX Controls.
  2. Find practical applications for learning new programming concepts like variables and conditionals.

## Instructions

Create and save a new macro-enabled workbook.

Rename the first sheet to "Interface". On the "Interface" sheet, create each of the following ActiveX Controls:

  1. **Command Button** (with a caption like "Count number of times clicked")
  2. **Combo Box** (with a list fill range of cells representing the list of selectable options, and a linked cell to display the currently selected value)
  3. **List Box** (with a list fill range of cells representing the list of selectable options, and a linked cell to display the currently selected value)
  4. **Toggle Button** (with a caption like "Toggle me!" and a linked cell to display the current value)
  5. **Spin Button** (with a linked cell to display the current value)
  6. **Scroll Bar** (with a linked cell to display the current value)
  7. **Option Buttons** (a related group of four, each with its own linked cell to display its current value)
  8. **Check Boxes** (a related group of four, each with its own linked cell to display its current value)

Revise the properties of these controls and write underlying VBA code as appropriate to implement each of the following programming challenges, and save the workbook after completing each.

### Challenges

#### Command Button Challenge

When the user clicks the "Count number of times clicked" button, the program should display a message like "You have clicked me `X` times", where `X` is the number of times the button has been clicked.

![A screenshot of a message box that reads 'You have clicked me 3 times. Keep going!'](/img/exercises/activex-controls/command-button-counting-clicks.png)

> Clarification: please use a variable, not a cell for storing the click count.

> Hint: declare a variable outside the scope of the button's click event sub-procedure, and increment the variable's value from inside the scope of the click event sub-procedure.

> Hint: the first hint may only work if you declare the variable at the top of your VBA document, above any other sub-procedure definitions. If you desire more flexibility in the positioning of your code, you might want to explore using [`Static`](https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/modifiers/static) instead of `Dim`, to change the scope of your variable. Note: if you are declaring the variable using `Static`, you will want to do so within the scope of the click event sub-procedure. Note: Static variables are outside the scope of this course.

#### Combo Box Challenge

The user should be able to use a combo box to select one of at least three options.

When the user selects an option from the combo box, the control's linked cell should update to display the selected option, and the program should display a message with the name of the selected option.

![a screenshot of a user selecting an option from a drop-down menu.](/img/notes/ms-excel/activex-controls/combo-box-1.png)

![a screenshot of a message box displaying the name of an item that has been selected from a drop-down menu. also it displays the selected value in a linked cell.](/img/notes/ms-excel/activex-controls/combo-box-2.png)

#### List Box Challenge

Repeat the combo box challenge above, but use a list box control instead.

![A screenshot of a list box control which displays the currently selected item name in a linked cell](/img/notes/ms-excel/activex-controls/list-box.png)

> Note: if the List Box is acting a little buggy, either visually or in the sense that its click/change event is triggered when the workbook is opened, don't worry about it. Just consider this when choosing which controls to use in the future. :smile_cat:

#### Spin Button Challenge

The user should be able to use a spin button to increment or decrement an integer value between some specified acceptable range of values.

When the user increments or decrements (i.e. "changes") the value, the control's linked cell should update to display the currently selected value, and the program should display a message like "You changed the value to: `X`", where `X` is the currently selected value.

![A screenshot of a message box which displays the current integer value of a spin button control. also it displays its value in a linked cell.](/img/notes/ms-excel/activex-controls/spin-button-increment.png)

#### Scroll Bar Challenges

Repeat the spin button challenge above, but use a scroll bar control instead.

![A screenshot of a message box which displays the current integer value of a scroll bar control. also it displays its value in a linked cell.](/img/notes/ms-excel/activex-controls/scroll-bar-scrolled.png)

#### Toggle Button Challenge

The user should be able to use a toggle button to represent either a pressed or unpressed state.

When the user toggles the button, the control's linked cell should update to display the currently selected value (e.g. `True` or `False`), and the program should display an alert which indicates whether its current state is "On" or "Off".

![A screenshot of a message box saying the button has been toggled "on". it also uses a linked cell to display its boolean value.](/img/notes/ms-excel/activex-controls/toggle-button-clicked-on.png)

> Hint: inside the scope of the toggle button's click event sub-procedure, use an `If` statement to check the value of the toggle button and respond accordingly.

#### Option Button Challenge

The user should be able to click any of the four option buttons to select one mutually exclusive option from among them.

When the user selects one of the option buttons:

  + All other option buttons should be de-selected.
  + Each control's respective linked cell should update to display its currently selected value (e.g. `True` or `False`). Use a different linked cell for each control.
  + The value of some specified cell should display the name or caption of the currently selected option. Display this value in the same cell, regardless of which control is selected.
  + The program should display an alert which indicates the name or caption of the currently selected option.

![a screenshot of four vertically-aligned option buttons, one of which is selected. it also shows a message box alerting the user of which option has been selected. it also uses four different linked cells to indicate the boolean values of each option. it also displays in a specified cell the caption of the selected option.](/img/notes/ms-excel/activex-controls/option-button-2.png)

> Note: don't worry if this challenge results in some code duplication. After you learn about custom sub-procedures and parameters, we can apply techniques for simplifying, or "refactoring" this code to remove duplication.

#### Check Box Challenge

Repeat the option button challenge above, but use check box controls instead. Ignore the expectation for mutual exclusivity because more than one check box may be selected at the same time.

And, instead of writing the name or caption of a single selected option to a specified cell, write a concatenated list of all selected options. The list doesn't need to be formatted in any particular way - a single space in between each selected option is sufficient.

![a screenshot of four vertically-aligned check boxes, two of which are selected. it also shows a message box alerting the user of which options have been selected. it also uses four different linked cells to indicate the boolean values of each option. it also displays in a specified cell the captions of both selected options.](/img/notes/ms-excel/activex-controls/check-box-2.png)

> Hint: inside the scope of each check box control's click event sub-procedure, use one or more `If` statements to check the values of each check box, and conditionally concatenate a string variable to include the name or caption of each control as appropriate.

> Note: don't worry if this challenge results in some code duplication. After you learn about custom sub-procedures and parameters, we can apply techniques for simplifying, or "refactoring" this code to remove duplication.

<hr>

## Further Exploration

Right now the click counter will reset when you close the workbook. How could you get the click count to persist and continue counting even after the workbook is closed and re-opened?
