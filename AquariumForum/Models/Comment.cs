namespace AquariumForum.Models
{
    public class Comment
    {
        //Comment
        //int CommentId
        //string Content
        //datatime CreateDate
        //int DiscussionId(foreign key)


        // Primary Key for the comment
        public int CommentId { get; set; }

        // Content of the comment
        public string Content { get; set; }

        // Date and time when the comment was created
        public DateTime CreateDate { get; set; }

        // Foreign Key: The ID of the discussion this comment belongs to
        public int DiscussionId { get; set; }

        // Navigation property: The discussion related to this comment
        public Discussion Discussion { get; set; }





    }
}
