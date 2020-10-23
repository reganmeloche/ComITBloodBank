namespace BloodClinic
{
    public class BloodType
    {
        public BloodType(string letter, char sign) {
            Letter = letter;
            Sign = sign;
        }

        public string Letter { get; set; } //O, A, B, AB
        public char Sign { get; set; } // -/+
        
    }
}