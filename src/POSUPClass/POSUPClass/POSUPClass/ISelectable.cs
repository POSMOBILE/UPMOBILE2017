using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSUPClass
{
    public interface ISelectable
    {
        string Label { get; set; }

        bool IsSelected { get; set; }
    }
}
