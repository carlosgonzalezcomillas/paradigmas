using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    // Base abstract class Vehicle -> Cab or Police
    public abstract class Vehicle : IMessageWriter
    {
        public string Type { get; protected set; }
        public string Plate { get; protected set; }
        public int Speed { get; protected set; }

        public Vehicle(string type, string plate, int speed)
        {
            Type = type;
            Plate = plate;
            Speed = speed;
        }

        public abstract void StartWork();
        public abstract void FinishWork();

        public virtual string WriteMessage(string customMessage)
        {
            return $"{Type} with plate {Plate}: {customMessage}";
        }

        public override string ToString()
        {
            return WriteMessage("Created");
        }
    }
}
