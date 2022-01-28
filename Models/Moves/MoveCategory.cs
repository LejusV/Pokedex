using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    internal abstract class MoveCategory
    {
        private readonly int p_id;
        private readonly string p_name;
        private readonly string p_description;

        public int Id
        {
            get { return p_id; }
        }
        public string Name
        {
            get { return p_name; }
        }

        public string Decription
        {
            get { return p_description; }
        }

        public MoveCategory(int id, string name, string description)
        {
            p_description = description;
            p_id = id;
            p_name = name;
        }
    }
}
