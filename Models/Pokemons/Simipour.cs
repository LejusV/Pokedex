using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Simipour Specie to store common natural stats of all Simipours
	#region SpecieSimipour
	public class SpecieSimipour : PokemonSpecie
	{
#nullable enable
		private static SpecieSimipour? _instance = null;
#nullable restore
        public static SpecieSimipour Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSimipour();
                }
                return _instance;
            }
        }

		#region SpecieSimipour Builder
		public SpecieSimipour() : base(
			"Simipour",
			1.0,
			29.0,
			75, // HPs
			98, 63, // Attack & Defense
			98, 63, // Special Attack & Defense
			101		
		)
		{}
		#endregion
	}
	#endregion

	//Simipour Pokemon Class
	#region Simipour
	public class Simipour : Pokemon
	{
		#region Simipour Builders
		/// <summary>
		/// Simipour Builder waiting for a Nickname & a Level
		/// </summary>
		public Simipour(string nickname, int level)
		: base(
				516,
				SpecieSimipour.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Simipour Builder only waiting for a Level
		/// </summary>
		public Simipour(int level)
		: base(
				516,
				SpecieSimipour.Instance, // Pokemon Specie
				"Simipour", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Simipour Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Simipour() : base(
			516,
			SpecieSimipour.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}