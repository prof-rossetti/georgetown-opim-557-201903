# VBA Debugging Tools

Certain tools available in MS Excel and the VBE window can be helpful to us during the [troubleshooting process](/HELP.md).

## Message Boxes

Once you learn about [Message Boxes](message-boxes.md), you can use them to display variable values at various stages in your program's execution.

## The Immediate Window

Similar to displaying variable values in a message box, you could also "print" variable values in a specific place called the Immediate Window.

Be aware of the official docs on the [Immediate Window](https://docs.microsoft.com/en-us/office/vba/language/reference/user-interface-help/immediate-window), but actually spend time reading and following along with this unofficial [Using the Immediate Window](https://www.excelcampus.com/vba/vba-immediate-window-excel/) guide, which is better.

> FYI: sometimes code that doesn't actually cause an error during the normal flow of program execution will cause an error when you are evaluating it in the Immediate Window. For this reason, you might not be able to fully rely on the Immediate Window. That being said, it is still helpful for quick debugging in many cases.

## Trace Code Execution

Reference this document on [Trace Code Execution](https://msdn.microsoft.com/en-us/vba/language-reference-vba/articles/trace-code-execution) for techniques on how to "step-through" your program line-by-line to better understand its order of execution.

## The Locals Window

Another powerful, but perhaps less commonly used, tool to see how your variables values change over time is
[The Locals Window](https://msdn.microsoft.com/en-us/vba/language-reference-vba/articles/locals-window).
