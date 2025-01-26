Test 1: Register a Valid JSON
Purpose: Verify that a valid JSON string can be successfully registered and retrieved.
Steps:
Call Initialize to prepare the repository.
Register a valid JSON string with Register("item1", "{\"key\": \"value\"}", 1).
Use Retrieve("item1") to get the stored content.
Assert that the retrieved value matches the input.
Test 2: Register an Invalid JSON
Purpose: Verify that the system rejects invalid JSON strings during registration.
Steps:
Call Initialize to prepare the repository.
Attempt to register an invalid JSON string using Register("item2", "invalid_json", 1).
Assert that the system throws an ArgumentException.
Output Example

D:\New Me\c#\Folmulatrix\B\RepositoryManagerSolution\RepositoryManager.Tests>dotnet test
Restore complete (1.8s)
  RepositoryManagerLibrary succeeded (0.4s) → D:\New Me\c#\Folmulatrix\B\RepositoryManagerSolution\RepositoryManagerLibrary\bin\Debug\net9.0\RepositoryManagerLibrary.dll
  RepositoryManagerApp succeeded (0.7s) → D:\New Me\c#\Folmulatrix\B\RepositoryManagerSolution\RepositoryManagerApp\bin\Debug\net9.0\RepositoryManagerApp.dll
  RepositoryManager.Tests succeeded (11.7s) → bin\Debug\net9.0\RepositoryManager.Tests.dll
[xUnit.net 00:00:00.01] xUnit.net VSTest Adapter v3.0.1+f8675c32e5 (64-bit .NET 9.0.1)
[xUnit.net 00:00:00.71]   Discovering: RepositoryManager.Tests
[xUnit.net 00:00:00.83]   Discovered:  RepositoryManager.Tests
[xUnit.net 00:00:00.90]   Starting:    RepositoryManager.Tests
[xUnit.net 00:00:01.22]   Finished:    RepositoryManager.Tests
  RepositoryManager.Tests test succeeded (10.6s)

Test summary: total: 3, failed: 0, succeeded: 3, skipped: 0, duration: 10.5s
Build succeeded in 27.5s