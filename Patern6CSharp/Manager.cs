using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern6CSharp
{
    public class Manager : IProjectVisitor
    {
        public void Visit(Task task)
        {
            Console.WriteLine("Manager is reviewing a task.");
        }

        public void Visit(Bug bug)
        {
            Console.WriteLine("Manager is resolving a bug.");
        }
    }
}
