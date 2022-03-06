using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Mienfoo Specie to store common natural stats of all Mienfoos
	#region SpecieMienfoo
	public class SpecieMienfoo : PokemonSpecie
	{
#nullable enable
		private static SpecieMienfoo? _instance = null;
#nullable restore
        public static SpecieMienfoo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMienfoo();
                }
                return _instance;
            }
        }

		#region SpecieMienfoo Builder
		public SpecieMienfoo() : base(
			"Mienfoo",
			45, // HPs
			85, 50, // Attack & Defense
			55, 50, // Special Attack & Defense
			65		
		)
		{
			this._height = 9;
			this._weight = 200;
		}
		#endregion
	}
	#endregion

	//Mienfoo Pokemon Class
	#region Mienfoo
	public class Mienfoo : Pokemon
	{
		#region Mienfoo Builders
		/// <summary>
		/// Mienfoo Builder waiting for a Nickname & a Level
		/// </summary>
		public Mienfoo(string nickname, int level)
		: base(
				619,
				SpecieMienfoo.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mienfoo Builder only waiting for a Level
		/// </summary>
		public Mienfoo(int level)
		: base(
				619,
				SpecieMienfoo.Instance, // Pokemon Specie
				"Mienfoo", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mienfoo Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Mienfoo() : base(
			619,
			SpecieMienfoo.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}