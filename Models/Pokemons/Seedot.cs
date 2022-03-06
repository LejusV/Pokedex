using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Seedot Specie to store common natural stats of all Seedots
	#region SpecieSeedot
	public class SpecieSeedot : PokemonSpecie
	{
#nullable enable
		private static SpecieSeedot? _instance = null;
#nullable restore
        public static SpecieSeedot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSeedot();
                }
                return _instance;
            }
        }

		#region SpecieSeedot Builder
		public SpecieSeedot() : base(
			"Seedot",
			40, // HPs
			40, 50, // Attack & Defense
			30, 30, // Special Attack & Defense
			30		
		)
		{
			this._height = 5;
			this._weight = 40;
		}
		#endregion
	}
	#endregion

	//Seedot Pokemon Class
	#region Seedot
	public class Seedot : Pokemon
	{
		#region Seedot Builders
		/// <summary>
		/// Seedot Builder waiting for a Nickname & a Level
		/// </summary>
		public Seedot(string nickname, int level)
		: base(
				273,
				SpecieSeedot.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seedot Builder only waiting for a Level
		/// </summary>
		public Seedot(int level)
		: base(
				273,
				SpecieSeedot.Instance, // Pokemon Specie
				"Seedot", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seedot Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Seedot() : base(
			273,
			SpecieSeedot.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}