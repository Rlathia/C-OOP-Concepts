using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Post
    {
        protected string Title { get; set; }
        protected bool IsPublic { get; set; }
        protected string PostedByName { get; set; }
        protected int PostID { get; set; }

        public Post()
        {
            this.PostID = 0;
            this.Title = "This is my first post";
            this.IsPublic = true ;
            this.PostedByName = "Rajvi Lathia";
        }
        public Post (string title, bool isPublic, string postedByName)
        {
            this.PostID = GetNextPostID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.PostedByName = postedByName;
        }

        protected int GetNextPostID()
        {
            return ++PostID;
        }

        protected string GetIsPublic()
        {
            return IsPublic ? "public" : "private";
        }

        public override string ToString()
        {
            return "\nPost "+ PostID + " : " + this.Title + ". \nIt is " + GetIsPublic() + " post, posted by " + PostedByName;
        }
    }
}
