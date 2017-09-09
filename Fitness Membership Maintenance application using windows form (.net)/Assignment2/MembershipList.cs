using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class MembershipList
    {
        private List<Member> members;

    // declaring delegates .
        public delegate void changeHandler(MembershipList m);

    // declaring event that will used when event is fired.
        public event changeHandler changed;

    //default construtor.
       public MembershipList()
        {
            members = new List<Member>();
        }

    // code for indexer.
        public Member this[int i]
        {
            get
            {
                if(i<0)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                else if (i >= members.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                return members[i];
            }

            set
            {
                members[i] = value;
                changed(this);
            }
        }

    // count method to keep track of the members in the list.
        public int count => members.Count;
    
    // method to add member in the list. 
        public void addMember(Member member)
        {
            members.Add(member);
            changed(this);
        }

    // method to remove the member from the list.
        public void removeMember(Member member)
        {
            members.Remove(member);
            changed(this);
        }

    // method to save member from file.
        public void save()
        {
            MembershipData.saveMemberships(members);
        }

    // method to get members from the file.
        public void write()
        {
           members= MembershipData.getMemberships();
        }

    // + operator overloading for adding the members.
        public static MembershipList operator +(MembershipList l1, Member m)
        {
            l1.addMember(m);
            return l1;
        }

    // - operator overloading for deleting the member. 
        public static MembershipList operator -(MembershipList l2, Member m)
        {
            l2.removeMember(m);
            return l2;
        }
    }
}
