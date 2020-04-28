using System;
using System.Collection;
using System.Collection.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.UI.WebControls;

namespace Project.UserControls
{
    public class PostControl : System.Web.UI.UserControls
    {
        private PostDbContext DBContext;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            DBContext = PostDbContext();
            
            if(Page.IsPostBack)
            {
                PostValidator validator = PostValidator();
                Post entity = new Post()
                {
                    // Map from fields to entity properties
                    Id = Convert.ToInt32(PostId.Value),
                    Title = PostTitle.Text.Trim(),
                    Body = PostBody.Text.Trim()
                };
                
                ValidtionResult results = validator.Validator(entity);
                
                if(results.IsValid)
                {
                    // save to the database and continue to the next page
                    DBContext = Post.Add(entity);
                    DBContext = SaveChange();
                }
                
                else
                {
                    BulletedList summary = (BulletedList)FindControl("ErrorSummary"));
                    
                    // Display errors to the user
                    foreach(var failure in results.Error)
                    {
                        Label errorMessage = FindControl(failure.PropertyName + "Error") as Label;
                        
                        if(errorMessage == null)
                        {
                            summary.Items.Add(new ListItem(failure.ErrorMessage));
                        }
                        else
                        {
                            errorMessage.Text = failure.ErrorMessage
                        }
                    }
                }
            }
            else
            {
                // display form
                Post entity = DBContext.Post.SingleOrDefault(p => p.Id == Convert.ToInt32(Request.QueryString["id"]));
                PostBody.Text = entity.Body;
                PostTitle.Text = entity.Title;
            }
        }
        public Label PostBody { get; set; }
        
        public Label PostTitle { get; set; }
    }
}
