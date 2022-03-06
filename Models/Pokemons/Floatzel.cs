using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Floatzel Specie to store common natural stats of all Floatzels
	#region SpecieFloatzel
	public class SpecieFloatzel : PokemonSpecie
	{
#nullable enable
		private static SpecieFloatzel? _instance = null;
#nullable restore
        public static SpecieFloatzel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFloatzel();
                }
                return _instance;
            }
        }

		#region SpecieFloatzel Builder
		public SpecieFloatzel() : base(
			"Floatzel",
			1.1,
			33.5,
			85, // HPs
			105, 55, // Attack & Defense
			85, 50, // Special Attack & Defense
			115		
		)
		{}
		#endregion
	}
	#endregion

	//Floatzel Pokemon Class
	#region Floatzel
	public class Floatzel : Pokemon
	{
		#region Floatzel Builders
		/// <summary>
		/// Floatzel Builder waiting for a Nickname & a Level
		/// </summary>
		public Floatzel(string nickname, int level)
		: base(
				419,
				SpecieFloatzel.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Floatzel Builder only waiting for a Level
		/// </summary>
		public Floatzel(int level)
		: base(
				419,
				SpecieFloatzel.Instance, // Pokemon Specie
				"Floatzel", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Floatzel Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Floatzel() : base(
			419,
			SpecieFloatzel.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}