using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Shellder Specie to store common natural stats of all Shellders
	#region SpecieShellder
	public class SpecieShellder : PokemonSpecie
	{
#nullable enable
		private static SpecieShellder? _instance = null;
#nullable restore
        public static SpecieShellder Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShellder();
                }
                return _instance;
            }
        }

		#region SpecieShellder Builder
		public SpecieShellder() : base(
			"Shellder",
			30, // HPs
			65, 100, // Attack & Defense
			45, 25, // Special Attack & Defense
			40			
		) {}
		#endregion
	}
	#endregion

	//Shellder Pokemon Class
	#region Shellder
	public class Shellder : Pokemon
	{
		#region Shellder Builders
		/// <summary>
		/// Shellder Builder waiting for a Nickname & a Level
		/// </summary>
		public Shellder(string nickname, int level)
		: base(
				90,
				SpecieShellder.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shellder Builder only waiting for a Level
		/// </summary>
		public Shellder(int level)
		: base(
				90,
				SpecieShellder.Instance, // Pokemon Specie
				"Shellder", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shellder Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Shellder() : base(
			90,
			SpecieShellder.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}