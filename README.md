# CourierFramework8
Delivery Cost Estimate Problem 1

1. Used following ChatGPT prompts to create basic structure of the solution and resolve some errors: https://chatgpt.com/share/69b14087-6514-8009-9806-895d47ce6449

2. If you get errors relating to missing references:

   Add the Devepdency Injection package to the project by running: dotnet add package Microsoft.Extensions.DependencyInjection

   or

   In Visual Studio 2022, hover the mouse over ServiceCollection(), click "Show Potential Fixes" and Select "Download and Install the latest package"

3. To run the project, open the terminal and navigate to the project directory, then execute: dotnet run

4. To add new discount rules, create a new class that implements the IDiscountRule interface and implement the CalculateDiscount method(refer PercentageDiscount10.cs). 
   Then, register the new discount rule in the ConfigureServices method of the Program.cs file.


=======================To run the application=======================
1. Clone the repository to your local machine.

2. Open the terminal and navigate to the project directory, then execute: dotnet run
You might get some warnings, but the program should run successfully and you can input the parameters as defined in the problem statement.
 or

3. Run the project in Visual Studio 2022 by pressing F5 or clicking the "Start" button.

====================================================================




=======================Sample Input=======================
Enter the parameters as defined in the problem
100 3
PKG1 5 5 OFR001
PKG2 15 5 OFR002
PKG3 10 100 OFR003
==========================================================




