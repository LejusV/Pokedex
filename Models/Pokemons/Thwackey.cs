using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Thwackey Specie to store common natural stats of all Thwackeys
	#region SpecieThwackey
	public class SpecieThwackey : PokemonSpecie
	{
#nullable enable
		private static SpecieThwackey? _instance = null;
#nullable restore
        public static SpecieThwackey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieThwackey();
                }
                return _instance;
            }
        }

		#region SpecieThwackey Builder
		public SpecieThwackey() : base(
			"Thwackey",
			70, // HPs
			85, 70, // Attack & Defense
			55, 60, // Special Attack & Defense
			80		
		)
		{
			this._height = 7;
			this._weight = 140;
		}
		#endregion
	}
	#endregion

	//Thwackey Pokemon Class
	#region Thwackey
	public class Thwackey : Pokemon
	{
		#region Thwackey Builders
		/// <summary>
		/// Thwackey Builder waiting for a Nickname & a Level
		/// </summary>
		public Thwackey(string nickname, int level)
		: base(
				811,
				SpecieThwackey.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Thwackey Builder only waiting for a Level
		/// </summary>
		public Thwackey(int level)
		: base(
				811,
				SpecieThwackey.Instance, // Pokemon Specie
				"Thwackey", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Thwackey Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Thwackey() : base(
			811,
			SpecieThwackey.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}