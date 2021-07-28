using System;

namespace ShallowCopyVsDeepCopy
{
    public class SsnGenerator
    {
        public (int threeDigits, int twoDigits, int fourDigits) Ssn => GenerateSSN();
        private readonly Random _random;

        // struct doesn't accept a parameterless constructor
        // this is why I'm passing a random parameter
        public SsnGenerator(Random random)
        {
            _random = random;
        }

        private (int threeDigits, int twoDigits, int fourDigits) GenerateSSN()
        {

            var threeDigits = _random.Next(100, 1000);
            var twoDigits = _random.Next(10, 100);
            var fourDigits = _random.Next(1000, 10_000);

            return (threeDigits, twoDigits, fourDigits);
        }

    }
}