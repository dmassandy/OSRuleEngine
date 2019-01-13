using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Company
    {

        public String Name { get; private set; }
        public String RegistryNo { get; private set; }
        public DateTime RegistrationDate { get; private set; }
        public int CompanyType { get; private set; }
        public int CompanyLegalStatus { get; private set; }
        public int BusinessActivity { get; private set; }
        public String Background { get; private set; }
        public String Website { get; private set; }
        public String Address { get; private set; }
        public int AgreedDiscount { get; private set; }
        public Contact POC { get; private set; }
        public Contact LegalContact { get; private set; }
        public Contact AdminContact { get; private set; }
        public Contact MarketingContact { get; private set; }

        public Company(string name, string registryNo, DateTime registrationDate, int companyType, 
            int companyLegalStatus, int businessActivity, string background, string website, 
            string address, int agreedDiscount, Contact pOC, Contact legalContact, 
            Contact adminContact, Contact marketingContact)
        {
            Name = name;
            RegistryNo = registryNo;
            RegistrationDate = registrationDate;
            CompanyType = companyType;
            CompanyLegalStatus = companyLegalStatus;
            BusinessActivity = businessActivity;
            Background = background;
            Website = website;
            Address = address;
            AgreedDiscount = agreedDiscount;
            POC = pOC;
            LegalContact = legalContact;
            AdminContact = adminContact;
            MarketingContact = marketingContact;
        }


    }
}
