using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Necrozma Specie to store common natural stats of all Necrozmas
	#region SpecieNecrozma
	public class SpecieNecrozma : PokemonSpecie
	{
#nullable enable
		private static SpecieNecrozma? _instance = null;
#nullable restore
        public static SpecieNecrozma Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNecrozma();
                }
                return _instance;
            }
        }

		#region SpecieNecrozma Builder
		public SpecieNecrozma() : base(
			"Necrozma",
			97, // HPs
			107, 101, // Attack & Defense
			127, 89, // Special Attack & Defense
			79			
		) {}
		#endregion
	}
	#endregion

	//Necrozma Pokemon Class
	#region Necrozma
	public class Necrozma : Pokemon
	{
		#region Necrozma Builders
		/// <summary>
		/// Necrozma Builder waiting for a Nickname & a Level
		/// </summary>
		public Necrozma(string nickname, int level)
		: base(
				800,
				SpecieNecrozma.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Necrozma Builder only waiting for a Level
		/// </summary>
		public Necrozma(int level)
		: base(
				800,
				SpecieNecrozma.Instance, // Pokemon Specie
				"Necrozma", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Necrozma Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Necrozma() : base(
			800,
			SpecieNecrozma.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}