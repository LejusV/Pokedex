using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Latias Specie to store common natural stats of all Latiass
	#region SpecieLatias
	public class SpecieLatias : PokemonSpecie
	{
#nullable enable
		private static SpecieLatias? _instance = null;
#nullable restore
        public static SpecieLatias Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLatias();
                }
                return _instance;
            }
        }

		#region SpecieLatias Builder
		public SpecieLatias() : base(
			"Latias",
			1.4,
			40.0,
			80, // HPs
			80, 90, // Attack & Defense
			110, 130, // Special Attack & Defense
			110		
		)
		{}
		#endregion
	}
	#endregion

	//Latias Pokemon Class
	#region Latias
	public class Latias : Pokemon
	{
		#region Latias Builders
		/// <summary>
		/// Latias Builder waiting for a Nickname & a Level
		/// </summary>
		public Latias(string nickname, int level)
		: base(
				380,
				SpecieLatias.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Latias Builder only waiting for a Level
		/// </summary>
		public Latias(int level)
		: base(
				380,
				SpecieLatias.Instance, // Pokemon Specie
				"Latias", level,
				Dragon.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Latias Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Latias() : base(
			380,
			SpecieLatias.Instance, // Pokemon Specie
			Dragon.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}