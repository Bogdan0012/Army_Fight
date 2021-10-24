namespace Weapon{
    using Soldiers;
   public interface IWeapon{
        public int Hit(Soldier owner, Soldier enemy);
    }
}