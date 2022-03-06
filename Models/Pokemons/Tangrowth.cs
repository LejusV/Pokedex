using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Tangrowth Specie to store common natural stats of all Tangrowths
	#region SpecieTangrowth
	public class SpecieTangrowth : PokemonSpecie
	{
#nullable enable
		private static SpecieTangrowth? _instance = null;
#nullable restore
        public static SpecieTangrowth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTangrowth();
                }
                return _instance;
            }
        }

		#region SpecieTangrowth Builder
		public SpecieTangrowth() : base(
			"Tangrowth",
			2.0,
			128.6,
			100, // HPs
			100, 125, // Attack & Defense
			110, 50, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Tangrowth Pokemon Class
	#region Tangrowth
	public class Tangrowth : Pokemon
	{
		#region Tangrowth Builders
		/// <summary>
		/// Tangrowth Builder waiting for a Nickname & a Level
		/// </summary>
		public Tangrowth(string nickname, int level)
		: base(
				465,
				SpecieTangrowth.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tangrowth Builder only waiting for a Level
		/// </summary>
		public Tangrowth(int level)
		: base(
				465,
				SpecieTangrowth.Instance, // Pokemon Specie
				"Tangrowth", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tangrowth Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Tangrowth() : base(
			465,
			SpecieTangrowth.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}