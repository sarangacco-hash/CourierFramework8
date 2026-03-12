using CourierService.Configuration;
using CourierService.Models;
using CourierService.Services;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddServices();

var provider = services.BuildServiceProvider();

var priceCalculatorService = provider.GetRequiredService<BasePriceCalculationService>();

var discountService = provider.GetRequiredService<DiscountService>();

string[] firstLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

int packageCount = 0;

int baseCost = 0;

//no inputs provided, exit the program
if (firstLine.Length < 2)
    return;

int.TryParse(firstLine[0], out baseCost);
int.TryParse(firstLine[1], out packageCount);

if (packageCount <= 0)
{
    return;
}

if (baseCost <= 0)
{
    return; 
}

var packages = new List<Package>();

for (int i = 0; i < packageCount; i++)
{
    string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    var weight = 0m;
    var distance = 0m;

    //if there are no sufficient inputs , skip the line and move to next line
    if (line.Length < 2)
        continue;

    decimal.TryParse(line[1], out weight);

    decimal.TryParse(line[2], out distance);

    var basePrice = priceCalculatorService.Calculate(baseCost, distance, weight);

    var discountApplicable = 0m;
    var discountCode = string.Empty;
    //if there is no discount code provided, then skip the discount calculation and move to next line
    if (line.Length > 3)
    {
        discountCode = line[3].ToUpper();
        discountApplicable = discountService.ApplyDiscount(discountCode, basePrice, distance, weight);
    }

    var package = new Package
    {
        PackageId = line[0],
        Weight = weight,
        Distance = distance,
        OfferCode = discountCode,
        FinalPrice = basePrice - discountApplicable,
        DiscountAmount = discountApplicable
    };

    packages.Add(package);
}

foreach (var package in packages)
{
    Console.WriteLine($"{package.PackageId} {(int)package.DiscountAmount} {(int)package.FinalPrice}");
}

//Keep for testing
//Console.ReadLine();