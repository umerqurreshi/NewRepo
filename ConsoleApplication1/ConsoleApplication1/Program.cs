using System;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
#region Creating, saving, deleting files

            // Everything here we use in real life so if you learn this: MASSIVE step!!!

            // Create a simple txt file and SEE where it is saved
            //Put break point on line 18 and run code, when it hits break point, press f10 and see the
            //value of 'file1' then go and find it by doing the below steps:
            // On right hand side in solution explorer, right click solution and click  
            // view folder in file explorer...Now find File1.txt...use value of file1 to help you!
            var file1 = File.Create("File1.txt");

            //Put break point on line 26 and run the application and see the error. 
            //See what Path.Combine does?? It combines TWO paths into a single path. 
            // Here we will get an error because once it
            // hits the break point, it'll do xxxx\Folder2\File1.txt....therefore we first need to 
            //create a folder (DIRECTORY) called Folder2.....so let's do this on line 37

            var file2 = File.Create(Path.Combine("Folder2", "File1.txt"));

            // Now, comment out above 2 lines of code and then check C-drive for a folder called
            // Folder2 after you run the below  code...Note, the '@' removes the red 
            //squiggly error we get because '\' is a special character which we must escape. Remove
            // the '@' symbol and see for yourself
            // Note how I am saying only create this folder (Directory) called Folder2 if it 
            // DOES NOT EXIST.... !Directory.Exists(...) means if Directory NOT exist....therefore
            // '!' means negating the if condition...so if it doesn't exist, only then go ahead
            // and create it

            if (!Directory.Exists(@"C:\Folder2"))
            {
                Directory.CreateDirectory(@"C:\Folder2");
            }

            // Now paste the line of code in line 26...var file2 =..... rename to var file3 =...
            // Put break point on line 49 then press f10 and see the path. It'll save File1.txt into Folder2 in
            // your c-drive. Use intellisense it hits break point to see value of file3 and really
            // see what Path.Combine does. Converts two paths into a single path, so, you can say,
            // C:\Folder2 is path 1 and File1.txt is path 2.....so Path.Combine will make this into
            // C:\Folder2\File1.txt
            var file3 = File.Create(Path.Combine(@"C:\Folder2", "File1.txt"));

            string variableHereSoYouCanMovePastLine49BreakPointAndSeeTheValueInIntellisense = String.Empty;

#endregion
        }
    }
}

