using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Basculin-Red-Striped Specie to store common natural stats of all Basculin-Red-Stripeds
	#region SpecieBasculin-Red-Striped
	public class SpecieBasculinRedStriped : PokemonSpecie
	{
#nullable enable
		private static SpecieBasculinRedStriped? _instance = null;
#nullable restore
        public static SpecieBasculinRedStriped Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBasculinRedStriped();
                }
                return _instance;
            }
        }

		#region SpecieBasculin-Red-Striped Builder
		public SpecieBasculinRedStriped() : base(
			"Basculin-Red-Striped",
			1.0,
			18.0,
			70, // HPs
			92, 65, // Attack & Defense
			80, 55, // Special Attack & Defense
			98		
		)
		{}
		#endregion
	}
	#endregion

	//Basculin-Red-Striped Pokemon Class
	#region Basculin-Red-Striped
	public class BasculinRedStriped : Pokemon
	{
		#region Basculin-Red-Striped Builders
		/// <summary>
		/// Basculin-Red-Striped Builder waiting for a Nickname & a Level
		/// </summary>
		public BasculinRedStriped(string nickname, int level)
		: base(
				550,
				SpecieBasculinRedStriped.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Basculin-Red-Striped Builder only waiting for a Level
		/// </summary>
		public BasculinRedStriped(int level)
		: base(
				550,
				SpecieBasculinRedStriped.Instance, // Pokemon Specie
				"Basculin-Red-Striped", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Basculin-Red-Striped Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public BasculinRedStriped() : base(
			550,
			SpecieBasculinRedStriped.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}