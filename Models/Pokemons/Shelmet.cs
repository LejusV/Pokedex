using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Shelmet Specie to store common natural stats of all Shelmets
	#region SpecieShelmet
	public class SpecieShelmet : PokemonSpecie
	{
#nullable enable
		private static SpecieShelmet? _instance = null;
#nullable restore
        public static SpecieShelmet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShelmet();
                }
                return _instance;
            }
        }

		#region SpecieShelmet Builder
		public SpecieShelmet() : base(
			"Shelmet",
			50, // HPs
			40, 85, // Attack & Defense
			40, 65, // Special Attack & Defense
			25			
		) {}
		#endregion
	}
	#endregion

	//Shelmet Pokemon Class
	#region Shelmet
	public class Shelmet : Pokemon
	{
		#region Shelmet Builders
		/// <summary>
		/// Shelmet Builder waiting for a Nickname & a Level
		/// </summary>
		public Shelmet(string nickname, int level)
		: base(
				616,
				SpecieShelmet.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shelmet Builder only waiting for a Level
		/// </summary>
		public Shelmet(int level)
		: base(
				616,
				SpecieShelmet.Instance, // Pokemon Specie
				"Shelmet", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shelmet Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Shelmet() : base(
			616,
			SpecieShelmet.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		#endregion
	}
	#endregion
}