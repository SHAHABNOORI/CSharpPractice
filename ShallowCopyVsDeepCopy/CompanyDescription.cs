namespace ShallowCopyVsDeepCopy
{
    public class CompanyDescription
    {

        public string CompanyName;

        public string Owner;
        public CompanyDescription(string c, string o)
        {
            this.CompanyName = c;
            this.Owner = o;
        }

        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }
    }
}