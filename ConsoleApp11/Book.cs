using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Book
    {
        private Author author;
        private Title title;
        private Content content;

        internal Author Author { get => author; set => author = value; }
        internal Title Title { get => title; set => title = value; }
        internal Content Content { get => content; set => content = value; }

        public Book(Author author, Title title, Content content)
        {
            this.Author = author;
            this.Title = title;
            this.Content = content;
        }
        public void Show()
        {
            Author.Show();
            Title.Show();
            Content.Show();
        }
    }
}
