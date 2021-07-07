using demo.Models;
namespace demo.Dtos.Character
{
    public class UpdateCharacterDto
    {
        
        public int Id { get; set; }
       
        public string Name { get; set; } = "Hasnian";

        public int HintPoint { get; set; } = 100;

        public int Strength { get; set; } = 10;

        public int Defence { get; set; } = 10;

        public int Inteligence { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.Ali;
    }
}