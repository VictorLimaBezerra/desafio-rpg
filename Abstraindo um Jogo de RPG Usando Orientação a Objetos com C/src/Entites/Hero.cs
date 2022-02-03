namespace Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C.src.Entites
{
    public abstract class Hero
    {      
        public Hero(string Name, int Level, string HeroType, string Hp, string Mp, string ZodiacForce)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
            this.ZodiacForce = ZodiacForce;
        }
            public Hero(){

            }
        public string Name;
        public int Level;
        public string HeroType;
        public string Hp;
        public  string Mp;
        public string ZodiacForce;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack(){
            return this.Name + " Atacou com sua espada.";
        }

    }
}