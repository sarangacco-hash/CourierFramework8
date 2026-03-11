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




