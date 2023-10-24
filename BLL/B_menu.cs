using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.IO;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class B_menu
    {
        public static B_menu _instance;
        public static B_menu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new B_menu();
                return _instance;
            }
        }
        public List<Menu_DTO> Product_Image(string type_product)
        {
            return D_menu.Instance.Product_Image(type_product);
        }
        public bool Insert_bill(Menu_DTO mn)
        {
            return D_menu.Instance.Insert_bill(mn);
        }
        public bool Insert_detail_bill(List<Menu_DTO> mn)
        {
            for (int i = 0; i < mn.Count; i++)
            {
                bool kt = D_menu.Instance.Insert_detail_bill(mn[i]);
                if (kt == false)
                    return false;
            }
            if(D_menu.Instance.Update_bill()==false)
                return false;
            return true;
        }
        public int id_bill()
        {
            return D_menu.Instance.id_bill();
        }
    }
}
