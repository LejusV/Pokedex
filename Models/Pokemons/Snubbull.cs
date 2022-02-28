using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Snubbull Specie to store common natural stats of all Snubbulls
	#region SpecieSnubbull
	public class SpecieSnubbull : PokemonSpecie
	{
#nullable enable
		private static SpecieSnubbull? _instance = null;
#nullable restore
        public static SpecieSnubbull Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSnubbull();
                }
                return _instance;
            }
        }

		#region SpecieSnubbull Builder
		public SpecieSnubbull() : base(
			"Snubbull",
			60, // HPs
			80, 50, // Attack & Defense
			40, 40, // Special Attack & Defense
			30			
		) {}
		#endregion
	}
	#endregion

	//Snubbull Pokemon Class
	#region Snubbull
	public class Snubbull : Pokemon
	{
		#region Snubbull Builders
		/// <summary>
		/// Snubbull Builder waiting for a Nickname & a Level
		/// </summary>
		public Snubbull(string nickname, int level)
		: base(
				209,
				SpecieSnubbull.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snubbull Builder only waiting for a Level
		/// </summary>
		public Snubbull(int level)
		: base(
				209,
				SpecieSnubbull.Instance, // Pokemon Specie
				"Snubbull", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snubbull Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Snubbull() : base(
			209,
			SpecieSnubbull.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}