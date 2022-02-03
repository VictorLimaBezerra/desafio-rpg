namespace Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C.src.Entites
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, string Hp, string Mp, string ZodiacForce)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
            this.ZodiacForce = ZodiacForce;
        }
    }
}