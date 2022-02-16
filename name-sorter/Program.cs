using System;
using System.IO;

namespace name_sorter
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string txtFilePath = string.Empty;

            // checking for the filename at command prompt
            if (args.Length == 0 || args.Length > 1)
            {
                Console.WriteLine("File not found");
                return;
            }
            else
            {
                // checking the extension of text file
                txtFilePath = args[0];
                if (Path.GetExtension(txtFilePath) != ".txt")
                {
                    Console.WriteLine(" Text File not found ");
                    return;
                }
                else
                {
                    // Calling the method by passing the text file as a parameter
                    var names = SortedList(txtFilePath);

                    //Display the sorted list
                    Console.WriteLine("\t\t The sorted name list ");
                    Array.ForEach(names, Console.WriteLine);

                    // The sorted list store in the output text file using File.WriteAllLines Method
                    File.WriteAllLines(@"sorted-names-list.txt", names);

                }
            }


        }

        public static string[] SortedList(string fileName)
        {

            //Fetch all the lines in an name array using File.ReadAllLines method
            String[] names = File.ReadAllLines(fileName);

            //Initialise the array with given array length
            String[] lastFirstName = new string[names.Length];

            int counter = 0;

            foreach (string name in names)
            {
                string[] strSplitName = name.Split(" ");

                switch (strSplitName.Length)
                {
                    case 1:
                        lastFirstName[counter++] = strSplitName[0];
                        break;
                    case 2:
                        lastFirstName[counter++] = strSplitName[1] + " " + strSplitName[0];
                        break;
                    case 3:
                        lastFirstName[counter++] = strSplitName[2] + " " + strSplitName[0] + " " + strSplitName[1];
                        break;
                    case 4:
                        lastFirstName[counter++] = strSplitName[3] + " " + strSplitName[0] + " " + strSplitName[1] + " " + strSplitName[2];
                        break;
                    default:
                        break;
                }
            }

            // Sorting an array on lastname
            Array.Sort(lastFirstName, names);

            return names;

        }
    }
}
