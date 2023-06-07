using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameToolbox.Elements
{
    /// <summary>
    /// This is a Die class that represents a die with a certain number of sides.
    /// </summary>
    public class Die
    {       
        private int sides;
        private List<float> chances;
        private protected int seed;
        private Random random;
        private bool izi;
        private bool advantage;
        private bool disadvantage;

        /// <summary>
        /// a uint that gets or sets the number of sides on the die. When it is set, it calls the Setup() method to initialize the chances list.
        /// </summary>
        public uint Sides { get => (uint)sides; set { sides = (int)value; Setup(); } }
        /// <summary>
        /// a bool that gets or sets a value indicating whether the die is zero-indexed or not.
        /// </summary>
        public bool IsZeroIndexed { get => izi; set => izi = value; }
        /// <summary>
        /// a readonly float that represents the chance of rolling any particular side of the die, calculated as 1.0f / sides * 100.
        /// </summary>
        public float ChancePerSide { get => 1.0f / sides * 100; }
        /// <summary>
        /// If advantage is true, all rolls by this object will have advantage until it' set to false again.
        /// </summary>
        public bool Advantage
        { 
            get => advantage; 
            set 
            {
                if (disadvantage && value)
                {
                    disadvantage = false;
                }
                advantage = value;
            }
        }
        /// <summary>
        /// If disadvantage is true, all rolls by this object will have disadvantage until it' set to false again
        /// </summary>
        public bool Disadvantage
        {
            get => disadvantage;
            set
            {
                if (advantage && value)
                {
                    advantage = false;
                }
                disadvantage = value;
            }
        }

        /// <summary>
        /// a constructor that initializes a new instance of the Die class with the specified number of sides and optional seed and zero-indexed flag.
        /// </summary>
        /// <param name="sides"></param>
        /// <param name="seed"></param>
        /// <param name="isZeroIndexed"></param>
        public Die(uint sides, int seed = 0, bool isZeroIndexed = false) 
        {
            this.seed = seed;
            IsZeroIndexed = isZeroIndexed;
            Sides = sides;
        }

        /// <summary>
        /// The Setup() method initializes the random field with the specified seed, and sets up the chances list. It calculates the chance per side as 1.0f / sides and then fills the chances list with a series of floats that increase by the chance per side each time, starting from 0.
        /// </summary>
        private void Setup()
        {
            random = new Random(seed);
            float cps = 1.0f / sides; //cps = chance per side
            chances = new List<float>(sides);
            float c = 0;
            for (int i = 0; i < sides; i++)
            {
                chances.Add(c);
                c += cps;
            }
        }

        public bool Roll(out int roll, bool advantage = false, bool disadvantage = false)
        {
            bool success01 = Roll(out int roll1);
            bool result = success01;

            if (advantage || disadvantage)
            {
                bool success02 = Roll(out int roll2);
                if (advantage)
                    roll = Math.Max(roll1, roll2);
                else
                    roll = Math.Min(roll1, roll2);

                result = success01 && success02;
            }
            else roll = roll1;

            return result;
        }

        /// <summary>
        /// Rolls the die once.
        /// </summary>
        /// <param name="roll">Outputs the rolled value.</param>
        /// <returns>Returns a boolean indentifying if the roll was valid.</returns>
        public bool Roll(out int roll)
        {
            float value = (float)random.NextDouble();
            roll = -1;
            for (int i = 0; i < sides; i++)
            {
                if (i == sides - 1 && value >= chances[i]) roll = IsZeroIndexed ? i : i + 1;
                else if (value >= chances[i] && value < chances[i + 1])
                {
                    roll = IsZeroIndexed ? i : i + 1;
                }
            }
            return roll != -1;
        }

        public int Roll(bool advantage = false, bool disadvantage = false)
        {
            int roll;
            int roll1 = Roll();

            if (advantage || disadvantage)
            {
                int roll2 = Roll();
                if (advantage)
                    roll = Math.Max(roll1, roll2);
                else
                    roll = Math.Min(roll1, roll2);

            }
            else roll = roll1;

            return roll;
        }
        /// <summary>
        /// rolls the die once and returns the result as an int.
        /// </summary>
        /// <returns></returns>
        public int Roll()
        {
            float value = (float)random.NextDouble();
            int roll = -1;
            for (int i = 0; i < sides; i++)
            {
                if (i == sides - 1) roll = IsZeroIndexed ? i : i + 1;
                else if (value >= chances[i] && value < chances[i + 1])
                {
                    roll = IsZeroIndexed ? i : i + 1;
                }
            }
            return roll;
        }

        #region Operators
        public static int operator+(Die d1, Die d2)
        {
            if (d1.Roll(out int r1, d1.advantage, d1.disadvantage))
            {
                if (d2.Roll(out int r2, d2.advantage, d2.disadvantage))
                {
                    return r1 + r2;
                }
                else throw new Exception("The second roll was invalid.");
            }
            else throw new Exception("The first roll was invalid.");
        }

        public static int operator*(Die d1, Die d2)
        {
            if (d1.Roll(out int r1, d1.advantage, d1.disadvantage))
            {
                if (d2.Roll(out int r2, d2.advantage, d2.disadvantage))
                {
                    return r1 * r2;
                }
                else throw new Exception("The second roll was invalid.");
            }
            else throw new Exception("The first roll was invalid.");
        }

        public static int operator/(Die d1, Die d2)
        {
            if (d1.Roll(out int r1, d1.advantage, d1.disadvantage))
            {
                if (d2.Roll(out int r2, d2.advantage, d2.disadvantage))
                {
                    return r1 / r2;
                }
                else throw new Exception("The second roll was invalid.");
            }
            else throw new Exception("The first roll was invalid.");
        }

        public static int operator-(Die d1, Die d2)
        {
            if (d1.Roll(out int r1, d1.advantage, d1.disadvantage))
            {
                if (d2.Roll(out int r2, d2.advantage, d2.disadvantage))
                {
                    return r1 - r2;
                }
                else throw new Exception("The second roll was invalid.");
            }
            else throw new Exception("The first roll was invalid.");
        }

        public static int operator%(Die d1, Die d2)
        {
            if (d1.Roll(out int r1, d1.advantage, d1.disadvantage))
            {
                if (d2.Roll(out int r2, d2.advantage, d2.disadvantage))
                {
                    return r1 % r2;
                }
                else throw new Exception("The second roll was invalid.");
            }
            else throw new Exception("The first roll was invalid.");
        }

        public static implicit operator int(Die d1)
        {
            if (d1.Roll(out int r1, d1.advantage, d1.disadvantage))
            {
                return r1;
            }
            else throw new Exception("The roll was invalid");
        }
        #endregion
    }
}
