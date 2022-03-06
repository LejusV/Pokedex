using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Mothim Specie to store common natural stats of all Mothims
	#region SpecieMothim
	public class SpecieMothim : PokemonSpecie
	{
#nullable enable
		private static SpecieMothim? _instance = null;
#nullable restore
        public static SpecieMothim Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMothim();
                }
                return _instance;
            }
        }

		#region SpecieMothim Builder
		public SpecieMothim() : base(
			"Mothim",
			70, // HPs
			94, 50, // Attack & Defense
			94, 50, // Special Attack & Defense
			66		
		)
		{
			this._height = 9;
			this._weight = 233;
		}
		#endregion
	}
	#endregion

	//Mothim Pokemon Class
	#region Mothim
	public class Mothim : Pokemon
	{
		#region Mothim Builders
		/// <summary>
		/// Mothim Builder waiting for a Nickname & a Level
		/// </summary>
		public Mothim(string nickname, int level)
		: base(
				414,
				SpecieMothim.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mothim Builder only waiting for a Level
		/// </summary>
		public Mothim(int level)
		: base(
				414,
				SpecieMothim.Instance, // Pokemon Specie
				"Mothim", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mothim Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Mothim() : base(
			414,
			SpecieMothim.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}