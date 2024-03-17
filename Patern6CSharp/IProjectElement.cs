using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern6CSharp
{
    public interface IProjectElement
    {
        void Accept(IProjectVisitor visitor);
    }
}
