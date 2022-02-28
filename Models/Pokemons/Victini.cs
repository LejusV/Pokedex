using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Victini Specie to store common natural stats of all Victinis
	#region SpecieVictini
	public class SpecieVictini : PokemonSpecie
	{
#nullable enable
		private static SpecieVictini? _instance = null;
#nullable restore
        public static SpecieVictini Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVictini();
                }
                return _instance;
            }
        }

		#region SpecieVictini Builder
		public SpecieVictini() : base(
			"Victini",
			100, // HPs
			100, 100, // Attack & Defense
			100, 100, // Special Attack & Defense
			100			
		) {}
		#endregion
	}
	#endregion

	//Victini Pokemon Class
	#region Victini
	public class Victini : Pokemon
	{
		#region Victini Builders
		/// <summary>
		/// Victini Builder waiting for a Nickname & a Level
		/// </summary>
		public Victini(string nickname, int level)
		: base(
				494,
				SpecieVictini.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Victini Builder only waiting for a Level
		/// </summary>
		public Victini(int level)
		: base(
				494,
				SpecieVictini.Instance, // Pokemon Specie
				"Victini", level,
				Psychic.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Victini Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Victini() : base(
			494,
			SpecieVictini.Instance, // Pokemon Specie
			Psychic.Instance, Fire.Instance			
		) {}
		#endregion
	}
	#endregion
}