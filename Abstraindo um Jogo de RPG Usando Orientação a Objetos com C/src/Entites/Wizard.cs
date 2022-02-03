namespace Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C.src.Entites
{
    public class Wizard : Hero
    {       
        public Wizard(string Name, int Level, string HeroType, string Hp, string Mp, string ZodiacForce)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
            this.ZodiacForce = ZodiacForce;
        }
        public override string Attack(){
            return this.Name + " Lançou magia";
        }

        public string Attack(int Bonus){
           
            if(Bonus > 6){
                 return this.Name + " Lançou super magia com bonus de ataque de " + Bonus;
            }else{
                 return this.Name + " Lançou magia de baixo impacto com bonus de " + Bonus;
            }
           
        }
    }
}