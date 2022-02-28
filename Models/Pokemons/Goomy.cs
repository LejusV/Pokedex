using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Goomy Specie to store common natural stats of all Goomys
	#region SpecieGoomy
	public class SpecieGoomy : PokemonSpecie
	{
#nullable enable
		private static SpecieGoomy? _instance = null;
#nullable restore
        public static SpecieGoomy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGoomy();
                }
                return _instance;
            }
        }

		#region SpecieGoomy Builder
		public SpecieGoomy() : base(
			"Goomy",
			45, // HPs
			50, 35, // Attack & Defense
			55, 75, // Special Attack & Defense
			40			
		) {}
		#endregion
	}
	#endregion

	//Goomy Pokemon Class
	#region Goomy
	public class Goomy : Pokemon
	{
		#region Goomy Builders
		/// <summary>
		/// Goomy Builder waiting for a Nickname & a Level
		/// </summary>
		public Goomy(string nickname, int level)
		: base(
				704,
				SpecieGoomy.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Goomy Builder only waiting for a Level
		/// </summary>
		public Goomy(int level)
		: base(
				704,
				SpecieGoomy.Instance, // Pokemon Specie
				"Goomy", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Goomy Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Goomy() : base(
			704,
			SpecieGoomy.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
		#endregion
	}
	#endregion
}