using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Tepig Specie to store common natural stats of all Tepigs
	#region SpecieTepig
	public class SpecieTepig : PokemonSpecie
	{
#nullable enable
		private static SpecieTepig? _instance = null;
#nullable restore
        public static SpecieTepig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTepig();
                }
                return _instance;
            }
        }

		#region SpecieTepig Builder
		public SpecieTepig() : base(
			"Tepig",
			65, // HPs
			63, 45, // Attack & Defense
			45, 45, // Special Attack & Defense
			45		
		)
		{
			this._height = 5;
			this._weight = 99;
		}
		#endregion
	}
	#endregion

	//Tepig Pokemon Class
	#region Tepig
	public class Tepig : Pokemon
	{
		#region Tepig Builders
		/// <summary>
		/// Tepig Builder waiting for a Nickname & a Level
		/// </summary>
		public Tepig(string nickname, int level)
		: base(
				498,
				SpecieTepig.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tepig Builder only waiting for a Level
		/// </summary>
		public Tepig(int level)
		: base(
				498,
				SpecieTepig.Instance, // Pokemon Specie
				"Tepig", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tepig Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Tepig() : base(
			498,
			SpecieTepig.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}