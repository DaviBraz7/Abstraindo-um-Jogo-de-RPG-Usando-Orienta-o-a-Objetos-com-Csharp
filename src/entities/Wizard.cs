namespace Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C_.src.entities
{
    public class Wizard : Hero
    {

        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
       
        public override string Attack(){
            return this.Name + " Lançou Magia!";
    }
        public string Attack(int bonus){

            if(bonus > 6){
            return this.Name + " Lançou Magia SUPER EFETIVA com bonus de " + bonus;
            }else{
                return this.Name + " Lançou Magia fraca com bonus de " + bonus;
            }
    }
    }
}