using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost(){ }
        public ImagePost(string title, bool isPublic, string postedByName, string imageURL)
        {
            this.PostID = GetNextPostID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.PostedByName = postedByName;
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return "\nImage Post " + PostID + " : " + this.Title + ".\nImage URL is " +ImageURL+ ".\nIt is " + GetIsPublic() + " post, posted by " + PostedByName;
        }
    }
}
