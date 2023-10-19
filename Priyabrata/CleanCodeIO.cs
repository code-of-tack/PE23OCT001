using System;
using System.Collections.Generic;
using System.IO;
internal class q4
{
    public static void ReadWrite()
    {
        String line;
        try
        {
            //Pass the file path and file name to the StreamReader and StreamWriter constructor
            StreamReader sr = new StreamReader(@"C:\Users\priya\OneDrive\Desktop\readfile.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\priya\OneDrive\Desktop\writefile.txt");
            
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                line=line.ToUpper();
                //write the line to 2nd file
                sw.WriteLine(line);
                //Read the next line
                line = sr.ReadLine();
            }
            //close the files
            sr.Close();
            sw.Close();
            
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }

    }
  static void Main(string[] args)
  {
    q4.ReadWrite();
  }
}
