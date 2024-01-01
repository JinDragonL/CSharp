using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Property
{
    public class Subject
    {
        private int _id;

        private readonly string _name;

        const string _description = "description";

        public int Name { get; set; }

        public Subject()
        {
            
        }

        public void GetSubject() {

            return;
        
        }

    }

    public class ExecuteSubject
    {
        public void Execute() { 
        
            Subject subject = new Subject();

            subject.GetSubject();
        }
    }
}
