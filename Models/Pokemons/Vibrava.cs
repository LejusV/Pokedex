using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Vibrava Specie to store common natural stats of all Vibravas
	#region SpecieVibrava
	public class SpecieVibrava : PokemonSpecie
	{
#nullable enable
		private static SpecieVibrava? _instance = null;
#nullable restore
        public static SpecieVibrava Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVibrava();
                }
                return _instance;
            }
        }

		#region SpecieVibrava Builder
		public SpecieVibrava() : base(
			"Vibrava",
			50, // HPs
			70, 50, // Attack & Defense
			50, 50, // Special Attack & Defense
			70		
		)
		{
			this._height = 11;
			this._weight = 153;
		}
		#endregion
	}
	#endregion

	//Vibrava Pokemon Class
	#region Vibrava
	public class Vibrava : Pokemon
	{
		#region Vibrava Builders
		/// <summary>
		/// Vibrava Builder waiting for a Nickname & a Level
		/// </summary>
		public Vibrava(string nickname, int level)
		: base(
				329,
				SpecieVibrava.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vibrava Builder only waiting for a Level
		/// </summary>
		public Vibrava(int level)
		: base(
				329,
				SpecieVibrava.Instance, // Pokemon Specie
				"Vibrava", level,
				Ground.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vibrava Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Vibrava() : base(
			329,
			SpecieVibrava.Instance, // Pokemon Specie
			Ground.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}