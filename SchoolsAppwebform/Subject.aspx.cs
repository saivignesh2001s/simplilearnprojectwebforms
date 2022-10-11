using BAL;
using Hiding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolsAppwebform
{
    public partial class Subject : System.Web.UI.Page
    {
        SubjectMethods cs = null;
        public Subject()
        {
            cs = new SubjectMethods();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Subjectdata> s = cs.Subjlist();
            GridView1.DataSource = s;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Subjectdata s1 = new Subjectdata();
            s1.subid = Convert.ToInt32(TextBox1.Text);
            s1.subname = TextBox2.Text.ToString();
            s1.cid = Convert.ToInt32(TextBox3.Text);
            cs.AddSubject(s1);
            List<Subjectdata> s = cs.Subjlist();
            GridView1.DataSource = s;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Subjectdata s1 = new Subjectdata();
            s1.subid = Convert.ToInt32(TextBox1.Text);
            s1.subname = TextBox2.Text.ToString();
            s1.cid = Convert.ToInt32(TextBox3.Text);
            cs.updatesubject(s1);
            List<Subjectdata> s = cs.Subjlist();
            GridView1.DataSource = s;
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Subjectdata s1 = new Subjectdata();
            s1.subid = Convert.ToInt32(TextBox1.Text);
            s1.subname = TextBox2.Text.ToString();
            s1.cid = Convert.ToInt32(TextBox3.Text);
            cs.RemoveSubject(s1.subid);
            List<Subjectdata> s = cs.Subjlist();
            GridView1.DataSource = s;
            GridView1.DataBind();

        }
    }
}