using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Garchomp Specie to store common natural stats of all Garchomps
	#region SpecieGarchomp
	public class SpecieGarchomp : PokemonSpecie
	{
#nullable enable
		private static SpecieGarchomp? _instance = null;
#nullable restore
        public static SpecieGarchomp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGarchomp();
                }
                return _instance;
            }
        }

		#region SpecieGarchomp Builder
		public SpecieGarchomp() : base(
			"Garchomp",
			108, // HPs
			130, 95, // Attack & Defense
			80, 85, // Special Attack & Defense
			102		
		)
		{
			this._height = 19;
			this._weight = 950;
		}
		#endregion
	}
	#endregion

	//Garchomp Pokemon Class
	#region Garchomp
	public class Garchomp : Pokemon
	{
		#region Garchomp Builders
		/// <summary>
		/// Garchomp Builder waiting for a Nickname & a Level
		/// </summary>
		public Garchomp(string nickname, int level)
		: base(
				445,
				SpecieGarchomp.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Garchomp Builder only waiting for a Level
		/// </summary>
		public Garchomp(int level)
		: base(
				445,
				SpecieGarchomp.Instance, // Pokemon Specie
				"Garchomp", level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Garchomp Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Garchomp() : base(
			445,
			SpecieGarchomp.Instance, // Pokemon Specie
			Dragon.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}