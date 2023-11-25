using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Ex6.Entities;

namespace Ex6.Entities
{
    public class Post
    {
        public DateTime Moment {get; set;}
        public string Title {get; set;}
        public string Content {get; set;}
        public int Likes {get; set;}
        public List<Comment> Comment {get; set;} = new List<Comment>();

        public Post(DateTime dateTime, string title, string content, int likes){

            Moment = dateTime;
            Title = title;
            Content = content;
            Likes = likes;

        }

        public void AddComment(Comment comment){
            Comment.Add(comment);
        }

        public void RemoveComment(Comment comment){
            Comment.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment c in Comment)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }

    }
}