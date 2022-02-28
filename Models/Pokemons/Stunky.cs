using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Stunky Specie to store common natural stats of all Stunkys
	#region SpecieStunky
	public class SpecieStunky : PokemonSpecie
	{
#nullable enable
		private static SpecieStunky? _instance = null;
#nullable restore
        public static SpecieStunky Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStunky();
                }
                return _instance;
            }
        }

		#region SpecieStunky Builder
		public SpecieStunky() : base(
			"Stunky",
			63, // HPs
			63, 47, // Attack & Defense
			41, 41, // Special Attack & Defense
			74			
		) {}
		#endregion
	}
	#endregion

	//Stunky Pokemon Class
	#region Stunky
	public class Stunky : Pokemon
	{
		#region Stunky Builders
		/// <summary>
		/// Stunky Builder waiting for a Nickname & a Level
		/// </summary>
		public Stunky(string nickname, int level)
		: base(
				434,
				SpecieStunky.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stunky Builder only waiting for a Level
		/// </summary>
		public Stunky(int level)
		: base(
				434,
				SpecieStunky.Instance, // Pokemon Specie
				"Stunky", level,
				Poison.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stunky Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Stunky() : base(
			434,
			SpecieStunky.Instance, // Pokemon Specie
			Poison.Instance, Dark.Instance			
		) {}
		#endregion
	}
	#endregion
}