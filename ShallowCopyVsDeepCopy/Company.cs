namespace ShallowCopyVsDeepCopy
{
    public class Company
    {

        public int GbRank;
        public CompanyDescription Desc;

        public Company(int gbRank, string c,
            string o)
        {
            this.GbRank = gbRank;
            Desc = new CompanyDescription(c, o);
        }

        // method for cloning object
        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        // method for cloning object
        public Company DeepCopy()
        {
            var deepCopyCompany = new Company(this.GbRank,
                Desc.CompanyName, Desc.Owner);
            return deepCopyCompany;
        }


        public Company DeepCopyVersionTwo()
        {
            var deepCopyCompany = (Company) this.MemberwiseClone();

            deepCopyCompany.Desc = (CompanyDescription) this.Desc.ShallowCopy();
            return deepCopyCompany;
        }
    }
}