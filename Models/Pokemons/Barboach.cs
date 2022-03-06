using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Barboach Specie to store common natural stats of all Barboachs
	#region SpecieBarboach
	public class SpecieBarboach : PokemonSpecie
	{
#nullable enable
		private static SpecieBarboach? _instance = null;
#nullable restore
        public static SpecieBarboach Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBarboach();
                }
                return _instance;
            }
        }

		#region SpecieBarboach Builder
		public SpecieBarboach() : base(
			"Barboach",
			50, // HPs
			48, 43, // Attack & Defense
			46, 41, // Special Attack & Defense
			60		
		)
		{
			this._height = 4;
			this._weight = 19;
		}
		#endregion
	}
	#endregion

	//Barboach Pokemon Class
	#region Barboach
	public class Barboach : Pokemon
	{
		#region Barboach Builders
		/// <summary>
		/// Barboach Builder waiting for a Nickname & a Level
		/// </summary>
		public Barboach(string nickname, int level)
		: base(
				339,
				SpecieBarboach.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Barboach Builder only waiting for a Level
		/// </summary>
		public Barboach(int level)
		: base(
				339,
				SpecieBarboach.Instance, // Pokemon Specie
				"Barboach", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Barboach Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Barboach() : base(
			339,
			SpecieBarboach.Instance, // Pokemon Specie
			Water.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}