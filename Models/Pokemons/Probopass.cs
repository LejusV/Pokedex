using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Probopass Specie to store common natural stats of all Probopasss
	#region SpecieProbopass
	public class SpecieProbopass : PokemonSpecie
	{
#nullable enable
		private static SpecieProbopass? _instance = null;
#nullable restore
        public static SpecieProbopass Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieProbopass();
                }
                return _instance;
            }
        }

		#region SpecieProbopass Builder
		public SpecieProbopass() : base(
			"Probopass",
			60, // HPs
			55, 145, // Attack & Defense
			75, 150, // Special Attack & Defense
			40		
		)
		{
			this._height = 14;
			this._weight = 3400;
		}
		#endregion
	}
	#endregion

	//Probopass Pokemon Class
	#region Probopass
	public class Probopass : Pokemon
	{
		#region Probopass Builders
		/// <summary>
		/// Probopass Builder waiting for a Nickname & a Level
		/// </summary>
		public Probopass(string nickname, int level)
		: base(
				476,
				SpecieProbopass.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Probopass Builder only waiting for a Level
		/// </summary>
		public Probopass(int level)
		: base(
				476,
				SpecieProbopass.Instance, // Pokemon Specie
				"Probopass", level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Probopass Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Probopass() : base(
			476,
			SpecieProbopass.Instance, // Pokemon Specie
			Rock.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}