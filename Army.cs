namespace CProject{
    using System;
    using System.Collections.Generic;
    using Soldiers;
    class Army {
        private List<Squad> squads;
        public Army(List<Squad> squads) {
            this.squads = squads;
        }
        
        public void Atack(Army other) {            
            for(int i = 0; i < squads.Count; i++) {
                Squad otherSquad = GetOtherSquadByIndex(other.squads, i);
                Console.WriteLine($"Squad {squads[i].Name} attack squad {otherSquad.Name}");
                squads[i].Attack(otherSquad);
                if (!otherSquad.IsAlive()) {
                    other.squads.Remove(otherSquad);
                }
            }
        }

        private Squad GetOtherSquadByIndex(List<Squad> squads, int index)
        {
            if (squads.Count > index) 
                return squads[index];
            return squads[index % squads.Count];
        }

        public bool IsAlive() {
            return squads.Count > 0;
        }
    }
}