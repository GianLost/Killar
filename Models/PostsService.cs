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
                dataBase.Add (newPost); // Adiciona ao banco de dados os dados de usuários que foram registrados;
                dataBase.SaveChanges(); // Salva no Banco as alterações;

                return newPost.Id;
            }
        }

        public ICollection<Posts> GetPostsFull(PostsFilter postfilter)
        {
            // Método que retorna a listagem de Posts no nível de administrador juntamente com a paginação e filtros relacionados a página de listagem de posts;
            using (KillarContext dataBase = new KillarContext())
            {
                Posts p = new Posts();

                IQueryable<Posts> query; // Cria-se um objeto de busca Linq de Posts

                if (
                    postfilter != null // verifica se o filtro não é nulo;
                )
                {
                    switch (postfilter.FilterType // Caso a verificação retorne true temos um switch case que indica o filtro selecionado e qual deverá ser o retorno de acordo com o filtro;
                    )
                    {
                        case "Nome": // FilterType = Name
                            query =
                                dataBase
                                    .Posters
                                    .Where(p =>
                                        p.Author.Contains(postfilter.Filter));

                            break;
                        case "Conteudo": // FilterType = Conteudo
                            query =
                                dataBase
                                    .Posters
                                    .Where(p =>
                                        p.Content.Contains(postfilter.Filter));

                            break;
                        default:
                            query = dataBase.Posters; // Caso o filtro não tenha sido informado;

                            break;
                    }
                }
                else
                {
                    query = dataBase.Posters; // Caso o filtro não tenha sido informado;
                }

                List<Posts> PostList = query.OrderBy(e => e.PostDate).ToList(); // Atribui á uma lista de Posts uma busca que ordena os resultados de acordo com a data da publicação dos posts;

                return PostList;
            }
        }

        /* public Posts ListPosts(int id)
        {
            // inutilizado no momento...
            using (KillarContext dataBase = new KillarContext())
            {
                return dataBase.Posters.Find(id);
            }
        }

        public int CountRegister()
        {
            // inutilizado no momento...
            using (KillarContext dataBase = new KillarContext())
            {
                return dataBase.Posters.Count();
            }
        }

        
        public ICollection<Posts> GetPosts(string q, int page, int size) // Método de paginação
        {
            // inutilizado no momento...
            using (KillarContext dataBase = new KillarContext())
            {
                int jump = (page - 1) * size;
                IQueryable<Posts> query =
                    dataBase
                        .Posters
                        .Where(p =>
                            p
                                .Content
                                .Contains(q,
                                StringComparison.OrdinalIgnoreCase));

                if (q != null)
                {
                    query = query.OrderBy(p => p.Content);
                }

                return query.Skip(jump).Take(size).ToList();
            }
        } */
    }
}
