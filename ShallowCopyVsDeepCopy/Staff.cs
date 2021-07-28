namespace ShallowCopyVsDeepCopy
{
    public class Staff
    {
        public Staff(QuickInfo quickInformation, DetailedInfo detailedInformation, string dummyData)
        {
            QuickInformation = quickInformation;
            DetailedInformation = detailedInformation;
            DummyData = dummyData;
        }
        public QuickInfo QuickInformation { get; set; }

        public DetailedInfo DetailedInformation { get; set; }

        public string DummyData { get; set; }


        public Staff ShallowCopy()
        {
            return MemberwiseClone() as Staff;
        }

        public Staff DeepCopy()
        {
            var deepCopy = this.MemberwiseClone() as Staff;
            deepCopy.DetailedInformation = this.DetailedInformation.ShallowCopy();
            deepCopy.QuickInformation = this.QuickInformation.ShallowCopy();
            return deepCopy;
        }

    }
}