using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Skitty Specie to store common natural stats of all Skittys
	#region SpecieSkitty
	public class SpecieSkitty : PokemonSpecie
	{
#nullable enable
		private static SpecieSkitty? _instance = null;
#nullable restore
        public static SpecieSkitty Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSkitty();
                }
                return _instance;
            }
        }

		#region SpecieSkitty Builder
		public SpecieSkitty() : base(
			"Skitty",
			0.6,
			11.0,
			50, // HPs
			45, 45, // Attack & Defense
			35, 35, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Skitty Pokemon Class
	#region Skitty
	public class Skitty : Pokemon
	{
		#region Skitty Builders
		/// <summary>
		/// Skitty Builder waiting for a Nickname & a Level
		/// </summary>
		public Skitty(string nickname, int level)
		: base(
				300,
				SpecieSkitty.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skitty Builder only waiting for a Level
		/// </summary>
		public Skitty(int level)
		: base(
				300,
				SpecieSkitty.Instance, // Pokemon Specie
				"Skitty", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skitty Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Skitty() : base(
			300,
			SpecieSkitty.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}