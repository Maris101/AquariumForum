namespace AquariumForum.Models
{
    public class Discussion
    {
        // Primary Key for the discussion
        public int DiscussionId { get; set; }

        // Title of the discussion
        public string Title { get; set; }

        // Content of the discussion
        public string Content { get; set; }

        // Image filename related to the discussion
        public string ImageFilename { get; set; }

        // Date and time when the discussion was created
        public DateTime CreateDate { get; set; }

        // Navigation property: A collection of comments related to this discussion
        public ICollection<Comment> Comments { get; set; }
    }
}
