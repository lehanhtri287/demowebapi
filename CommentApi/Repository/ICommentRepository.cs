using System.Collections.Generic;
using CommentApi.Models;

namespace CommentApi.Repository
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetAlls();
        void Add(Comment comment);
        Comment Get(int id);
        void Delete(int id);
        void Update(Comment comment);
        void Create();
    }
}
