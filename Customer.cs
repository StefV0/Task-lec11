using System;

namespace CMS.BusinessLayer
{
    public class Customer
    {
        public Customer() : this(0)
        {
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            HomeAddress = new Address();
            WorkAddress = new Address();
        }

        public static int InstanceCount { get; set; }

        public int CustomerId { get; private set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public Address HomeAddress { get; set; }
        public Address WorkAddress { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
