using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InternTestProject.Models;

namespace InternTestProject
{
    public partial class AddGrant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void addGrantForm_InsertItem()
        {
            var item = new Grant();
            TryUpdateModel(item);
            if(ModelState.IsValid)
            {
                using(GrantsContext db = new GrantsContext())
                {
                    db.Grants.Add(item);
                    db.SaveChanges();
                }
            }
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/grants");
        }

        protected void addGrantForm_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/grants");
        }
    }
}