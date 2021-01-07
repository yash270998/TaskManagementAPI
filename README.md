# TaskManagementAPI

### Built With
This section should list any major frameworks that you built your project using. Leave any add-ons/plugins for the acknowledgements section. Here are a few examples.
* [Asp.net core](https://dotnet.microsoft.com/learn/aspnet/what-is-aspnet-core)
* [Asp.net Web API](https://dotnet.microsoft.com/apps/aspnet/apis)
* [SQL Server](https://jquery.com)
* [Visual Studio 2019]()

### Installation

Follow these steps to get your development environment set up:
1. Clone the repository
```sh
git clone https://github.com/yash270998/TaskManagementAPI.git
```
2. Change into the project directory by running:
```sh
cd TaskManagementAPI
```
3. At the root directory, restore required packages by running:
```csharp
dotnet restore
```
4. Next, Go to the Nuget Package manager console and add command to install the tables into the database by migrating from the models:
```csharp
Add-migration <string>
```
5. Then, Add command  to update the database:
```csharp
Update-database
```
6. Next, build the solution by running:
```csharp
dotnet build
```
7. Next, within the project directory, launch the application by running:
```csharp
dotnet run
```
8. Launch http://localhost:5000/ in your browser to view the Web UI.

### Requirements for Tasks and Subtasks State 

1. TMS contains information about tasks. Task can contain one or more subtasks. 
2. For every task following attributes are stored in TMS: <br />
    a. Name  <br />
    b. Description <br />
    c. Start date <br />
    d. Finish date <br />
    e. State <br />
3. If task doesn't have subtasks, then state Of task is set when task is updated and can be one 
Of the following values: Planned, inProgress, Completed 
4. If task has subtasks, then its state is calculated by the following rules: <br />
    a. Completed, if all subtasks have state Completed <br />
    b. inprogress, if there is at least one subtask with state inProgress <br /> 
    c. Planned in all Other cases 
