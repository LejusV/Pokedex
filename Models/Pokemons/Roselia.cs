using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Roselia Specie to store common natural stats of all Roselias
	#region SpecieRoselia
	public class SpecieRoselia : PokemonSpecie
	{
#nullable enable
		private static SpecieRoselia? _instance = null;
#nullable restore
        public static SpecieRoselia Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRoselia();
                }
                return _instance;
            }
        }

		#region SpecieRoselia Builder
		public SpecieRoselia() : base(
			"Roselia",
			50, // HPs
			60, 45, // Attack & Defense
			100, 80, // Special Attack & Defense
			65			
		) {}
		#endregion
	}
	#endregion

	//Roselia Pokemon Class
	#region Roselia
	public class Roselia : Pokemon
	{
		#region Roselia Builders
		/// <summary>
		/// Roselia Builder waiting for a Nickname & a Level
		/// </summary>
		public Roselia(string nickname, int level)
		: base(
				315,
				SpecieRoselia.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Roselia Builder only waiting for a Level
		/// </summary>
		public Roselia(int level)
		: base(
				315,
				SpecieRoselia.Instance, // Pokemon Specie
				"Roselia", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Roselia Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Roselia() : base(
			315,
			SpecieRoselia.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}