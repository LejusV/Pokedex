using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Whimsicott Specie to store common natural stats of all Whimsicotts
	#region SpecieWhimsicott
	public class SpecieWhimsicott : PokemonSpecie
	{
#nullable enable
		private static SpecieWhimsicott? _instance = null;
#nullable restore
        public static SpecieWhimsicott Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWhimsicott();
                }
                return _instance;
            }
        }

		#region SpecieWhimsicott Builder
		public SpecieWhimsicott() : base(
			"Whimsicott",
			0.7,
			6.6,
			60, // HPs
			67, 85, // Attack & Defense
			77, 75, // Special Attack & Defense
			116		
		)
		{}
		#endregion
	}
	#endregion

	//Whimsicott Pokemon Class
	#region Whimsicott
	public class Whimsicott : Pokemon
	{
		#region Whimsicott Builders
		/// <summary>
		/// Whimsicott Builder waiting for a Nickname & a Level
		/// </summary>
		public Whimsicott(string nickname, int level)
		: base(
				547,
				SpecieWhimsicott.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whimsicott Builder only waiting for a Level
		/// </summary>
		public Whimsicott(int level)
		: base(
				547,
				SpecieWhimsicott.Instance, // Pokemon Specie
				"Whimsicott", level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whimsicott Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Whimsicott() : base(
			547,
			SpecieWhimsicott.Instance, // Pokemon Specie
			Grass.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}