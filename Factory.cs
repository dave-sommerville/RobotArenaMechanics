using System.Threading.Tasks;

namespace RobotArenaMechanics
{
    public class Factory
    {
        Random rand = new Random();
        private List<string> RobotHeadTemplates = new List<string>
        {
            "Sleek visor", "Dome-shaped", "Cyclopean eye", "Square monitor face", "Insectoid lenses",
            "Glowing red eyes", "Retractable antennae", "Skull-like plating", "Glass dome with brain",
            "Steampunk gears", "Minimalist LED panel", "Classic humanoid", "Holographic projection",
            "Camera cluster", "Reinforced helmet"
        };

        private List<string> RobotArmTemplates = new List<string>
        {
            "Hydraulic pincers", "Triple-jointed claws", "Extendable grapplers", "Humanoid fingers",
            "Welding torch hands", "Tentacle-like appendages", "Massive crushing claws", "Retractable saws",
            "Flexible segmented arms", "Gatling gun arms", "Magnetic manipulators", "Servo-driven hands",
            "Nano-fiber whips", "Electromagnetic pulse emitters", "Adaptive tool attachments"
        };

        private List<string> RobotBodyTemplates = new List<string>
        {
            "Sleek titanium frame", "Bulky industrial plating", "Glass and steel exoskeleton",
            "Armored tank-like frame", "Lightweight carbon-fiber shell", "Plasma-cooled torso",
            "Insect-like exoskeleton", "Compact spherical core", "Humanoid synthetic skin",
            "Hardened chrome alloy", "Skeleton-like framework", "Multi-layer reinforced plating",
            "Aerodynamic design", "Cables and exposed wiring", "Mechanical vertebrae"
        };

        private List<string> RobotWeaponTemplates = new List<string>
        {
            "Laser cannon", "Rocket launcher", "Plasma blade", "Tesla coil discharge", "Flamethrower",
            "Mini-gun turret", "Electrified whip", "Sonic disruptor", "Missile pods", "Energy-based saws",
            "Grappling hook", "Poison gas emitter", "Railgun", "Gravity manipulator", "Shockwave generator"
        };

        private List<string> RobotLocomotionTemplates = new List<string>
        {
            "Quad-wheeled chassis", "Bipedal legs", "Tracked treads", "Hover jets", "Monowheel system",
            "Spider-like appendages", "Gyroscopic balance spheres", "Rocket boosters", "Magnetic levitation",
            "Tank treads", "Omni-directional wheels", "Snake-like undulation", "Retractable rollerblades",
            "Spring-loaded legs", "Jetpack propulsion"
        };

        public string Name { get; set; }
        public List<string> HeadPile { get; set; } = new List<string>();
        public List<string> BodyPile { get; set; } = new List<string>();
        public List<string> ArmsPile { get; set; } = new List<string>();
        public List<string> WeaponPile { get; set; } = new List<string>();
        public List<string> LocomotionPile { get; set; } = new List<string>();

        public Factory(string name)
        {
            Name = name;
        }

        public async Task ManufacturePart(string partType, int productionRate)
        {
            while (true)
            {
                await Task.Delay(productionRate);

                switch (partType)
                {
                    case "Head":
                        HeadPile.Add(RobotHeadTemplates[rand.Next(RobotHeadTemplates.Count)]);
                        break;
                    case "Body":
                        BodyPile.Add(RobotBodyTemplates[rand.Next(RobotBodyTemplates.Count)]);
                        break;
                    case "Arms":
                        ArmsPile.Add(RobotArmTemplates[rand.Next(RobotArmTemplates.Count)]);
                        break;
                    case "Weapon":
                        WeaponPile.Add(RobotWeaponTemplates[rand.Next(RobotWeaponTemplates.Count)]);
                        break;
                    case "Locomotion":
                        LocomotionPile.Add(RobotLocomotionTemplates[rand.Next(RobotLocomotionTemplates.Count)]);
                        break;
                }
            }
        }

        public string ShipPart(List<string> partsPile)
        {
            if (partsPile.Count == 0)
            {
                return "No parts available to ship.";
            }

            string shippingPart = partsPile[rand.Next(partsPile.Count)];
            partsPile.Remove(shippingPart);
            return shippingPart;
        }
    }
}
