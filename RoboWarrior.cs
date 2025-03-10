using System.Reflection;

namespace RobotArenaMechanics
{
    public class RoboWarrior
    {
        private readonly int _nextId = 1;
        public int Id { get; set; }
        public string Head { get; set; } = null;
        public string Body { get; set; } = null;
        public string Arms { get; set; } = null;
        public string Weapon { get; set; } = null;
        public string Locomotion { get; set; } = null;
        public RoboWarrior()
        {
            Id = _nextId++;
        }
        public bool IsHeadNull()
        {
            return Head == null;
        }
        public bool IsBodyNull()
        {
            return Body == null;
        }
        public bool IsArmsNull()
        {
            return Arms == null;
        }
        public bool IsWeaponNull()
        {
            return Weapon == null;
        }
        public bool IsLocomotionNull()
        {
            return Locomotion == null;
        }
        public bool CanRepair()
        {
            int damageCounter = 0;
            if (IsHeadNull()) { damageCounter++; }
            if (IsBodyNull()) { damageCounter++; }
            if (IsArmsNull()) { damageCounter++; }
            if (IsWeaponNull()) { damageCounter++; }
            if (IsLocomotionNull()) { damageCounter++; }
            if (damageCounter >= 3)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
