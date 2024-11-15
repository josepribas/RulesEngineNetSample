# RulesEngineNetSample

This repository contains a sample project demonstrating the use of a rules engine in C#. The project reads rules from a JSON file, deserializes them into objects, and uses these objects to instantiate and execute a rules engine.

## Project Structure

- `Program.cs`: The main entry point of the application. It loads the rules from a JSON file, deserializes them, and executes the rules using the `RulesEngine`.
- `rules.json`: A JSON file containing the rules to be executed by the rules engine.

## Getting Started

### Prerequisites

- .NET SDK
- JetBrains Rider IDE (optional, but recommended)

### Running the Sample

1. Clone the repository:
    ```sh
    git clone https://github.com/josepribas/RulesEngineNetSample.git
    cd RulesEngineNetSample
    ```

2. Open the project in JetBrains Rider or your preferred IDE.

3. Ensure the `rules.json` file is present in the project directory with the following content:
    ```json
    [
      {
        "WorkflowName": "Discount",
        "Rules": [
          {
            "RuleName": "GiveDiscount10",
            "Expression": "input1.country == \"india\" AND input1.loyalityFactor <= 2 AND input1.totalPurchasesToDate >= 5000 AND input2.totalOrders > 2 AND input3.noOfVisitsPerMonth > 2"
          },
          {
            "RuleName": "GiveDiscount20",
            "Expression": "input1.country == \"india\" AND input1.loyalityFactor == 3 AND input1.totalPurchasesToDate >= 10000 AND input2.totalOrders > 2 AND input3.noOfVisitsPerMonth > 2"
          }
        ]
      }
    ]
    ```

4. Run the application:
    ```sh
    dotnet run
    ```

### Sample Output

The application will execute the rules and print the results to the console. Example output:
```
Rules Engine Sample
Rule - GiveDiscount10, IsSuccess - True
Rule - GiveDiscount20, IsSuccess - False
```

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.