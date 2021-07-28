using System;

namespace ShallowCopyVsDeepCopy
{
    public class DetailedInfo
    {
        public DetailedInfo(Guid id, string iban, string address, DateTime birthDate, (int treeDigits, int twoDigits, int fourDigits) ssn)
        {
            Id = id;
            IBAN = iban;
            Address = address;
            BirthDate = birthDate;
            SSN = ssn;
        }

        public DetailedInfo ShallowCopy()
        {
            return this.MemberwiseClone() as DetailedInfo;
        }

        public Guid Id { get; set; }

        public string IBAN { get; set; }

        public string Address { get; set; }

        public DateTime BirthDate { get; set; }

        public (int treeDigits, int twoDigits, int fourDigits) SSN { get; set; } // 123-42-6476 format    
    }
}