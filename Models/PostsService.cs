using System;
using System.Collections.Generic;
using System.Linq;


namespace Killar.Models
{
    public class PostsService
    {

        public int AddPost(Posts newPost)
        {
            using (KillarContext dataBase = new KillarContext())
            {

                dataBase.Add(newPost);
                dataBase.SaveChanges();
                return newPost.Id;
            }
        }


        public Posts ListPosts(int id)
        {
            using (KillarContext dataBase = new KillarContext())
            {
                return dataBase.Posters.Find(id);
            }
        }

        public int CountRegister()
        {
            using (KillarContext dataBase = new KillarContext())
            {
                return dataBase.Posters.Count();
            }
        }

        public ICollection<Posts> GetPosts(string q, int page, int size) // Método de paginação
        {
            using (KillarContext dataBase = new KillarContext())
            {
                int jump = (page - 1) * size;
                IQueryable<Posts> query = dataBase.Posters.Where(p => p.Content.Contains(q, StringComparison.OrdinalIgnoreCase));

                if (q != null)
                {

                    query = query.OrderBy(p => p.Content);

                }

                return query.Skip(jump).Take(size).ToList();

            }
        }

        public ICollection<Posts> GetPostsFull(PostsFilter postfilter)
        {
            using (KillarContext dataBase = new KillarContext())
            {
                Posts p = new Posts();
                IQueryable<Posts> query;

                if (postfilter != null)
                {
                    switch (postfilter.FilterType)
                    {

                        case "Nome":
                            query = dataBase.Posters.Where(p => p.Author.Contains(postfilter.Filter));

                            break;

                        case "Conteudo":
                            query = dataBase.Posters.Where(p => p.Content.Contains(postfilter.Filter));

                            break;

                        default:
                            query = dataBase.Posters;

                            break;
                    }
                }
                else
                {
                    query = dataBase.Posters;
                }

                List<Posts> PostList = query.OrderBy(e => e.PostDate).ToList();

                return PostList;

            }
        }

    }
}