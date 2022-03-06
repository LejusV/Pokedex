using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Gliscor Specie to store common natural stats of all Gliscors
	#region SpecieGliscor
	public class SpecieGliscor : PokemonSpecie
	{
#nullable enable
		private static SpecieGliscor? _instance = null;
#nullable restore
        public static SpecieGliscor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGliscor();
                }
                return _instance;
            }
        }

		#region SpecieGliscor Builder
		public SpecieGliscor() : base(
			"Gliscor",
			2.0,
			42.5,
			75, // HPs
			95, 125, // Attack & Defense
			45, 75, // Special Attack & Defense
			95		
		)
		{}
		#endregion
	}
	#endregion

	//Gliscor Pokemon Class
	#region Gliscor
	public class Gliscor : Pokemon
	{
		#region Gliscor Builders
		/// <summary>
		/// Gliscor Builder waiting for a Nickname & a Level
		/// </summary>
		public Gliscor(string nickname, int level)
		: base(
				472,
				SpecieGliscor.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gliscor Builder only waiting for a Level
		/// </summary>
		public Gliscor(int level)
		: base(
				472,
				SpecieGliscor.Instance, // Pokemon Specie
				"Gliscor", level,
				Ground.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gliscor Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Gliscor() : base(
			472,
			SpecieGliscor.Instance, // Pokemon Specie
			Ground.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}