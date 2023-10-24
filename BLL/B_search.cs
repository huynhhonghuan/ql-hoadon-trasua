using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class B_search
    {
        public static B_search instance;
        public static B_search Instance
        {
            get
            {
                if (instance == null)
                    instance = new B_search();
                return instance;
            }
        }
        public List<Menu_DTO> Search(string s)
        {
            return D_search.Instance.Search(s);
        }
        public DataTable type_product(string id)
        {
            return D_search.Instance.Type_product(id);
        }
    }
}
