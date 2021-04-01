using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4.Class
{
    public class Article
    {
        public Article(string nameProduct, string nameStore, double costProduct)
        {
            _nameProduct = nameProduct;
            _nameStore = nameStore;
            _costProduct = costProduct;
        }
        private string _nameProduct;
        private string _nameStore;
        private double _costProduct;

        public string GetName()
        {
            return _nameProduct;
        }

        public void ArticleInfo()
        {
            Console.WriteLine($"Наименование товара: {_nameProduct}; Магазин: " +
                $"{_nameStore}; Стоимость: {Math.Round(_costProduct, 2)} руб.");
        }
    }
}
