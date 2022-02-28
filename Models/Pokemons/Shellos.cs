using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Shellos Specie to store common natural stats of all Shelloss
	#region SpecieShellos
	public class SpecieShellos : PokemonSpecie
	{
#nullable enable
		private static SpecieShellos? _instance = null;
#nullable restore
        public static SpecieShellos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShellos();
                }
                return _instance;
            }
        }

		#region SpecieShellos Builder
		public SpecieShellos() : base(
			"Shellos",
			76, // HPs
			48, 48, // Attack & Defense
			57, 62, // Special Attack & Defense
			34			
		) {}
		#endregion
	}
	#endregion

	//Shellos Pokemon Class
	#region Shellos
	public class Shellos : Pokemon
	{
		#region Shellos Builders
		/// <summary>
		/// Shellos Builder waiting for a Nickname & a Level
		/// </summary>
		public Shellos(string nickname, int level)
		: base(
				422,
				SpecieShellos.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shellos Builder only waiting for a Level
		/// </summary>
		public Shellos(int level)
		: base(
				422,
				SpecieShellos.Instance, // Pokemon Specie
				"Shellos", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shellos Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Shellos() : base(
			422,
			SpecieShellos.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}