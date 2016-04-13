using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            // var file1 = File.Create("File1.txt");

            // //Put break point on line 26 and run the application and see the error. 
            // //See what Path.Combine does?? It combines TWO paths into a single path. 
            // // Here we will get an error because once it
            // // hits the break point, it'll do xxxx\Folder2\File1.txt....therefore we first need to 
            // //create a folder (DIRECTORY) called Folder2.....so let's do this on line 37

            //// var file2 = File.Create(Path.Combine("Folder2", "File1.txt"));

            // // Now, comment out above 2 lines of code and then check C-drive for a folder called
            // // Folder2 after you run the below  code...Note, the '@' removes the red 
            // //squiggly error we get because '\' is a special character which we must escape. Remove
            // // the '@' symbol and see for yourself
            // // Note how I am saying only create this folder (Directory) called Folder2 if it 
            // // DOES NOT EXIST.... !Directory.Exists(...) means if Directory NOT exist....therefore
            // // '!' means negating the if condition...so if it doesn't exist, only then go ahead
            // // and create it

            if (!Directory.Exists(@"C:\Folder2"))
            {
                Directory.CreateDirectory(@"C:\Folder2");
            }

            // // Now paste the line of code in line 26...var file2 =..... rename to var file3 =...
            // // Put break point on line 49 then press f10 and see the path. It'll save File1.txt into Folder2 in
            // // your c-drive. Use intellisense it hits break point to see value of file3 and really
            // // see what Path.Combine does. Converts two paths into a single path, so, you can say,
            // // C:\Folder2 is path 1 and File1.txt is path 2.....so Path.Combine will make this into
            // // C:\Folder2\File1.txt
            // var file3 = File.Create(Path.Combine(@"C:\Folder2", "File1.txt"));

            // // Let's save a long line of text in File1.txt. 
            // File.WriteAllText(@"C:\Folder2\File1.txt", "Hey you are you ok?");
            // //As we can see, if our content is long, say a paragraph, then this line of code would 
            // // look horrible. For this reason when we want to add loads of strings, we use 
            // //stringbuilder. Let's use it.

            // StringBuilder builder = new StringBuilder();
            // builder.Append("Hi are you ok I am fine.").AppendLine("This will be on a new line");
            // File.WriteAllText(@"C:\Folder2\File1.txt", builder.ToString());
            // // Things to note about stringbuilder are that we can keep appending (adding strings) and 
            // // you see that in line 60, we simply pass in builder.ToString() as the second argument.
            // // Remember that 2nd argument in File.WriteAllText is the content which is of type string.
            // // However, our builder object is of type StringBuilder and that is why we do 
            // // builder.ToString() to convert from type StringBuilder to type string. Note that in
            // // StringBuilder I do .Append() then .AppendLine()...I do this because AppendLine() means
            // // it will automatically put the text onto the next line

            // // File.WriteAllLines, we have to append an Array of strings instead of just string.
            // // As you can see, in the second argument we pass in array of strings, in this case 2. 
            // // We can do Stringbuilder example with File.WriteAllLines. 
            // File.WriteAllLines(@"C:\Folder2\File1.txt", new string[] {"Umer is ok", "Adeeb is OK"});

            // StringBuilder builder1 = new StringBuilder();
            // builder1.Append("Umer is ok").AppendLine("Is Adeeb OK");

            // StringBuilder builder2 = new StringBuilder();
            // builder2.Append("Is this good?").AppendLine("Surely it is not");

            // File.WriteAllLines(@"C:\Folder2\File1.txt", new List<string> {builder1.ToString(), "Are we OK?", builder2.ToString()});
            // //Note above how we passed in 3 arguments: builder1.ToString(), Hardcoded string, builder2.ToString()
            // // Also note how we used List String instead of array. Can use either. So the above example
            // // as an array would be: 
            // File.WriteAllLines(@"C:\Folder2\File1.txt", new string[] { builder1.ToString(), "Are we OK?", builder2.ToString() });

            // // Now go repeat the above using File.AppendAllText() and File.AppendAllLines().
            // // Remember that File.AppendAllText() is the same as File.WriteAllText() except that in
            // // .AppendAllText() the existing content in the file is NOT overwritten. In .WriteAllText()
            // // the content in the file IS overwritten. Again, File.AppendAllLines(), adds to existing
            // // content in the file whereas File.WriteAllLines() replaces the content in the file. 
            // // File.AppendAllLines() and File.WriteAllLines() expect an ARRAY/LIST of strings whereas
            // // File.AppendAllText() and File.WriteAllText() expect a single string object


            // Simply create Microsoft Word 97-2003 document
            File.WriteAllText(@"C:\Folder2\Test.doc", "Hi word doc.\r\nNew line here!");

            // Create a Microsoft word document (post 2007)
            File.WriteAllText(@"C:\Folder2\Test1.docx", "Hi word doc");

            // Create PDF document
            File.WriteAllText(@"C:\Folder2\Test.pdf", "Hi PDF doc");

            // Create 97-2003 Excel document
            File.WriteAllText(@"C:\Folder2\Test2.xls", "Hi Excel doc");

            // Create Excel document (post 2007)
            File.WriteAllText(@"C:\Folder2\Test3.xlsx", "Hi Excel doc");

            //Delete file if it exists
            if (File.Exists(@"C:\Folder2\Test3.xlsx"))
            {
                File.Delete(@"C:\Folder2\Test3.xlsx");
            }

            // Automatically open a file! 
            Process.Start(@"C:\Folder2\Test.doc");
            
            // Copy file from old file Test.doc to a new file TestCopy.doc (both will be in Folder2 obviously)
            // 'true' means that in future if we copy into TestCopy.doc then it will override (replace)
            // what is already in there
            File.Copy(@"C:\Folder2\Test.doc", @"C:\Folder2\TestCopy.doc", true);

            // Let's read from a file and print the contents to the console window. Inside Test.Doc 
            // in line 97 I have made sure we have more than one line of text. Therefore we have more
            // than one line, therefore we have IEnumerable of lines meaning that we have a COLLECTION/GROUP
            // of lines. So I have set the collection name to 'lines'. Once we get our group of 'lines'
            // we need to do a foreach loop to print EACH line in the GROUP of lines. HOVER YOUR
            // MOUSE OVER READLINES(). See how in the intellisense it says IEnumerable<string>?????? Now
            // you know how I knew to do IEnumerable<string> lines = ......
            IEnumerable<string> lines = File.ReadLines(@"C:\Folder2\Test.doc");

            // here we create a variable called myLine which is obv of type string because we have a 
            // collection / group of strings. Read the foreach loop like you are reading english, so
            // for EACH myLine in lines....print myLine....so if there are 2, it'll print 2 etc.
            foreach (string myLine in lines)
            {
                Console.WriteLine(myLine);
            }

            // We can also just read the file contents as a single string (no need for foreach loop) like so:
            // HOVER MOUSE OVER READALLTEXT....see in the intellisense it returns type string?????
            // Now you now why I said string content =.......
            string content = File.ReadAllText(@"C:\Folder2\Test.doc");
            Console.WriteLine(content);


            //See how similar (almost IDENTICAL) this array example is to the IEnumerable example? That's
            // because Array implements IEnumerable interface!!! So does List. In Simple English, List
            // and arrays are COLLECTIONS, they have a COLLECTION of items....therefore to print EACH
            // INDIVIDUAL item, we must LOOP through the results via the foreach loop!!!
            string[] linesInFile = File.ReadAllLines(@"C:\Folder2\Test.doc");

            foreach (string lineInFile in linesInFile)
            {
                Console.WriteLine(lineInFile);
            }

            Console.ReadLine();
            string variableHereSoYouCanMovePastLine49BreakPointAndSeeTheValueInIntellisense = String.Empty;

            #endregion
        }
    }
}

