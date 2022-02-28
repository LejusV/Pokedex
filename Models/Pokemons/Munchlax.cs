using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Munchlax Specie to store common natural stats of all Munchlaxs
	#region SpecieMunchlax
	public class SpecieMunchlax : PokemonSpecie
	{
#nullable enable
		private static SpecieMunchlax? _instance = null;
#nullable restore
        public static SpecieMunchlax Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMunchlax();
                }
                return _instance;
            }
        }

		#region SpecieMunchlax Builder
		public SpecieMunchlax() : base(
			"Munchlax",
			135, // HPs
			85, 40, // Attack & Defense
			40, 85, // Special Attack & Defense
			5			
		) {}
		#endregion
	}
	#endregion

	//Munchlax Pokemon Class
	#region Munchlax
	public class Munchlax : Pokemon
	{
		#region Munchlax Builders
		/// <summary>
		/// Munchlax Builder waiting for a Nickname & a Level
		/// </summary>
		public Munchlax(string nickname, int level)
		: base(
				446,
				SpecieMunchlax.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Munchlax Builder only waiting for a Level
		/// </summary>
		public Munchlax(int level)
		: base(
				446,
				SpecieMunchlax.Instance, // Pokemon Specie
				"Munchlax", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Munchlax Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Munchlax() : base(
			446,
			SpecieMunchlax.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}