using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Remoraid Specie to store common natural stats of all Remoraids
	#region SpecieRemoraid
	public class SpecieRemoraid : PokemonSpecie
	{
#nullable enable
		private static SpecieRemoraid? _instance = null;
#nullable restore
        public static SpecieRemoraid Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRemoraid();
                }
                return _instance;
            }
        }

		#region SpecieRemoraid Builder
		public SpecieRemoraid() : base(
			"Remoraid",
			35, // HPs
			65, 35, // Attack & Defense
			65, 35, // Special Attack & Defense
			65		
		)
		{
			this._height = 6;
			this._weight = 120;
		}
		#endregion
	}
	#endregion

	//Remoraid Pokemon Class
	#region Remoraid
	public class Remoraid : Pokemon
	{
		#region Remoraid Builders
		/// <summary>
		/// Remoraid Builder waiting for a Nickname & a Level
		/// </summary>
		public Remoraid(string nickname, int level)
		: base(
				223,
				SpecieRemoraid.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Remoraid Builder only waiting for a Level
		/// </summary>
		public Remoraid(int level)
		: base(
				223,
				SpecieRemoraid.Instance, // Pokemon Specie
				"Remoraid", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Remoraid Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Remoraid() : base(
			223,
			SpecieRemoraid.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}