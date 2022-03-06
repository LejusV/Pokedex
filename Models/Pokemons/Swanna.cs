using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Swanna Specie to store common natural stats of all Swannas
	#region SpecieSwanna
	public class SpecieSwanna : PokemonSpecie
	{
#nullable enable
		private static SpecieSwanna? _instance = null;
#nullable restore
        public static SpecieSwanna Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSwanna();
                }
                return _instance;
            }
        }

		#region SpecieSwanna Builder
		public SpecieSwanna() : base(
			"Swanna",
			75, // HPs
			87, 63, // Attack & Defense
			87, 63, // Special Attack & Defense
			98		
		)
		{
			this._height = 13;
			this._weight = 242;
		}
		#endregion
	}
	#endregion

	//Swanna Pokemon Class
	#region Swanna
	public class Swanna : Pokemon
	{
		#region Swanna Builders
		/// <summary>
		/// Swanna Builder waiting for a Nickname & a Level
		/// </summary>
		public Swanna(string nickname, int level)
		: base(
				581,
				SpecieSwanna.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swanna Builder only waiting for a Level
		/// </summary>
		public Swanna(int level)
		: base(
				581,
				SpecieSwanna.Instance, // Pokemon Specie
				"Swanna", level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swanna Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Swanna() : base(
			581,
			SpecieSwanna.Instance, // Pokemon Specie
			Water.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}