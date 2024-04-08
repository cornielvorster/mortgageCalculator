# Mortgage Calculator (C# + Windows Forms)
A Mortgage Calculator to determine monthly repayments, total payment, total intresest and amortization schedule.


**Table of Contents**

* Project Description
* Installation
* Usage: #usage
* Contributing: #contributing
* License: #license

**Project Description**

This was a college project but was built further than the guidelines. It has basic GUI using Windows Forms for input and output. A user inputs the loan amount, interest rate and the loan term (years). The system uses a class called MortgagaCalculator to manipulate the input. The systems transforms the input data to an output. It displays the monthly repayment amount, total interest over the lifetime of the loan and the same with total amount. The system also generates an Amoraztion Schedule which displays the payment number, principal amount, interest, total payment and the balance of the loan.

The project has error handling to ensure that values stay within accepatable ranges. It also uses string maniuplation to ensure that the outputs are readable and clear. 

**Installation**

This C# Windows Form application requires the following prerequisites:

*Microsoft .NET Framework: 

    https://dotnet.microsoft.com/en-us/download/dotnet-framework (Specify the required version here).

*Visual Studio (Optional): While not strictly necessary, having Visual Studio installed (any version that supports your targeted .NET Framework version) can be helpful for browsing the source code or making modifications. You can download Visual Studio Community (free version) from https://visualstudio.microsoft.com/downloads/.

Once you have the prerequisites, follow these steps to install the application:

* Clone or Download the Repository:
If using Git, clone the repository using the following command in your terminal:     
Bash

        git clone https://github.com/cornielvorster/mortgageCalculator.git
Use code with caution.
Alternatively, you can download the ZIP file of the repository from GitHub and extract it to a desired location.

*Build the Solution (if using Git):
Open the solution file (.sln) in Visual Studio or another compatible IDE.
Build the solution (usually by navigating to Build -> Rebuild Solution). This will generate the executable file for your application.

*Run the Application:
Locate the executable file (usually named after your project and having a .exe extension). It's often placed in the bin or Debug folder within the project directory.
Double-click the executable file to launch the application.

*Additional Notes:

If your application has any specific dependencies beyond the .NET Framework, mention them here and provide instructions on how to install them.
Consider including a screenshot of your application's main window to give users a visual reference.


**Usage**

[Explain how to use your project after installation. Include examples or screenshots if helpful.]

**Contributing**

[If you welcome contributions, outline the guidelines and process for others to contribute to your project. Mention any code style guides or testing frameworks.]

**License**

MIT License

Copyright (c) 2023 Corniel Vorster

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

