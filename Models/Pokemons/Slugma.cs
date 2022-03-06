using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Slugma Specie to store common natural stats of all Slugmas
	#region SpecieSlugma
	public class SpecieSlugma : PokemonSpecie
	{
#nullable enable
		private static SpecieSlugma? _instance = null;
#nullable restore
        public static SpecieSlugma Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSlugma();
                }
                return _instance;
            }
        }

		#region SpecieSlugma Builder
		public SpecieSlugma() : base(
			"Slugma",
			40, // HPs
			40, 40, // Attack & Defense
			70, 40, // Special Attack & Defense
			20		
		)
		{
			this._height = 7;
			this._weight = 350;
		}
		#endregion
	}
	#endregion

	//Slugma Pokemon Class
	#region Slugma
	public class Slugma : Pokemon
	{
		#region Slugma Builders
		/// <summary>
		/// Slugma Builder waiting for a Nickname & a Level
		/// </summary>
		public Slugma(string nickname, int level)
		: base(
				218,
				SpecieSlugma.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slugma Builder only waiting for a Level
		/// </summary>
		public Slugma(int level)
		: base(
				218,
				SpecieSlugma.Instance, // Pokemon Specie
				"Slugma", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slugma Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Slugma() : base(
			218,
			SpecieSlugma.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}