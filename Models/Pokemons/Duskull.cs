using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Duskull Specie to store common natural stats of all Duskulls
	#region SpecieDuskull
	public class SpecieDuskull : PokemonSpecie
	{
#nullable enable
		private static SpecieDuskull? _instance = null;
#nullable restore
        public static SpecieDuskull Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDuskull();
                }
                return _instance;
            }
        }

		#region SpecieDuskull Builder
		public SpecieDuskull() : base(
			"Duskull",
			20, // HPs
			40, 90, // Attack & Defense
			30, 90, // Special Attack & Defense
			25		
		)
		{
			this._height = 8;
			this._weight = 150;
		}
		#endregion
	}
	#endregion

	//Duskull Pokemon Class
	#region Duskull
	public class Duskull : Pokemon
	{
		#region Duskull Builders
		/// <summary>
		/// Duskull Builder waiting for a Nickname & a Level
		/// </summary>
		public Duskull(string nickname, int level)
		: base(
				355,
				SpecieDuskull.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Duskull Builder only waiting for a Level
		/// </summary>
		public Duskull(int level)
		: base(
				355,
				SpecieDuskull.Instance, // Pokemon Specie
				"Duskull", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Duskull Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Duskull() : base(
			355,
			SpecieDuskull.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}