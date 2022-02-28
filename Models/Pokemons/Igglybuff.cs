using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Igglybuff Specie to store common natural stats of all Igglybuffs
	#region SpecieIgglybuff
	public class SpecieIgglybuff : PokemonSpecie
	{
#nullable enable
		private static SpecieIgglybuff? _instance = null;
#nullable restore
        public static SpecieIgglybuff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieIgglybuff();
                }
                return _instance;
            }
        }

		#region SpecieIgglybuff Builder
		public SpecieIgglybuff() : base(
			"Igglybuff",
			90, // HPs
			30, 15, // Attack & Defense
			40, 20, // Special Attack & Defense
			15			
		) {}
		#endregion
	}
	#endregion

	//Igglybuff Pokemon Class
	#region Igglybuff
	public class Igglybuff : Pokemon
	{
		#region Igglybuff Builders
		/// <summary>
		/// Igglybuff Builder waiting for a Nickname & a Level
		/// </summary>
		public Igglybuff(string nickname, int level)
		: base(
				174,
				SpecieIgglybuff.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Igglybuff Builder only waiting for a Level
		/// </summary>
		public Igglybuff(int level)
		: base(
				174,
				SpecieIgglybuff.Instance, // Pokemon Specie
				"Igglybuff", level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Igglybuff Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Igglybuff() : base(
			174,
			SpecieIgglybuff.Instance, // Pokemon Specie
			Normal.Instance, Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}