using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_KelD08.JAPRI.Model
{
    public interface IM_Connectdb
    {
        public List<object> Get();

        public void Insert(object obj);

        public void Delete(int id);

        public void Update(object obj, int id);
    }
}
