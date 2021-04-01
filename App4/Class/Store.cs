using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4.Class
{
    public class Store
    {
        public Store(Article[] articles)
        {
            _articles = articles;
        }

        private Article[] _articles;

        public void ArticleInfoForIndex(int index)
        {
            try
            {
                if (index >= 0 && index < _articles.Length)
                {
                    _articles[index].ArticleInfo();
                }
                else
                {
                    Console.WriteLine("Введен неверный номер элемента");
                }
            } catch
            {
                Console.WriteLine("Произошла ошибка при поиске по номеру элемента. Проверьте правильность вводимых данных!");
            }
        }

        public void ArticleInfoForName(string name)
        {
            try
            {
                Article[] articleSearch = _articles.Where(a => a.GetName().
                                                    Trim().ToUpper().Contains(name.Trim().ToUpper())).ToArray();

                if (articleSearch != null && articleSearch.Length>0)
                {
                    foreach (var article in articleSearch)
                    {
                        article.ArticleInfo();
                    }
                }
                else
                {
                    Console.WriteLine("Товары с таким наименованием отсутствует");
                }
            } catch
            {
                Console.WriteLine("Произошла ошибка при поиске по наименованию товара. Проверьте правильность вводимых данных!");
            }
        }
    }
}
