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
    public partial class principalInvestigators : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Investigator> piGrid_GetData()
        {
            GrantsContext db = new GrantsContext();
            var query = db.Investigators;
            return query;
        }

        public void piGrid_UpdateItem(int pi_id)
        {   
            using (GrantsContext db = new GrantsContext())
            {
                Investigator item = null;
                item = db.Investigators.Find(pi_id);
                if (item == null)
                {
                    ModelState.AddModelError("",
                        String.Format("Item with id {0} was not found", pi_id));
                    return;
                }

                TryUpdateModel(item);
                if(ModelState.IsValid)
                {
                    db.SaveChanges();
                }
            }            
        }

        public void piGrid_DeleteItem(int pi_id)
        {
            using(GrantsContext db = new GrantsContext())
            {
                var item = new { PI_ID = pi_id };
                db.Entry(item).State = EntityState.Deleted;
                try
                {
                    db.SaveChanges();
                }
                catch(DbUpdateConcurrencyException)
                {
                    ModelState.AddModelError("",
                        String.Format("Item with id {0} no longer exists in the database", pi_id));

                }
            }
        }
    }
}