using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Weavile Specie to store common natural stats of all Weaviles
	#region SpecieWeavile
	public class SpecieWeavile : PokemonSpecie
	{
#nullable enable
		private static SpecieWeavile? _instance = null;
#nullable restore
        public static SpecieWeavile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWeavile();
                }
                return _instance;
            }
        }

		#region SpecieWeavile Builder
		public SpecieWeavile() : base(
			"Weavile",
			70, // HPs
			120, 65, // Attack & Defense
			45, 85, // Special Attack & Defense
			125		
		)
		{
			this._height = 11;
			this._weight = 340;
		}
		#endregion
	}
	#endregion

	//Weavile Pokemon Class
	#region Weavile
	public class Weavile : Pokemon
	{
		#region Weavile Builders
		/// <summary>
		/// Weavile Builder waiting for a Nickname & a Level
		/// </summary>
		public Weavile(string nickname, int level)
		: base(
				461,
				SpecieWeavile.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weavile Builder only waiting for a Level
		/// </summary>
		public Weavile(int level)
		: base(
				461,
				SpecieWeavile.Instance, // Pokemon Specie
				"Weavile", level,
				Dark.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weavile Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Weavile() : base(
			461,
			SpecieWeavile.Instance, // Pokemon Specie
			Dark.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}