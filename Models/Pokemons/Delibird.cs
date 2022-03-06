using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Delibird Specie to store common natural stats of all Delibirds
	#region SpecieDelibird
	public class SpecieDelibird : PokemonSpecie
	{
#nullable enable
		private static SpecieDelibird? _instance = null;
#nullable restore
        public static SpecieDelibird Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDelibird();
                }
                return _instance;
            }
        }

		#region SpecieDelibird Builder
		public SpecieDelibird() : base(
			"Delibird",
			0.9,
			16.0,
			45, // HPs
			55, 45, // Attack & Defense
			65, 45, // Special Attack & Defense
			75		
		)
		{}
		#endregion
	}
	#endregion

	//Delibird Pokemon Class
	#region Delibird
	public class Delibird : Pokemon
	{
		#region Delibird Builders
		/// <summary>
		/// Delibird Builder waiting for a Nickname & a Level
		/// </summary>
		public Delibird(string nickname, int level)
		: base(
				225,
				SpecieDelibird.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Delibird Builder only waiting for a Level
		/// </summary>
		public Delibird(int level)
		: base(
				225,
				SpecieDelibird.Instance, // Pokemon Specie
				"Delibird", level,
				Ice.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Delibird Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Delibird() : base(
			225,
			SpecieDelibird.Instance, // Pokemon Specie
			Ice.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}