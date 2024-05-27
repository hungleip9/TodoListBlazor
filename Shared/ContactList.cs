namespace TodoListBlazorWebAssembly.Shared
{
    public class ContactList
    {
        public int ContactId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public ContactList(int contactId, string firstName, string lastName)
        {
            this.ContactId = contactId;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
