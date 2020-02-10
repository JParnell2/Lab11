using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Number_11
{
    class Movies
    {

        private string title;
        private string category;

        public string Title { get => title; set => title = value; }
        public string Category { get => category; set => category = value; }

        public Movies(string title, string category)
        {
            this.title = title;
            this.category = category;
        }

        public override string ToString()
        {
            return $"{title}";
        }

    }
}
