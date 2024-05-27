using System;
using System.CommandLine;
var NoteOption = new Option<bool>("--note", " note File path and name") { Name="--n"};
var bundleOption = new Option<FileInfo>("--output", "File path and name") { Name="--o"};
var languesOption = new Option<string>("--language", "language list") { IsRequired = true,Name="--l" };
List<String> languageList = new List<String>() { "c#", "html" };
var SortOption = new Option<string>("--sort", "language list sort") { Name="--s"};
var bundlecommand = new Command("bundle", "bundle code files to a single file");
bundlecommand.AddOption(bundleOption);
bundlecommand.AddOption(languesOption);
//bundlecommand.AddOption(SortOption);
bundlecommand.AddOption(NoteOption);
bundlecommand.SetHandler((listlang,output,note) => {
    bool flag = false;
    var list = listlang.Split();
    try {
        if(list.Contains("all"))
        {
            foreach (var item in languageList)
            {
                Console.WriteLine(item);
            }
        }
        foreach (var item in list)
        {
            foreach (var item1 in languageList)
            {
                if (item == item1)
                {
                    flag = true;
                }
            }
            if (flag)
                Console.WriteLine(item);
            else
                throw new Exception("error language");
        }
       
        
    }
    catch (Exception e) { Console.WriteLine(e.Message);  }
    try
    {
        if (output != null)
        {
            
            if (note)
            {
                FileStream fs = new FileStream(output.FullName,
                              FileMode.Append,
                              FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs);
                writer.WriteLine("Y:\\Groups\\Group_3\\קצנלבוגן  יהודית\\cli\\CLI");
                writer.Close();

          }
            else
            {
                File.Create(output.FullName);
                Console.WriteLine("file was created");
            }

        }
    }
    catch (DirectoryNotFoundException ex)
    {
        Console.WriteLine("error:path is not valid");
    }
    catch (Exception ex) { Console.WriteLine(ex.Message); } 

}, languesOption, bundleOption,NoteOption);
var rootCommand = new RootCommand("rootCommand for File bundel cli");
rootCommand.AddCommand(bundlecommand);  
rootCommand.InvokeAsync(args);
