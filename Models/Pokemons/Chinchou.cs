using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Chinchou Specie to store common natural stats of all Chinchous
	#region SpecieChinchou
	public class SpecieChinchou : PokemonSpecie
	{
#nullable enable
		private static SpecieChinchou? _instance = null;
#nullable restore
        public static SpecieChinchou Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChinchou();
                }
                return _instance;
            }
        }

		#region SpecieChinchou Builder
		public SpecieChinchou() : base(
			"Chinchou",
			75, // HPs
			38, 38, // Attack & Defense
			56, 56, // Special Attack & Defense
			67		
		)
		{
			this._height = 5;
			this._weight = 120;
		}
		#endregion
	}
	#endregion

	//Chinchou Pokemon Class
	#region Chinchou
	public class Chinchou : Pokemon
	{
		#region Chinchou Builders
		/// <summary>
		/// Chinchou Builder waiting for a Nickname & a Level
		/// </summary>
		public Chinchou(string nickname, int level)
		: base(
				170,
				SpecieChinchou.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chinchou Builder only waiting for a Level
		/// </summary>
		public Chinchou(int level)
		: base(
				170,
				SpecieChinchou.Instance, // Pokemon Specie
				"Chinchou", level,
				Water.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chinchou Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Chinchou() : base(
			170,
			SpecieChinchou.Instance, // Pokemon Specie
			Water.Instance, Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}