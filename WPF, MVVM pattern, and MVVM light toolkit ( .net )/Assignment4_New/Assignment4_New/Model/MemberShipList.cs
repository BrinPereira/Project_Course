using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_New.Model
{
    class MemberShipList : ObservableObject
    {
        ObservableCollection<Member> member_list;
        public MemberShipList()
        {
            member_list = new ObservableCollection<Member>();
        }
        // code for indexer.
        public Member this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                else if (i >= member_list.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                return member_list[i];
            }
            set
            {
                member_list[i] = value;
            }
        }

        // count method to keep track of the members in the list.
        public int count => member_list.Count;

        // method to add member in the list. 
        public void addMember(Member member)
        {
            member_list.Add(member);
        }

        // method to remove the member from the list.
        public void removeMember(Member member)
        {
            member_list.Remove(member);
        }

        // method to save member from file.
        public void save()
        {
            MemberShipData.SaveMemberships(member_list);
        }

        // method to get members from the file.
        public void write()
        {
            member_list = MemberShipData.GetMemberships();
        }

        // + operator overloading for adding the members.
        public static MemberShipList operator +(MemberShipList l1, Member m)
        {
            l1.addMember(m);
            return l1;
        }

        // - operator overloading for deleting the member. 
        public static MemberShipList operator -(MemberShipList l2, Member m)
        {
            l2.removeMember(m);
            return l2;
        }
    }
}
