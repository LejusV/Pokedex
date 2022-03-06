using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Gible Specie to store common natural stats of all Gibles
	#region SpecieGible
	public class SpecieGible : PokemonSpecie
	{
#nullable enable
		private static SpecieGible? _instance = null;
#nullable restore
        public static SpecieGible Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGible();
                }
                return _instance;
            }
        }

		#region SpecieGible Builder
		public SpecieGible() : base(
			"Gible",
			0.7,
			20.5,
			58, // HPs
			70, 45, // Attack & Defense
			40, 45, // Special Attack & Defense
			42		
		)
		{}
		#endregion
	}
	#endregion

	//Gible Pokemon Class
	#region Gible
	public class Gible : Pokemon
	{
		#region Gible Builders
		/// <summary>
		/// Gible Builder waiting for a Nickname & a Level
		/// </summary>
		public Gible(string nickname, int level)
		: base(
				443,
				SpecieGible.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gible Builder only waiting for a Level
		/// </summary>
		public Gible(int level)
		: base(
				443,
				SpecieGible.Instance, // Pokemon Specie
				"Gible", level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gible Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Gible() : base(
			443,
			SpecieGible.Instance, // Pokemon Specie
			Dragon.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}