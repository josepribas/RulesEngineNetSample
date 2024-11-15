// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using RulesEngine.Models;

Console.WriteLine("Rules Engine Sample");

// Load rules from JSON file
var workflowRulesJson = File.ReadAllText("rules.json");
var workflows = JsonSerializer.Deserialize<List<Workflow>>(workflowRulesJson);

// Instantiate the RulesEngine
var re = new RulesEngine.RulesEngine(workflows!.ToArray());

// Declare input1, input2, input3 (ensure these are properly defined)
dynamic input1 = new { country = "india", loyalityFactor = 2, totalPurchasesToDate = 5000 };
dynamic input2 = new { totalOrders = 3 };
dynamic input3 = new { noOfVisitsPerMonth = 3 };

// Declare input1,input2,input3 
var resultList  = await re.ExecuteAllRulesAsync("Discount", input1,input2,input3);

//Check success for rule
foreach(var result in resultList){
    Console.WriteLine($"Rule - {result.Rule.RuleName}, IsSuccess - {result.IsSuccess}");
}