using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Victreebel Specie to store common natural stats of all Victreebels
	#region SpecieVictreebel
	public class SpecieVictreebel : PokemonSpecie
	{
#nullable enable
		private static SpecieVictreebel? _instance = null;
#nullable restore
        public static SpecieVictreebel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVictreebel();
                }
                return _instance;
            }
        }

		#region SpecieVictreebel Builder
		public SpecieVictreebel() : base(
			"Victreebel",
			80, // HPs
			105, 65, // Attack & Defense
			100, 70, // Special Attack & Defense
			70		
		)
		{
			this._height = 17;
			this._weight = 155;
		}
		#endregion
	}
	#endregion

	//Victreebel Pokemon Class
	#region Victreebel
	public class Victreebel : Pokemon
	{
		#region Victreebel Builders
		/// <summary>
		/// Victreebel Builder waiting for a Nickname & a Level
		/// </summary>
		public Victreebel(string nickname, int level)
		: base(
				71,
				SpecieVictreebel.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Victreebel Builder only waiting for a Level
		/// </summary>
		public Victreebel(int level)
		: base(
				71,
				SpecieVictreebel.Instance, // Pokemon Specie
				"Victreebel", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Victreebel Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Victreebel() : base(
			71,
			SpecieVictreebel.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}