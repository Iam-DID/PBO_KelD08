using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_KelD08.JAPRI.Model
{
    public abstract class A_ConnectDB
    {
        public abstract void Execute_No_Return(string querry);
        public abstract DataTable Execute_With_Return(string querry);

    }
}
