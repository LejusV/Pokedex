using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Gulpin Specie to store common natural stats of all Gulpins
	#region SpecieGulpin
	public class SpecieGulpin : PokemonSpecie
	{
#nullable enable
		private static SpecieGulpin? _instance = null;
#nullable restore
        public static SpecieGulpin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGulpin();
                }
                return _instance;
            }
        }

		#region SpecieGulpin Builder
		public SpecieGulpin() : base(
			"Gulpin",
			70, // HPs
			43, 53, // Attack & Defense
			43, 53, // Special Attack & Defense
			40		
		)
		{
			this._height = 4;
			this._weight = 103;
		}
		#endregion
	}
	#endregion

	//Gulpin Pokemon Class
	#region Gulpin
	public class Gulpin : Pokemon
	{
		#region Gulpin Builders
		/// <summary>
		/// Gulpin Builder waiting for a Nickname & a Level
		/// </summary>
		public Gulpin(string nickname, int level)
		: base(
				316,
				SpecieGulpin.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gulpin Builder only waiting for a Level
		/// </summary>
		public Gulpin(int level)
		: base(
				316,
				SpecieGulpin.Instance, // Pokemon Specie
				"Gulpin", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gulpin Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Gulpin() : base(
			316,
			SpecieGulpin.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}