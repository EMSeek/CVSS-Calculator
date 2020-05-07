CVSS-Calculator
==========================================================================
This is a simple desktop CVSS calculator aimed at making report writing
easier. The main interface should be familiar for anyone who has used a
CVSS calculator before:

![alt text](Calculator.png "Calculator screenshot")


CVSS score can be generated in several ways:
 * Clicking on the buttons under each attribute
 * Rapidly, by using arrow keys (Up/Down value, Left/Right attribute)
 * Typing or pasting the vector string

Additionaly there are some options that lets you set risk level thresholds,
link to CVSS rating online and a risk reporting template.

![alt text](Options.png "Options screenshot")

Templating supports the following variables:
 * %CVSS% Vector string
 * %SCORE% CVSS numerical score
 * %RISK% Risk rating based on the CVSS score treshold
 * %URL% (Not applicable for the URL)

Clicking on the copy button, or pressing ctrl+c inside the CVSS textbox
will copy the templated text with the variables filled in, ready to be
pasted into your security report:

![alt text](Paste.png "Paste screenshot")