using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Quagsire Specie to store common natural stats of all Quagsires
	#region SpecieQuagsire
	public class SpecieQuagsire : PokemonSpecie
	{
#nullable enable
		private static SpecieQuagsire? _instance = null;
#nullable restore
        public static SpecieQuagsire Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieQuagsire();
                }
                return _instance;
            }
        }

		#region SpecieQuagsire Builder
		public SpecieQuagsire() : base(
			"Quagsire",
			95, // HPs
			85, 85, // Attack & Defense
			65, 65, // Special Attack & Defense
			35		
		)
		{
			this._height = 14;
			this._weight = 750;
		}
		#endregion
	}
	#endregion

	//Quagsire Pokemon Class
	#region Quagsire
	public class Quagsire : Pokemon
	{
		#region Quagsire Builders
		/// <summary>
		/// Quagsire Builder waiting for a Nickname & a Level
		/// </summary>
		public Quagsire(string nickname, int level)
		: base(
				195,
				SpecieQuagsire.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Quagsire Builder only waiting for a Level
		/// </summary>
		public Quagsire(int level)
		: base(
				195,
				SpecieQuagsire.Instance, // Pokemon Specie
				"Quagsire", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Quagsire Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Quagsire() : base(
			195,
			SpecieQuagsire.Instance, // Pokemon Specie
			Water.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}