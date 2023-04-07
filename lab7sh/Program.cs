using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lab7sh
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\Admin\RiderProjects\lab7sh\text.txt";
            try
            {
                using (StreamReader fin = new StreamReader("test.txt")){
                    string N;
                    List<string> check = new List<string>();
                    while ((N = fin.ReadLine()) != null) {
                        check.Add(N);
                    }

                    string line = check[0];
                    Console.WriteLine(line);
                    string lWord = "";
                    string bufword = "";
                    int wordLen = 0;
                    int k = 0;
                    int duplicates = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ' ' || i == line.Length) {
                            bufword += line[i];
                            k += 1;
                        }
                        else {
                            if (k > wordLen) {
                                wordLen = k;
                                lWord = bufword;
                    
                            }
                            bufword = "";
                            k = 0;
                        }
                    }
                    bufword = "";
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ' ' || i == line.Length) {
                            bufword += line[i];             
                        }
                        else {
                            
                            if (bufword == lWord) duplicates += 1;
                            bufword = "";
                            k = 0;
                        }
                    }
                    if (bufword == lWord) duplicates += 1;
                    Console.WriteLine(lWord + " " + duplicates);
                    
                }
            }
            catch(IOException e)
            {
                Console.WriteLine($"The file could not be opened: '{e}'");
            } 
            
        }
    }
}