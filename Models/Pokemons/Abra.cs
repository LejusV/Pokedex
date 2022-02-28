using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Abra Specie to store common natural stats of all Abras
	#region SpecieAbra
	public class SpecieAbra : PokemonSpecie
	{
#nullable enable
		private static SpecieAbra? _instance = null;
#nullable restore
        public static SpecieAbra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAbra();
                }
                return _instance;
            }
        }

		#region SpecieAbra Builder
		public SpecieAbra() : base(
			"Abra",
			25, // HPs
			20, 15, // Attack & Defense
			105, 55, // Special Attack & Defense
			90			
		) {}
		#endregion
	}
	#endregion

	//Abra Pokemon Class
	#region Abra
	public class Abra : Pokemon
	{
		#region Abra Builders
		/// <summary>
		/// Abra Builder waiting for a Nickname & a Level
		/// </summary>
		public Abra(string nickname, int level)
		: base(
				63,
				SpecieAbra.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Abra Builder only waiting for a Level
		/// </summary>
		public Abra(int level)
		: base(
				63,
				SpecieAbra.Instance, // Pokemon Specie
				"Abra", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Abra Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Abra() : base(
			63,
			SpecieAbra.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}