using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Electabuzz Specie to store common natural stats of all Electabuzzs
	#region SpecieElectabuzz
	public class SpecieElectabuzz : PokemonSpecie
	{
#nullable enable
		private static SpecieElectabuzz? _instance = null;
#nullable restore
        public static SpecieElectabuzz Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieElectabuzz();
                }
                return _instance;
            }
        }

		#region SpecieElectabuzz Builder
		public SpecieElectabuzz() : base(
			"Electabuzz",
			1.1,
			30.0,
			65, // HPs
			83, 57, // Attack & Defense
			95, 85, // Special Attack & Defense
			105		
		)
		{}
		#endregion
	}
	#endregion

	//Electabuzz Pokemon Class
	#region Electabuzz
	public class Electabuzz : Pokemon
	{
		#region Electabuzz Builders
		/// <summary>
		/// Electabuzz Builder waiting for a Nickname & a Level
		/// </summary>
		public Electabuzz(string nickname, int level)
		: base(
				125,
				SpecieElectabuzz.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electabuzz Builder only waiting for a Level
		/// </summary>
		public Electabuzz(int level)
		: base(
				125,
				SpecieElectabuzz.Instance, // Pokemon Specie
				"Electabuzz", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electabuzz Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Electabuzz() : base(
			125,
			SpecieElectabuzz.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}