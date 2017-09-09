using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment2
{
    class MembershipData
    {
        private const string dir = @"F:\CSU LONG BEACH\summer 2017\dotnet\";
        private const string path = dir + "members.txt";
       
    // method to save the member in file.
        public static void saveMemberships(List<Member> customers)
        {
            checkDirectory();

            // create the output stream for a text file that exists.

            //if (File.Exists(path))
            //{
                StreamWriter textOut = new StreamWriter(
                                        new FileStream(path, FileMode.Create));

                // write each customer from the list to the file.
                foreach (Member line in customers)
                {
                    textOut.Write(line.FirstName + "|");
                    textOut.Write(line.LastName + "|");
                    textOut.WriteLine(line.Email);
                }

                // write the end of the document.
                textOut.Close();
            //}
        }

        // if the directory doesn't exist, create it.
        static void checkDirectory()
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }

        public static List<Member> getMemberships()
        {
            List<Member> listMember = new List<Member>();

            // create the object for the input stream for a text file.
            if(File.Exists(path))
            { 
            StreamReader textIn = new StreamReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            // read the data from the file and store it in the ArrayList.
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                Member m = new Member();
                m.FirstName = columns[0];
                m.LastName = columns[1];
                m.Email = columns[2];
               listMember.Add(m);

                }

                textIn.Close();
            }

            return listMember;
        }
    }
}
