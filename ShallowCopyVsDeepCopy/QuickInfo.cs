namespace ShallowCopyVsDeepCopy
{
    public class QuickInfo
    {
        public QuickInfo(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public QuickInfo ShallowCopy()
        {
            return this.MemberwiseClone() as QuickInfo;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}