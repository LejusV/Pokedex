using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Crobat Specie to store common natural stats of all Crobats
	#region SpecieCrobat
	public class SpecieCrobat : PokemonSpecie
	{
#nullable enable
		private static SpecieCrobat? _instance = null;
#nullable restore
        public static SpecieCrobat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCrobat();
                }
                return _instance;
            }
        }

		#region SpecieCrobat Builder
		public SpecieCrobat() : base(
			"Crobat",
			85, // HPs
			90, 80, // Attack & Defense
			70, 80, // Special Attack & Defense
			130			
		) {}
		#endregion
	}
	#endregion

	//Crobat Pokemon Class
	#region Crobat
	public class Crobat : Pokemon
	{
		#region Crobat Builders
		/// <summary>
		/// Crobat Builder waiting for a Nickname & a Level
		/// </summary>
		public Crobat(string nickname, int level)
		: base(
				169,
				SpecieCrobat.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crobat Builder only waiting for a Level
		/// </summary>
		public Crobat(int level)
		: base(
				169,
				SpecieCrobat.Instance, // Pokemon Specie
				"Crobat", level,
				Poison.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Crobat Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Crobat() : base(
			169,
			SpecieCrobat.Instance, // Pokemon Specie
			Poison.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}