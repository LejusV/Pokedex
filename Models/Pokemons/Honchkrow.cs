using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Honchkrow Specie to store common natural stats of all Honchkrows
	#region SpecieHonchkrow
	public class SpecieHonchkrow : PokemonSpecie
	{
#nullable enable
		private static SpecieHonchkrow? _instance = null;
#nullable restore
        public static SpecieHonchkrow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHonchkrow();
                }
                return _instance;
            }
        }

		#region SpecieHonchkrow Builder
		public SpecieHonchkrow() : base(
			"Honchkrow",
			100, // HPs
			125, 52, // Attack & Defense
			105, 52, // Special Attack & Defense
			71		
		)
		{
			this._height = 9;
			this._weight = 273;
		}
		#endregion
	}
	#endregion

	//Honchkrow Pokemon Class
	#region Honchkrow
	public class Honchkrow : Pokemon
	{
		#region Honchkrow Builders
		/// <summary>
		/// Honchkrow Builder waiting for a Nickname & a Level
		/// </summary>
		public Honchkrow(string nickname, int level)
		: base(
				430,
				SpecieHonchkrow.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Honchkrow Builder only waiting for a Level
		/// </summary>
		public Honchkrow(int level)
		: base(
				430,
				SpecieHonchkrow.Instance, // Pokemon Specie
				"Honchkrow", level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Honchkrow Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Honchkrow() : base(
			430,
			SpecieHonchkrow.Instance, // Pokemon Specie
			Dark.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}