using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;
using Hiding;


namespace SchoolsAppwebform
{
    public partial class Student : System.Web.UI.Page
    {
        Studentmethod cs = null;
        public Student()
        {
            cs = new Studentmethod();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Studentdata> s = cs.studentdatas();
            GridView1.DataSource=s;
            GridView1.DataBind();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Studentdata s = new Studentdata();
            s.sid = Convert.ToInt32(TextBox1.Text);
            s.sname = TextBox2.Text.ToString();
            s.cid = Convert.ToInt32(TextBox3.Text);
            cs.AddStudent(s);
            List<Studentdata> sq = cs.studentdatas();
            GridView1.DataSource = sq;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Studentdata s = new Studentdata();
            s.sid = Convert.ToInt32(TextBox1.Text);
            s.sname = TextBox2.Text.ToString();
            s.cid = Convert.ToInt32(TextBox3.Text);
            cs.updateStudent(s);
            List<Studentdata> sq = cs.studentdatas();
            GridView1.DataSource = sq;
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Studentdata s = new Studentdata();
            s.sid = Convert.ToInt32(TextBox1.Text);
            s.sname = TextBox2.Text.ToString();
            s.cid = Convert.ToInt32(TextBox3.Text);
            cs.RemoveStudent(s.sid);
            List<Studentdata> sq = cs.studentdatas();
            GridView1.DataSource = sq;
            GridView1.DataBind();

        }
    }
}