using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW3
{
    public partial class Test : System.Web.UI.Page
    {
        string[] sa_Cate = new string[2] { "蔬菜", "水果" };
        string[,] sa_Food = new string[2, 2] { { "A菜", "空心菜" }, { "番茄", "火龍果" } };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i_ct = 0; i_ct < sa_Cate.Length; i_ct++)
                {
                    ListItem downlist1 = new ListItem();
                    downlist1.Text = downlist1.Value = sa_Cate[i_ct];
                    ddl_Category.Items.Add(downlist1);
                }
                mt_GenSecondList();
            }
        }
        protected void mt_GenSecondList()
        {
            int i_ind = ddl_Category.SelectedIndex;
            ddl_Food.Items.Clear();
            for (int i_Ct = 0; i_Ct < sa_Food.GetLength(1); i_Ct++)
            {
                ListItem downlist2 = new ListItem();
                downlist2.Text = downlist2.Value = sa_Food[i_ind,i_Ct];
                ddl_Food.Items.Add(downlist2);
            }
        }
        protected void ddl_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            mt_GenSecondList();
        }
    }
}