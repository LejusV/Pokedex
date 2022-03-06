using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Greedent Specie to store common natural stats of all Greedents
	#region SpecieGreedent
	public class SpecieGreedent : PokemonSpecie
	{
#nullable enable
		private static SpecieGreedent? _instance = null;
#nullable restore
        public static SpecieGreedent Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGreedent();
                }
                return _instance;
            }
        }

		#region SpecieGreedent Builder
		public SpecieGreedent() : base(
			"Greedent",
			0.6,
			6.0,
			120, // HPs
			95, 95, // Attack & Defense
			55, 75, // Special Attack & Defense
			20		
		)
		{}
		#endregion
	}
	#endregion

	//Greedent Pokemon Class
	#region Greedent
	public class Greedent : Pokemon
	{
		#region Greedent Builders
		/// <summary>
		/// Greedent Builder waiting for a Nickname & a Level
		/// </summary>
		public Greedent(string nickname, int level)
		: base(
				820,
				SpecieGreedent.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Greedent Builder only waiting for a Level
		/// </summary>
		public Greedent(int level)
		: base(
				820,
				SpecieGreedent.Instance, // Pokemon Specie
				"Greedent", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Greedent Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Greedent() : base(
			820,
			SpecieGreedent.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}