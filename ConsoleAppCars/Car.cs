using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleAppCars
{
    class Car
    {
        //If no access modifiers is present for a field/method/property, thay will all defualt to Private.
        string brand;
        string model;
        int speed;
        int maxSpeed;
        char[] regPlate;

        public Car(string brand, string model,char[] regPlate, int maxSpeed)
        {
            this.brand = brand;
            this.model = model;
            this.regPlate = regPlate;
            this.maxSpeed = maxSpeed;
        }

        /// <summary>
        /// Current speed of the car.
        /// <list type="bullet">
        /// <item>
        /// <term>Set Speed</term>
        /// <description>Use a int to set the speed of the car</description>
        /// </item>
        /// <item>
        /// <term>Set Max Speed </term>
        /// <description>The speed of the car can not exced the max speed of the car</description>
        /// </item>
        /// <item>
        /// <term>Set Min Speed</term>
        /// <description>The speed of the car can not go below 30</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <value>
        /// Get returns current speed of the car.
        /// </value>
        /// <remarks>
        /// You can read up on how to use XML documentation tags in your C# code.
        /// https://docs.microsoft.com/en-us/dotnet/csharp/codedoc
        /// </remarks>
        public int Speed { get; set; }

        /// <summary>
        /// The cars maximum possible speed.
        /// <list type="bullet">
        /// <item>
        /// <term>Set Speed Limit</term>
        /// <description>Use a int to set the maximum speed of the car</description>
        /// </item>
        /// <item>
        /// <term>Set Speed Limit minimum</term>
        /// <description>Minimum limit of the car is 1</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <value>
        /// Get returns cars maximum speed possible.
        /// </value>
        public int MaxSpeedLimit { get; set; }

        /// <summary>
        /// Registration plate for the car
        /// <list type="bullet">
        /// <item>
        /// <term>Length limit</term>
        /// <description>Can only be 6 symbols long</description>
        /// </item>
        /// <item>
        /// <term>Symbol limit for posissions 1 to 3</term>
        /// <description>Must be 3 letters</description>
        /// </item>
        /// <item>
        /// <term>Symbol limit for posissions 4 to 5</term>
        /// <description>Must have 2 digits</description>
        /// </item>
        /// <item>
        /// <term>Symbol limit for posission 6</term>
        /// <description>Can be a digit or a letter</description>
        /// </item>
        /// </list>
        /// </summary>
        public string RegPlate { get; set; }


        private string RegPlateToString()
        {
            StringBuilder reg = new StringBuilder();
            
            foreach (var item in regPlate)
            {
                reg.Append(item);
            }

            return reg.ToString().ToUpper();
        }

        public override string ToString()
        {
            return $"{brand} - {model} - {RegPlateToString()}";
        }
    }
}
