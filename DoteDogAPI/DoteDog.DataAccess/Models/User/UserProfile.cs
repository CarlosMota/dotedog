namespace DoteDog.DataAccess.Models.User
{
    public class UserProfile
    {
        public long UserID { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public bool IsActive { get; set; }

        // Construtor padrão
        public UserProfile() { }

        // Construtor com parâmetros
        public UserProfile(string name, string email, DateTime dob, string phoneNumber, string address, string city, string state, string zipcode, bool isActive = true)
        {
            Name = name;
            EmailAddress = email;
            DateOfBirth = dob;
            PhoneNumber = phoneNumber;
            Address = address;
            City = city;
            State = state;
            Zipcode = zipcode;
            IsActive = isActive;
        }

        public override string ToString()
        {
            return $"UserProfile(UserID: {UserID}, Name: {Name}, EmailAddress: {EmailAddress}, DateOfBirth: {DateOfBirth}, " +
                   $"PhoneNumber: {PhoneNumber}, Address: {Address}, City: {City}, State: {State}, Zipcode: {Zipcode}, IsActive: {IsActive})";
        }
    }
}