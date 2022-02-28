using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Espurr Specie to store common natural stats of all Espurrs
	#region SpecieEspurr
	public class SpecieEspurr : PokemonSpecie
	{
#nullable enable
		private static SpecieEspurr? _instance = null;
#nullable restore
        public static SpecieEspurr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEspurr();
                }
                return _instance;
            }
        }

		#region SpecieEspurr Builder
		public SpecieEspurr() : base(
			"Espurr",
			62, // HPs
			48, 54, // Attack & Defense
			63, 60, // Special Attack & Defense
			68			
		) {}
		#endregion
	}
	#endregion

	//Espurr Pokemon Class
	#region Espurr
	public class Espurr : Pokemon
	{
		#region Espurr Builders
		/// <summary>
		/// Espurr Builder waiting for a Nickname & a Level
		/// </summary>
		public Espurr(string nickname, int level)
		: base(
				677,
				SpecieEspurr.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Espurr Builder only waiting for a Level
		/// </summary>
		public Espurr(int level)
		: base(
				677,
				SpecieEspurr.Instance, // Pokemon Specie
				"Espurr", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Espurr Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Espurr() : base(
			677,
			SpecieEspurr.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}