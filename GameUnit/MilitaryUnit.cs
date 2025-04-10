using System;

namespace GameUnit
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower { get; }

        public int XP { get; private set; }

        // override da health
        public override int Health
        {
            get => base.Health + XP;
        }

        // override do cost
        public override float Cost => AttackPower + XP;

        // class ctor
        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }

        // Attack method 
        public void Attack(Unit u)
        {
            XP++; // increment self xp
            u.Health -= AttackPower; // apply damage to the unit
        }
    }
}

