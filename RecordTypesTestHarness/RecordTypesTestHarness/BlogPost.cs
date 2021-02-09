using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordTypesTestHarness
{
    //internal struct BlogPost
    internal sealed class BlogPost : IEquatable<BlogPost>
    {
        public string Title { get; }
        public string Author { get; }
        public string Post { get; }
        public DateTime Date { get; }
        public BlogPost(string title, string author, string post, DateTime date)
        {
            Title = title;
            Author = author;
            Post = post;
            Date = date;
        }

        public static bool operator !=(BlogPost blogPost1, BlogPost blogPost2)
        {
            return !(blogPost1 == blogPost2);
        }

        public static bool operator ==(BlogPost blogPost1, BlogPost blogPost2)
        {
            return (object)blogPost1 == blogPost2 || ((object)blogPost1 != null && blogPost1.Equals(blogPost2));
        }

        public override int GetHashCode()
        {
            return (((EqualityComparer<string>.Default.GetHashCode(Title)) * -1521134295
                + EqualityComparer<string>.Default.GetHashCode(Author)) * -1521134295
                + EqualityComparer<string>.Default.GetHashCode(Post) * -1521134295
                + EqualityComparer<DateTime>.Default.GetHashCode(Date));
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as BlogPost);
        }

        public bool Equals(BlogPost other)
        {
            return EqualityComparer<string>.Default.Equals(Title, other.Title)
                && EqualityComparer<string>.Default.Equals(Author, other.Author)
                && EqualityComparer<string>.Default.Equals(Post, other.Post)
                && EqualityComparer<DateTime>.Default.Equals(Date, other.Date);
        }

        public void Deconstruct(out string title, out string author, out string post, out DateTime date)
        {
            title = Title;
            author = Author;
            post = Post;
            date = Date;
        }
    }
}
