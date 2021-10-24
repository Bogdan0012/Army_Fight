namespace Armor{
    public class LightArmor{
        public int DefendHP { get; set; }
        protected int Weight { get; set; } = 2;

        // protected PlateArmor(){
        //     this.Weight = 2;
        // }
        
        public void Defend(Soldiers.Soldier holder, int damage){
            holder.HP -= (damage - (this.DefendHP / Weight));
        }

    }
}