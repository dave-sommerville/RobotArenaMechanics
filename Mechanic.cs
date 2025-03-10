
namespace RobotArenaMechanics
{
    public class Mechanic
    {
        public string Name { get; set; }
        public List<String> StockpileHeads { get; set; } = new List<string>();
        public List<String> StockpileBodies { get; set; } = new List<string>();
        public List<String> StockpileArms { get; set; } = new List<string>();
        public List<String> StockpileWeapons { get; set; } = new List<string>();
        public List<String> StockpileLocomotions { get; set; } = new List<string>();
        // Working hours? 
        public Mechanic(string name)
        {
            Name = name;
        }
        public void StockHead(string head)
        {
            StockpileHeads.Add(head);
        }
        public void StockBody(string body)
        {
            StockpileBodies.Add(body);
        }
        public void StockArms(string arms)
        {
            StockpileArms.Add(arms);
        }
        public void StockWeapon(string weapon)
        {
            StockpileWeapons.Add(weapon);
        }
        public void StockLocomotion(string locomotion)
        {
            StockpileLocomotions.Add(locomotion);
        }
        public void AttachHead(RoboWarrior robo)
        {
            if (robo.IsHeadNull())
            {
                robo.Head = StockpileHeads[0]; 
                StockpileHeads.RemoveAt(0);
            }
        }
        public void AttachBody(RoboWarrior robo)
        {
            if (robo.IsBodyNull())
            {
                robo.Body = StockpileBodies[0]; 
                StockpileBodies.RemoveAt(0);
            }
        }
        public void AttachArms(RoboWarrior robo)
        {
            if (robo.IsArmsNull())
            {
                robo.Arms = StockpileArms[0]; 
                StockpileArms.RemoveAt(0);
            }
        }
        public void AttachWeapon(RoboWarrior robo)
        {
            if (robo.IsWeaponNull())
            {
                robo.Weapon = StockpileWeapons[0]; 
                StockpileWeapons.RemoveAt(0);
            }
        }
        public void AttachLocomotion(RoboWarrior robo)
        {
            if (robo.IsLocomotionNull())
            {
                robo.Locomotion = StockpileLocomotions[0]; 
                StockpileLocomotions.RemoveAt(0);
            }
        }
        public void FullReset(RoboWarrior robo)
        {
            AttachHead(robo);
            AttachBody(robo);
            AttachArms(robo);
            AttachWeapon(robo);
            AttachLocomotion(robo);
            Console.WriteLine("Robot has been fully reset and is ready for battle!");
        }
        public void RepairRecycleSwitch(RoboWarrior robo)
        {
            if (robo.CanRepair())
            {
                FullReset(robo);
            }
            else {
                if (!robo.IsHeadNull()) { StockpileHeads.Add(robo.Head); }
                if (!robo.IsBodyNull()) { StockpileBodies.Add(robo.Body); }
                if (!robo.IsArmsNull()) { StockpileArms.Add(robo.Arms); }
                if (!robo.IsWeaponNull()) { StockpileWeapons.Add(robo.Weapon); }
                if (!robo.IsLocomotionNull()) { StockpileLocomotions.Add(robo.Locomotion); }
                Console.WriteLine("Robot is too damaged to be repaired. It will be recycled and a new model will be deployed for reset.");
                robo = CreateNewRobot();
            }
        }
        public RoboWarrior CreateNewRobot()
        {
            RoboWarrior newRobo = new RoboWarrior();
            FullReset(newRobo);
            return newRobo;
        }
    }
}
