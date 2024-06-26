﻿namespace DocumentManagement.Entities
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
        public ICollection<Document> CreatedDocuments { get; set; }
        public ICollection<Document> ModifiedDocuments { get; set; }
    }
}
