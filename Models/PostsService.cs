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
                dataBase.Add(newPost); // Adiciona ao banco de dados os dados de usuários que foram registrados;
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

                            query = dataBase.Posters.Where(p => p.Author.Contains(postfilter.Filter, StringComparison.OrdinalIgnoreCase));

                            break;

                        case "Conteudo": // FilterType = Conteudo
                            query = dataBase.Posters.Where(p => p.Content.Contains(postfilter.Filter, StringComparison.OrdinalIgnoreCase));

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

                List<Posts> PostList = query.OrderBy(e => e.PostDate).ToList(); // Atribui à uma lista de Posts uma busca que ordena os resultados de acordo com a data da publicação dos posts;

                return PostList;
            }
        }

        public void EditPost(Posts postEdit)
        {
            using (KillarContext dataBase = new KillarContext())
            {

                Posts foundPost = dataBase.Posters.Find(postEdit.Id);
                foundPost.Content = postEdit.Content;

                dataBase.SaveChanges();
            }
        }

        public void DeletePost(int id)
        {
            using (KillarContext dataBase = new KillarContext())
            {

                Posts foundPost = dataBase.Posters.Find(id);
                dataBase.Posters.Remove(foundPost);

                dataBase.SaveChanges();
            }
        }

        public Posts GetPostDetail(int id)
        {
            using (KillarContext dataBase = new KillarContext())
            {
                Posts foundPost = dataBase.Posters.Where(p => p.Id == id).SingleOrDefault();
                return foundPost;
            }
        }

    }
}
