using System.Collections.Generic;
using Killar.Models;
using System.Linq;

namespace Killar.Models
{
    public class CommentsService
    {
        public int AddComment(Comments newComment)
        {
            using (KillarContext dataBase = new KillarContext())
            {
                dataBase.Add (newComment);
                dataBase.SaveChanges();
                return newComment.Id;
            }
        }

        public List<Comments> GetComentarios(int postId)
        {
            using (KillarContext dataBase = new KillarContext())
            {
                return dataBase.Comentarios.Where(c => c.PostsId == postId).ToList();
            }
        }
    }
}