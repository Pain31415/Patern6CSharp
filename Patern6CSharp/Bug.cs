using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern6CSharp
{
    public class Bug : IProjectElement
    {
        public void Accept(IProjectVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
