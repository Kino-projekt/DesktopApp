using System;
using System.Collections.Generic;
using System.Net.Http;
using DesktopApp.Backend.Data;
using Newtonsoft.Json;

namespace DesktopApp.Backend.Controllers.Connection.Methods.Creators
{
    public class ArticleListCreator
    {
        public static List<Article> CreateArticles(HttpResponseMessage response)
        {
            string body = response.Content.ReadAsStringAsync().Result;
            List<Object> objects = JsonConvert.DeserializeObject<List<Object>>(body);
            if (objects.Count == 0)
            {
                return null;
            }
            else
            {
                return DecodeList(objects);
            }
        }

        private static List<Article> DecodeList(List<Object> objects)
        {
            List<Article> articles = new List<Article>();
            int size = objects.Count;

            for (int i = 0; i < size; i++)
            {
                Article article = new Article();
                dynamic articeObject = objects[i];

                article.SetId((int)articeObject.id);
                article.SetTitle((string)articeObject.title);
                article.SetDescription((string)articeObject.description);
                string status = (string)articeObject.status;
                if(status=="ACTIVE")
                    article.SetStatus(Status.Active);
                else
                    article.SetStatus(Status.Inactive);
                   
                articles.Add(article);
            }
            return articles;
        }

    }
}