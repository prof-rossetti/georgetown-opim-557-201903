# "Simple System" Project

> The Simple System acts as an introduction to information systems, software application development, programming with VBA in MS Excel, user interface design, and data management. Students will create an interactive GUI application which accepts user form inputs and saves corresponding records in a separate worksheet.


## Learning Objectives

  1. Create an information system which captures and stores information inputs, and displays information outputs.
  2. Practice designing user interfaces and experiences.

## Instructions

Create a new macro-enabled workbook named "`netid`-simple-system.xlsm", where `netid` is your university-issued net identifier (i.e. the first part of your university-issued email address).

Rename the first sheet to "Prompt". Create new blank worksheets called "Interface" and "Data", respectively.

Further-develop your workbook to meet the project requirements below.

### Business Prompt Requirements

Think of a use case where some business or organization would want to capture information from customers or users through in-person or online form submission.

For example: residents submitting a "Building Permit Application" at town hall, a user submitting a post on a social media site like Facebook or Twitter, a user placing an order on a retail site like Amazon, a student registering for classes, etc.

Your business prompt can be real, loosely based on real-life, or entirely fictional. Have fun and be creative!

Try to think of a business prompt that involves a form with a broad variety of different interface elements.

On the "Prompt" sheet, describe in English your chosen business prompt, including information about who the target end user is, why the user is submitting the form, and the value this brings to the business or organization.

### User Interface Design Requirements

When the user opens the workbook, they should see the user interface, either on the "Interface" sheet, or on a separate User Form displayed in-front of or instead of the "Interface" sheet. As much as possible, they should not be aware of, or otherwise be able to view or edit, the "Data" sheet.

The user interface should look clean and organized and user-friendly.

The user interface should reflect reasonable choices about which interface elements/controls to use to capture each respective information input (i.e. using a Toggle Button instead of a Text Box for the purpose of capturing a boolean value).


### Information Input Requirements

The user interface should include multiple interface elements, including:

  + At least one which allows the user to input free response text (e.g. Text Box, Input Box).
  + At least one which forces the user to choose between two or more pre-selected options (e.g. Combo Box, Check Box, Toggle Button, etc.).
  + A Command Button with a caption like "Submit".

Example Interface (incomplete):

![](/img/notes/ms-excel/user-forms/userform-design-mode.png)

When the button is pressed, the program should trigger the information storage and display processes in turn.

### Information Output Requirements

When the user submits information via the user interface, the program should display a receipt via Message Box or other mechanism.

The receipt should contain the following information:

  + A unique record identifier (a.k.a. `id`, e.g. `37`).
  + The date and time when the form was submitted (a.k.a. `timestamp`, e.g. `10/21/2018 12:43:17 PM`).
  + All the other field names and values submitted via the form.

Example Receipt (incomplete):

![](/img/projects/simple-system/permitform-display-inputs.png)


The `id` should be a unique, auto-incremented integer that is equal to one greater than the maximum existing identifier value.

> HINT: you might not be able to determine the proper identifier value until after you have implemented the Information Storage Requirements (below). Until then, feel free to use a temporary placeholder integer (like 1 or 100 or something), then return to this task once you have demonstrated your ability to append records to the "Data" sheet.

The `timestamp` should be the date and time when the form was submitted, formatted in a human-friendly way.

> HINT: you might need to search the Internet for "how to get the current date and time in VBA" or "excel vba timestamp" :smiley_cat:

### Information Storage Requirements

In the first row of the "Data" sheet, manually create a blank table to store the records submitted via the user interface. The first two column headers must be `id` and `timestamp`, respectively. The rest of the column headers should correspond with other fields captured by your form (e.g. `name` and `address` for the building permit example).

![](/img/projects/simple-system/records-sheet-setup.png)

> NOTE: once you set up the headers, you shouldn't need to do it again. Setting them up manually is sufficient. Setting them up programmatically is acceptable but not necessary.

When the user submits information via the user interface, the program should append a corresponding record to the "Data" sheet. For subsequent form submissions, the existing data should remain intact, and the new data should be written on the next available row.

![](/img/projects/simple-system/writing-records-autoincrement.png)

> NOTE: for the basic project requirements, it is safe to assume it is not possible for existing records to be reordered or removed or deleted.

The data should persist even after the workbook is closed and re-opened.

### User Experience Requirements

The program should provide clear written and visual instructions to help the user understand how to use the system as desired.

The program should run without error and be free of any idiosyncracies or confusing behavior.

## Submission Instructions

When you are finished developing your project, [upload](https://georgetown.instructure.com/courses/65741/assignments/165667) your workbook file to Canvas.

## Evaluation Methodology

Submissions will be evaluated based on their ability to meet each of the component requirements (see corresponding sections above for detailed instructions):

Requirements Category | Weight
--- | ---
Business Prompt | 10%
User Interface Design | 10%
Information Inputs | 20%
Information Storage | 20%
Information Outputs | 30% (10% inputs, 10% `id`, 10% `timestamp`)
User Experience | 10%

This rubric is tentative, and may be subject to slight adjustments during the grading process.

Additionally, the professor reserves the right to award extra credit for submissions which exceed expectations, and/or submissions with successful implementation of the optional Further Exploration Challenge (below).

<hr>

## Further Exploration Challenge (Optional)

> WARNING: This challenge is optional. Only attempt this challenge if/once you have successfully completed all other basic project requirements. Prefer to submit a project which perfectly meets basic requirements over a project which attempts to address this challenge but fails to perfectly meet all basic requirements.

Revise the original assumption about records not being able to be reordered, removed, or deleted. Suppose instead records can at least be deleted.

Optionally create a mechanism for an administrator to use a different admin interface to "delete" a record, given its identifier. Or mimic this process by manually deleting a record from the "Data" sheet.

Does your program still operate as expected? Ensure that the next time the form is submitted, the identifiers are auto-incrementing properly, and are not being repeated/duplicated.

For example:

  1. Suppose the form is submitted three times, writing three records with identifiers `1`, `2`, and `3`, respectively.
  2. Then the admin uses the admin interface to delete record #2.
  3. If no records had been deleted, the next identifier value would have been `4`. Even though there are now only two remaining records (`1` and `3`), the next time the form is submitted, the next identifier value should still be `4`!.
