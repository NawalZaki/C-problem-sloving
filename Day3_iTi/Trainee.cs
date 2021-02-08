using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_iTi
{
    class Trainee : Person
    {
        public int NID { get; set; }
        public int IntakeNumber { get; set; }
        public Trainee(int NID, int IntakeNumber, int Age, string Name) : base(20, "Ali")
        {
            this.NID = NID;
            this.IntakeNumber = IntakeNumber;
        }
        public override string ToString()
        {
            return $"NID is {NID}    IntakeNumber is {IntakeNumber}";
        }
    }
}
