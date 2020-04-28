using System;
using System.Collection;
using System.Collection.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.UI.WebControls;
using Project.UserControls;

namespace CleanCode.FullRefactoring
{
    public class PostControl : System.Web.UI.UserControls
    {
        private readonly PostRepository _postRepository;
        private readonly PostValidator _validator;
        public Label PostBody { get; set; }
        public Label PostTitle { get; set; }
        public int? PostId { get; set; }
        
        public PostControl()
        {
            _postRepository = new PostRepository();
             _validator = new PostValidator();
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {   
            if(Page.IsPostBack)
                TrySavePost();
            else
                DisplayPost();
        }
        
        private void TrySavePost()
        {   
            var entity = GetPost();
            var results = _validator.Validator(entity);
            
            if(results.IsValid)
                _postRepository.SavePost(entity);
            else
                DisplayError(results);
        }
        
        private void DisplayError(ValidationResult results)
        {
            var summary = GetErrorSummaryControl();

            foreach(var error in results.Error)
            {
                var label = GetErrorLabel(error);
                
                if(label == null)
                    summary.Items.Add(new ListItem(error.ErrorMessage));
                else
                    label.Text = error.ErrorMessage;
            }
        }
        
        private BulletedList GetErrorSummaryControl()
        {
            return (BulletedList) FindControl("ErrorSummary");
        }
        
        private Label GetErrorLabel(ValidationError error)
        {
            return FindControl(error.PropertyName + "Error") as Label;
        }
        
        private void DisplayPost()
        {
            int postId = Convert.ToInt32(Request.QueryString["id"]);
            var post = _postRepository.GetPost(postId);
            PostBody.Text = post.Body;
            PostTitle.Text = post.Title;
        }
        
        private Post GetPost()
        {
            return new Post()
            {
                Id = Convert.ToInt32(PostId.Value),
                Title = PostTitle.Text.Trim(),
                Body = PostBody.Text.Trim()
            };
        }
    }
}
