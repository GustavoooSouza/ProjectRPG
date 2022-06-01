namespace ProjetoRPG.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string MagicAttack()
        {
            return this.Name + "Atacou com magia de luz!";
        }

        public string MagicAttack(int Bonus)
        {
            if (Bonus > 6){
                return this.Name + "Atacou com magia de luz super efetiva! Bonus de ataque : " + Bonus;
            } else {
                return this.Name + "lançou uma magia com força fraca com bonus de : " + Bonus;
            }
        }
    }
}