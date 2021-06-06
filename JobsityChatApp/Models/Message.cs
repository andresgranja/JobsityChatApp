using System;


namespace JobsityChatApp.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public virtual User User { get; set; }
    }
}
