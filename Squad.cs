namespace CProject{
    using Soldiers;
    using System;
    using System.Collections.Generic;
    class Squad{
        private List<Soldier> soldiers;
        public string Name {get; set;}
        public Squad(List<Soldier> soldiers, string name){
            this.soldiers = soldiers;
            this.Name = name;
        }

         public void Attack(Squad other) {            
            for(int i = 0; i < soldiers.Count; i++) {
                Soldier otherSoldier = GetOtherSoldierByIndex(other.soldiers, i);
                soldiers[i].Attack(otherSoldier);
                if (!otherSoldier.IsAlive()) {
                    other.soldiers.Remove(otherSoldier);
                }
            }
        }

        public bool IsAlive(){
            return soldiers.Count > 0;
        }

        Soldier GetOtherSoldierByIndex(List<Soldier> soldiers, int index)
        {
            if (soldiers.Count > index)
                return soldiers[index];
            return soldiers[index % soldiers.Count];
        }
    }
}