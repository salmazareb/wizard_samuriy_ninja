using System;
namespace Heroes
{
    class Wizard : human
    {
        public Wizard(string name) : base(name, 3, 25, 3, 50) {}
        public void Heal(human target)
        {
            int healAmt = 10 * Intelligence;    
            target.Health += healAmt;
        }
        public override int Attack(human target)
        {
            int dealt = base.Attack(target, Intelligence * 5);
            health -= dealt;
            return dealt;
        }

    }
}