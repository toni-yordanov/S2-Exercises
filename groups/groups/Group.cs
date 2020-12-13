using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groups
{
    public class Group
    {
        private string name;
        public List<Member> members = new List<Member>();

        public Group(string name)
        {
            this.name = name;
        }

        public void AddMember(string name)
        {
            Member member = new Member(name);
            members.Add(member);
        }

        public string GetInfo()
        {
            if (members.Count == 0)
            {
                return $"{name}";
                
            }
            else
            {
                string messages = "";
                foreach (Member m in members)
                {
                    messages += $"{m.GetInfo()}, ";
                }
                return $"{name}: {messages}";
            }
        }
    }
}
