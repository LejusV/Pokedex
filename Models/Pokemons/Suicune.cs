using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Suicune Specie to store common natural stats of all Suicunes
	#region SpecieSuicune
	public class SpecieSuicune : PokemonSpecie
	{
#nullable enable
		private static SpecieSuicune? _instance = null;
#nullable restore
        public static SpecieSuicune Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSuicune();
                }
                return _instance;
            }
        }

		#region SpecieSuicune Builder
		public SpecieSuicune() : base(
			"Suicune",
			100, // HPs
			75, 115, // Attack & Defense
			90, 115, // Special Attack & Defense
			85			
		) {}
		#endregion
	}
	#endregion

	//Suicune Pokemon Class
	#region Suicune
	public class Suicune : Pokemon
	{
		#region Suicune Builders
		/// <summary>
		/// Suicune Builder waiting for a Nickname & a Level
		/// </summary>
		public Suicune(string nickname, int level)
		: base(
				245,
				SpecieSuicune.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Suicune Builder only waiting for a Level
		/// </summary>
		public Suicune(int level)
		: base(
				245,
				SpecieSuicune.Instance, // Pokemon Specie
				"Suicune", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Suicune Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Suicune() : base(
			245,
			SpecieSuicune.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}