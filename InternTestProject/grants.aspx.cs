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

        public void grantsGrid_UpdateItem(int GrantNum)
        {
            using (GrantsContext db = new GrantsContext())
            {
                Grant item = null;
                item = db.Grants.Find(GrantNum);
                if(item == null)
                {
                    ModelState.AddModelError("",
                        String.Format("Item with id {0} was not found", GrantNum));
                    return;
                }

                TryUpdateModel(item);
                if(ModelState.IsValid)
                {
                    db.SaveChanges();
                }
            }
        }

        public void grantsGrid_DeleteItem(int GrantNum)
        {
            using (GrantsContext db = new GrantsContext())
            {
                db.Entry(db.Grants.Find(GrantNum)).State = EntityState.Deleted;
                try
                {
                    db.SaveChanges();
                }
                catch(DbUpdateConcurrencyException)
                {
                    ModelState.AddModelError("",
                        String.Format("Item with id {0} no longer exists in database", GrantNum));
                }
            }
        }
    }
}