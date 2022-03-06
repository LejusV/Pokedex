using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Mawile Specie to store common natural stats of all Mawiles
	#region SpecieMawile
	public class SpecieMawile : PokemonSpecie
	{
#nullable enable
		private static SpecieMawile? _instance = null;
#nullable restore
        public static SpecieMawile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMawile();
                }
                return _instance;
            }
        }

		#region SpecieMawile Builder
		public SpecieMawile() : base(
			"Mawile",
			0.6,
			11.5,
			50, // HPs
			85, 85, // Attack & Defense
			55, 55, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Mawile Pokemon Class
	#region Mawile
	public class Mawile : Pokemon
	{
		#region Mawile Builders
		/// <summary>
		/// Mawile Builder waiting for a Nickname & a Level
		/// </summary>
		public Mawile(string nickname, int level)
		: base(
				303,
				SpecieMawile.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mawile Builder only waiting for a Level
		/// </summary>
		public Mawile(int level)
		: base(
				303,
				SpecieMawile.Instance, // Pokemon Specie
				"Mawile", level,
				Steel.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mawile Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Mawile() : base(
			303,
			SpecieMawile.Instance, // Pokemon Specie
			Steel.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}