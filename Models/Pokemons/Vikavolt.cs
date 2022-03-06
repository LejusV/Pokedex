using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Vikavolt Specie to store common natural stats of all Vikavolts
	#region SpecieVikavolt
	public class SpecieVikavolt : PokemonSpecie
	{
#nullable enable
		private static SpecieVikavolt? _instance = null;
#nullable restore
        public static SpecieVikavolt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVikavolt();
                }
                return _instance;
            }
        }

		#region SpecieVikavolt Builder
		public SpecieVikavolt() : base(
			"Vikavolt",
			77, // HPs
			70, 90, // Attack & Defense
			145, 75, // Special Attack & Defense
			43		
		)
		{
			this._height = 15;
			this._weight = 450;
		}
		#endregion
	}
	#endregion

	//Vikavolt Pokemon Class
	#region Vikavolt
	public class Vikavolt : Pokemon
	{
		#region Vikavolt Builders
		/// <summary>
		/// Vikavolt Builder waiting for a Nickname & a Level
		/// </summary>
		public Vikavolt(string nickname, int level)
		: base(
				738,
				SpecieVikavolt.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vikavolt Builder only waiting for a Level
		/// </summary>
		public Vikavolt(int level)
		: base(
				738,
				SpecieVikavolt.Instance, // Pokemon Specie
				"Vikavolt", level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vikavolt Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Vikavolt() : base(
			738,
			SpecieVikavolt.Instance, // Pokemon Specie
			Bug.Instance, Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}