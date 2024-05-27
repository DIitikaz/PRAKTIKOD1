# CLI Project in .NET

## Project Overview
This project involves creating a Command Line Interface (CLI) tool in .NET to package code files into a single file for easy distribution.

## Usage
1. **Installation**:
   - Make sure you have the required library `System.CommandLine` installed.
  
2. **Creating a Bundle**:
   - Use the `bundle` command to package code files.
   - Define the following options for the `bundle` command:
     - `language`: Specify the programming languages to include.
     - `output`: Provide the filename or full path for the output bundle.
     - `sort`: Choose the order for copying code files.
     - `remove-empty-lines`: Option to remove empty lines in code files.
     - `author`: Include the creator's name in the bundle.

3. **Generating Response Files** (optional):
   - Use the `create-rsp` command to generate response files for predefined commands.

## Getting Started
1. Clone the repository: `git clone `
2. Build the project: `dotnet build`
3. Run CLI commands: `dotnet CMD`
