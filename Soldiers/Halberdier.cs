namespace Soldiers{
    using Weapon;
    public class Halberdier : Soldier{
        protected System.Random r;
        public Halberdier(string name) : base (name, 100, new Halberd()){}

        public override void Attack(Soldier enemy){
            this.Weapon.Hit(this, enemy);
            this.Weapon.Hit(this, enemy);
        }
        public override void Defend(Soldier enemy){
            System.Console.Write($"Halberder dodged some damage: ");
            var a = r.Next(0, enemy.Weapon.Damage);
            System.Console.WriteLine($"{a}");
            
            this.HP -= (enemy.Weapon.Damage - a);
        }
        public override string ToString() => $"{this.Name} has {this.HP} hp and send {this.Weapon.Damage} dm!";
    }
}