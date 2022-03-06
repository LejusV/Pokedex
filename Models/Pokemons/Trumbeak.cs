using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Trumbeak Specie to store common natural stats of all Trumbeaks
	#region SpecieTrumbeak
	public class SpecieTrumbeak : PokemonSpecie
	{
#nullable enable
		private static SpecieTrumbeak? _instance = null;
#nullable restore
        public static SpecieTrumbeak Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTrumbeak();
                }
                return _instance;
            }
        }

		#region SpecieTrumbeak Builder
		public SpecieTrumbeak() : base(
			"Trumbeak",
			0.6,
			14.8,
			55, // HPs
			85, 50, // Attack & Defense
			40, 50, // Special Attack & Defense
			75		
		)
		{}
		#endregion
	}
	#endregion

	//Trumbeak Pokemon Class
	#region Trumbeak
	public class Trumbeak : Pokemon
	{
		#region Trumbeak Builders
		/// <summary>
		/// Trumbeak Builder waiting for a Nickname & a Level
		/// </summary>
		public Trumbeak(string nickname, int level)
		: base(
				732,
				SpecieTrumbeak.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trumbeak Builder only waiting for a Level
		/// </summary>
		public Trumbeak(int level)
		: base(
				732,
				SpecieTrumbeak.Instance, // Pokemon Specie
				"Trumbeak", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trumbeak Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Trumbeak() : base(
			732,
			SpecieTrumbeak.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}