using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommentApi.Models;

namespace CommentApi.Repository
{
    public class CommentRepository : ICommentRepository
    {
        static List<Comment> comments = new List<Comment>();
        
        public CommentRepository()
        {
            
        }

        public void Create()
        {
            Comment comment = new Comment();
            comment.IdComment = 1;
            comment.IdTopic = 1;
            comment.context = "Hello World";
            comment.dateCmt = DateTime.Now;

            comments.Add(comment);
        }

        public void Add(Comment comment)
        {
            comments.Add(comment);
        }

        public void Delete(int id)
        {
            var itemRemove = comments.SingleOrDefault(r => r.IdComment == id);
            if (itemRemove != null)
            {
                comments.Remove(itemRemove);
            }
        }

        public Comment Get(int id)
        {
            Comment tmp = null;
            foreach(Comment c in comments){
                if(c.IdComment == id)
                {
                    tmp = c;
                    break;
                }
            }
            return tmp;
        }

        public IEnumerable<Comment> GetAlls()
        {
            return comments;
        }

        public void Update(Comment comment)
        {
            var itemUpdate = comments.SingleOrDefault(r => r.IdComment == comment.IdComment && r.IdTopic==comment.IdTopic && r.IdUser == comment.IdUser);
            if (itemUpdate != null)
            {
                itemUpdate.context = comment.context;
                itemUpdate.dateCmt = DateTime.Now;
            }
        }
    }
}
