

namespace PhoneBook
{
     internal class ContactNode
    {
        private ContactNode? _nextContactNode;
        

        private String? _firstName;
        private String? lastName;
        private String? _email;
        private String? _phoneNumber;
        private String? _address;
        private String? _city;
        private String? _zipCode;
        private String? _state;


        public string? FirstName { get => _firstName; set => _firstName = value; }
        public string? LastName { get => lastName; set => lastName = value; }
        public string? Email { get => _email; set => _email = value; }
        public string? PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string? Address { get => _address; set => _address = value; }
        public string? City { get => _city; set => _city = value; }
        public string? ZipCode { get => _zipCode; set => _zipCode = value; }
        public string? State { get => _state; set => _state = value; }
        internal ContactNode? NextContactNode { get => _nextContactNode; set => _nextContactNode = value; }

        public override string? ToString()
        {
            return base.ToString();
        }


    }

    internal class NodeManager
    {
        private ContactNode? _firstContactNode = null;
        private int length = 0;

        internal ContactNode? FirstContactNode { get => _firstContactNode; set => _firstContactNode = value; }


        public void AddNode(ContactNode newNode)
        {
            if(_firstContactNode == null)
            {
                _firstContactNode = newNode;
            }
            else
            {
                ContactNode? current = _firstContactNode;
                do
                {
                    current = current.NextContactNode;

                } while (current.NextContactNode != null);

                current.NextContactNode = newNode;
               
            }
        }
        public ContactNode? GetNode(int index)
        {
            ContactNode? current = _firstContactNode;
            return current;
        }
    }
}
