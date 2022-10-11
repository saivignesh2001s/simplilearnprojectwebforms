using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Hiding;

namespace SchoolsAppwebform
{
    public partial class Class : System.Web.UI.Page
    {
        Classmethod c = null;
        public Class()
        {
            c = new Classmethod();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<classdata> s = c.classdatas();
            GridView3.DataSource = s;
            GridView3.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            classdata c1 = new classdata();
            c1.classId=Convert.ToInt32(TextBox1.Text);
            c1.cname = TextBox2.Text.ToString();
            c.AddClass(c1);
            List<classdata> s = c.classdatas();
            GridView3.DataSource = s;
            GridView3.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            classdata c1 = new classdata();
            c1.classId = Convert.ToInt32(TextBox1.Text);
            c1.cname = TextBox2.Text.ToString();
            c.updateClass(c1);
            List<classdata> s = c.classdatas();
            GridView3.DataSource = s;
            GridView3.DataBind();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            classdata c1 = new classdata();
            c1.classId = Convert.ToInt32(TextBox1.Text);
            c1.cname = TextBox2.Text.ToString();
            c.RemoveClass(c1.classId);
            List<classdata> s = c.classdatas();
            GridView3.DataSource = s;
            GridView3.DataBind();

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}