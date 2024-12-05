namespace WAD.CODEBASE._00012876.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int GroupId { get; set; } // Foreign Key
        public Group Group { get; set; } // Navigation Property
    }
}
