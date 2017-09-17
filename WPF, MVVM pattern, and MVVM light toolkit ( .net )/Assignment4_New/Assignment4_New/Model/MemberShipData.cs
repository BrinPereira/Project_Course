using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment4_New.Model
{
    class MemberShipData : ObservableObject
    {
     // path for the text file.
        private const string dir = @"F:\CSU LONG BEACH\summer 2017\dotnet\";
        private const string path = dir + "members4.txt";

    // method to return the list of members. 
        public static ObservableCollection<Member> GetMemberships()
        {
            ObservableCollection<Member> membersList = new ObservableCollection<Member>();
            try
            {
                StreamReader sr = new StreamReader(path);
                string[] separators = { " - ", " " };
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    try
                    {
                        string[] properties = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                        Member member = new Member(properties[0], properties[1], properties[2]);
                        membersList.Add(member);
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        MessageBox.Show("One or more of this member's properties are longer than 25 characters: " + e.ActualValue);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("There was an error in reading a line from this text file: \n" + sr.ToString() + "\n" + e.ToString());
                    }
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return membersList;
        }
        
    // method to save new members or edited values of members in text file.
        public static void SaveMemberships(ObservableCollection<Member> members)
        {
            try
            {
                StreamWriter sr = new StreamWriter(
                                        new FileStream(path, FileMode.Create));

                foreach (Member m in members)
                {
                    sr.WriteLine(m.GetDisplayText);
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
