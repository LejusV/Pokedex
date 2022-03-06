using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Barbaracle Specie to store common natural stats of all Barbaracles
	#region SpecieBarbaracle
	public class SpecieBarbaracle : PokemonSpecie
	{
#nullable enable
		private static SpecieBarbaracle? _instance = null;
#nullable restore
        public static SpecieBarbaracle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBarbaracle();
                }
                return _instance;
            }
        }

		#region SpecieBarbaracle Builder
		public SpecieBarbaracle() : base(
			"Barbaracle",
			1.3,
			96.0,
			72, // HPs
			105, 115, // Attack & Defense
			54, 86, // Special Attack & Defense
			68		
		)
		{}
		#endregion
	}
	#endregion

	//Barbaracle Pokemon Class
	#region Barbaracle
	public class Barbaracle : Pokemon
	{
		#region Barbaracle Builders
		/// <summary>
		/// Barbaracle Builder waiting for a Nickname & a Level
		/// </summary>
		public Barbaracle(string nickname, int level)
		: base(
				689,
				SpecieBarbaracle.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Barbaracle Builder only waiting for a Level
		/// </summary>
		public Barbaracle(int level)
		: base(
				689,
				SpecieBarbaracle.Instance, // Pokemon Specie
				"Barbaracle", level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Barbaracle Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Barbaracle() : base(
			689,
			SpecieBarbaracle.Instance, // Pokemon Specie
			Rock.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}