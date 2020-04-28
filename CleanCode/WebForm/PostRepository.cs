using System.Linq;

namespace CleanCode.FullRefactoring
{
    public class PostRepository
    {
        private readonly PostDbContext _dBContext;
        
        public PostRepository()
        {
            _dBContext = new PostDbContext();
        }
        
        public Post GetPost(int postId)
        {
            return _dBContext.Post.SingleOrDefault(p => p.Id == postId);
        }
        
        private void SavePost(Post post)
        {
            _dBContext.Post.Add(post);
            _dBContext.SaveChange();
        }
    }
}
