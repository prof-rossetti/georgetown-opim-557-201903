# "Simulated Returns" Exercise

## Learning Objectives

  1. Find practical applications for learning new programming concepts like loops and custom functions.
  2. Become familiar with a specific method of incorporating uncertainty and probability into financial calculations.

## Instructions

Create a new macro-enabled workbook named "annual-returns.xlsm". Rename the first sheet to "Interface" and create a second sheet named "Data".

On the "Data" sheet, create a header row with `year` in the first column and `return_rate` in the second column.

On the "Interface" sheet, create a "Generate!" button.

When the button is clicked, it should write a record to the "Data" sheet for each year between the current year and 30 years from now, inclusive. The values for each record should be the integer year (e.g. `2021`) in the first column, and a simulated annual return rate (e.g. `0.076`) in the second column.

To calculate the simulated annual return rate, use this [Triangular Distribution Function](/exercises/simulated-returns/triangular-distribution.vb). Pass some reasonable hard-coded parameter values (e.g. min rate of `-0.10`, likely rate of `0.025`, max rate of `0.18`).

## Further Exploration

On the "Interface" sheet, allow the user to input an investment portfolio balance (e.g. `$250,000`).

Update the header row of your "Data" sheet to include `starting_balance` in the third column and `ending_balance` in the third column.

Revise your calculations to grow the starting balance each year by applying the simulated annual return rate (i.e. ending balance for any given year is equal to the starting balance for that year multiplied by the return rate, added to the starting balance for that year). And write those values to the "Data" sheet as well.
