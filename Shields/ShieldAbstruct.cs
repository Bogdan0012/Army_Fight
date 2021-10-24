namespace Shields{
    public class Shield{
        public int DefendHP { get; set; }
        protected int Size { get; set; }

        protected Shield(int size){
            this.Size = size;
        }
        
        public void Defend(Soldiers.Soldier holder, int damage){
            holder.HP -= (damage - (this.DefendHP / Size));
        }

    }
}