

namespace PhoneBook
{
    internal class PhonebookManager
    {
        private ListNode? _firstContactNode = null;
        private int length = 0;

        public ListNode? FirstContactNode { get => _firstContactNode; set => _firstContactNode = value; }


        //this method create and returns a contact
        public ListNode CreateContactNode(string? firstName, string? lastName, string? email, string? phoneNumber,
                string? address, string? city, string? zipCode, string? state)
        {
            return new ListNode(firstName, lastName, email, phoneNumber, address, city, zipCode, state);
        }

        //This method adds a node to the end of the list
        //or if _firstContactNode is null, sets the newNode and the first node
        public void AddNode(ListNode newNode)
        {
            if(_firstContactNode == null)
            {
                _firstContactNode = newNode;
            }
            else
            {
                ListNode? current = _firstContactNode;
               

                while (current.NextContactNode != null){
                    current = current.NextContactNode;
                }

                current!.NextContactNode = newNode;
                length++;
            }
        }
        //this method add the new contact to the list 
        //while maintaining alphabetical order
        public void AddSorted(ListNode? newNode)
            
        {
            
            if (_firstContactNode == null)
            {
                _firstContactNode = newNode;
                
                length++;
                return;
            }
           
            ListNode? testNode = _firstContactNode;
            ListNode? pastNode = null;
            
            int comparison = 0;

            //while the newNode 
            while (testNode != null)
            {

                comparison = newNode!.LastName!.CompareTo(testNode.LastName);

                //if the current
                if (comparison <= 0)
                {
                    if (pastNode == null)
                    {
                        //inserts ahead of first node if its last name
                        //property is the same
                        newNode.NextContactNode = testNode;
                        _firstContactNode = newNode;
                        
                        break;
                    }

                    //insert new node between testNode and past node
                    //once the testNode comes after the new node
                    pastNode!.NextContactNode = newNode;
                    newNode.NextContactNode = testNode;
                    
                    break;
                }

                //move to next node
                pastNode = testNode;
                testNode = testNode.NextContactNode;
               
                

                //add to end of list no testNodes come after newNode
                if (testNode == null)
                {
                    pastNode.NextContactNode = newNode;
                }
            }
            length++;
        }

        //this method displays all nodes
        public void DisplayAll() {
            ListNode? current = _firstContactNode;
            

            while (current != null){
                
                Console.WriteLine(current!.FirstName);
                current = current.NextContactNode;
            }
         }

        
        //This method iterates through the linked list and check each nodes CompareString
        //to see if the first and last names match
        public ListNode? GetNode(String name)
        {
            ListNode? currentNode = _firstContactNode;


            //loop though nodes check the name of each contact
            while (currentNode!.NextContactNode != null)
            {

                //check against first and last name
                if ((currentNode.CompareString!).Equals(name))
                {
                    return currentNode;
                }
                currentNode = currentNode.NextContactNode;
            }

            return null;          
        }

        //this method interates through the links in the list
        //stopping at the given index and returns the Contact
        //at that index
        public ListNode? GetNthNode(int index)
        {
            ListNode? current = _firstContactNode;
            if (index >= length || index < 0)
            {
                throw new NullReferenceException();
            }


            int currentIndex = 0;
            //loop though nodes if requested node isn't at index 0
            //if index is 0, current node still contains the firstNode,
            //so it will be returned
            if (index != 0)
            {
                do
                {
                    current = current!.NextContactNode;
                    currentIndex++;
                } while (index != currentIndex);
            }

            return current;
        }

        public int RemoveNode(String name)
        {
            ListNode? currentNode = _firstContactNode;
            ListNode? previousNode = null;


            //loop though nodes check the name of each contact
            while (currentNode != null)
            {

                //check against first and last name
                if ((currentNode!.CompareString.Equals(name)))
                {

                    //if removing the first node
                    if (previousNode == null)
                    {
                        _firstContactNode = currentNode.NextContactNode;

                    }
                    else
                    {
                        //link over the matching node
                        previousNode.NextContactNode = currentNode.NextContactNode;
                    }
                    //indicates successful removal
                    length--;
                    return 1;
                }
                //keep current node in memory
                previousNode = currentNode;
                currentNode = currentNode!.NextContactNode;

            }
            return -1;
        }
        public void RemoveNthNode(int index)
        {
            if (index >= length || index < 0)
            {
                throw new NullReferenceException();
            }

            ListNode? current = _firstContactNode;
            ListNode? past = null;

            int currentIndex = 0;

            //loop though nodes if requested node isn't at index 0
            //if index is 0, current node still contains the firstNode,
            //so it will be returned
            if (index != 0)
            {
                do
                {
                    past = current;
                    current = current!.NextContactNode;
                    currentIndex++;
                } while (index != currentIndex);

                past!.NextContactNode = current!.NextContactNode;
            }
        }

        internal class ListNode
        {
            private ListNode? _nextContactNode = null;


            private String? _firstName;
            private String? _lastName;
            private String? _email;
            private String? _phoneNumber;
            private String? _address;
            private String? _city;
            private String? _zipCode;
            private String? _state;

            public ListNode(string? firstName, string? lastName, string? email, string? phoneNumber,
                string? address, string? city, string? zipCode, string? state)
            {
                FirstName = firstName;
                LastName = lastName;
                Email = email;
                PhoneNumber = phoneNumber;
                Address = address;
                City = city;
                ZipCode = zipCode;
                State = state;
                FirstName = firstName;
                LastName = lastName;
                Email = email;
                PhoneNumber = phoneNumber;
                Address = address;
                City = city;
                ZipCode = zipCode;
                State = state;
            }

            public string? FirstName { get => _firstName; set => _firstName = value; }
            public string? LastName { get => _lastName; set => _lastName = value; }
            public string? Email { get => _email; set => _email = value; }
            public string? PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
            public string? Address { get => _address; set => _address = value; }
            public string? City { get => _city; set => _city = value; }
            public string? ZipCode { get => _zipCode; set => _zipCode = value; }
            public string? State { get => _state; set => _state = value; }
            public string? CompareString { get => _firstName!.ToLower() + _lastName!.ToLower(); }
            public ListNode? NextContactNode { get => _nextContactNode; set => _nextContactNode = value; }

            public override string? ToString()
            {
                return "ListNode{" +
                    "firstName='" + _firstName + '\'' +
                    ", lastName='" + _lastName + '\'' +
                    ", address='" + _address + '\'' +
                    ", city='" + _city + '\'' +
                    ", state='" + _state + '\'' +
                    ", zipCode='" + _zipCode + '\'' +
                    ", email='" + _email + '\'' +
                    ", phoneNumber='" + _phoneNumber + '\'' +
                    '}';
            }


        }
    }
    
    internal class PhonebookUI
    {

    }
}
