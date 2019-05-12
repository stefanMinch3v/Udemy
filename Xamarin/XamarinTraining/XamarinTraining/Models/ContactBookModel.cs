namespace XamarinTraining.Models
{
    public class ContactBookModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{this.FirstName} {this.LastName}";

        public string Phone { get; set; }

        public string Email { get; set; }

        public bool IsBlocked { get; set; }
    }
}
