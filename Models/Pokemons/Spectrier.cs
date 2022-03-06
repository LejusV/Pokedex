using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Spectrier Specie to store common natural stats of all Spectriers
	#region SpecieSpectrier
	public class SpecieSpectrier : PokemonSpecie
	{
#nullable enable
		private static SpecieSpectrier? _instance = null;
#nullable restore
        public static SpecieSpectrier Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSpectrier();
                }
                return _instance;
            }
        }

		#region SpecieSpectrier Builder
		public SpecieSpectrier() : base(
			"Spectrier",
			2.0,
			44.5,
			100, // HPs
			65, 60, // Attack & Defense
			145, 80, // Special Attack & Defense
			130		
		)
		{}
		#endregion
	}
	#endregion

	//Spectrier Pokemon Class
	#region Spectrier
	public class Spectrier : Pokemon
	{
		#region Spectrier Builders
		/// <summary>
		/// Spectrier Builder waiting for a Nickname & a Level
		/// </summary>
		public Spectrier(string nickname, int level)
		: base(
				897,
				SpecieSpectrier.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spectrier Builder only waiting for a Level
		/// </summary>
		public Spectrier(int level)
		: base(
				897,
				SpecieSpectrier.Instance, // Pokemon Specie
				"Spectrier", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spectrier Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Spectrier() : base(
			897,
			SpecieSpectrier.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}