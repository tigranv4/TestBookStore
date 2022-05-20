using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataBase
{
    public partial class Book
    {
        public string UpdatedCost
        {
            get
            {
                if(App.dbcontext.MaxDiscount.Where(c => c.Id == SizeMaxDiscount).First().MaxDiscount1 > 0)
                {
                    double k = (Convert.ToDouble(Cost) * Convert.ToDouble(CurrentDiscount)) / 100;
                    double res = Convert.ToDouble(Cost) - k;
                    return res.ToString();
                }
                else
                {
                    return null;
                }
            }
        }
        public bool IsDescointed
        {
            get 
            {
                if (string.IsNullOrEmpty(CurrentDiscount.ToString()))
                {
                    return false;
                }
                else 
                {
                    return true;
                }
            }
        }
        public string UpdateColor
        {
            get
            {
                if (App.dbcontext.MaxDiscount.Where(c => c.Id == SizeMaxDiscount).First().MaxDiscount1 > 15)
                {
                    return "#7fff00";
                }
                else
                {
                    return "Transparent";
                }
            }
        }

        public string IfDiscount
        {
            get
            {
                if (CurrentDiscount > 0)
                {
                    return "Strikethrough";
                }
                else
                    return "None";
            }
        }
    }
}
