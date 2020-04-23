﻿using System.Collections.Generic;
using System.Threading.Tasks;
using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Controllers.Connection
{
    public interface ConnectionController
    {
        bool Singup(AuthData user);
        bool Singin(AuthData user);
        void SendArticle(Article article);
        List<Article> GetArticlesFromServer();

        List<Article> GetAdminArticlesFromServer();
    }
}