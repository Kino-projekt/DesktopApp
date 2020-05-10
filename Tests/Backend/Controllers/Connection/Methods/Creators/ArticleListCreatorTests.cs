using System;
using System.Collections.Generic;
using System.Net.Http;
using DesktopApp.Backend.Controllers.Connection.Methods.Creators;
using DesktopApp.Backend.Data;
using NUnit.Framework;

namespace Tests.Backend.Controllers.Connection.Methods.Creators
{
    public class ArticleListCreatorTests
    {
        [Test]
        public void EmptyResponse()
        {
            Assert.Throws< NullReferenceException > (() => ArticleListCreator.CreateArticles(new HttpResponseMessage()));
        }
    }
}