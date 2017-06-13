using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using InternTestProject.Models;
using System.Data.Entity.Infrastructure;

namespace InternTestProject
{
    public partial class grants : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Grant> grantsGrid_GetData()
        {
            GrantsContext db = new GrantsContext();
            var query = db.Grants;
            return query;
        }

        public void grantsGrid_UpdateItem(int gNum)
        {
            using (GrantsContext db = new GrantsContext())
            {
                Grant item = null;
                item = db.Grants.Find(gNum);
                if(item == null)
                {
                    ModelState.AddModelError("",
                        String.Format("Item with id {0} was not found", gNum));
                    return;
                }

                TryUpdateModel(item);
                if(ModelState.IsValid)
                {
                    db.SaveChanges();
                }
            }
        }

        public void piGrid_DeleteItem(int gNum)
        {
            using (GrantsContext db = new GrantsContext())
            {
                var item = new { GrantNum = gNum };
                db.Entry(item).State = EntityState.Deleted;
                try
                {
                    db.SaveChanges();
                }
                catch(DbUpdateConcurrencyException)
                {
                    ModelState.AddModelError("",
                        String.Format("Item with id {0} no longer exists in database", gNum));
                }
            }
        }
    }
}