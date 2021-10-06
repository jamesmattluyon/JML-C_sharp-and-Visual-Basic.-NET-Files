using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Animal
    {
        private string model;
        private string sound;

        public string Model
        { get { return model; } set { model = value; } }

        public string Sound
        { get { return sound; } set { sound = value; } }

        public string ClearModel()
        {
            model = " ";
            return model;
        }

    }
}
