using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sceptile Specie to store common natural stats of all Sceptiles
	#region SpecieSceptile
	public class SpecieSceptile : PokemonSpecie
	{
#nullable enable
		private static SpecieSceptile? _instance = null;
#nullable restore
        public static SpecieSceptile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSceptile();
                }
                return _instance;
            }
        }

		#region SpecieSceptile Builder
		public SpecieSceptile() : base(
			"Sceptile",
			1.7,
			52.2,
			70, // HPs
			85, 65, // Attack & Defense
			105, 85, // Special Attack & Defense
			120		
		)
		{}
		#endregion
	}
	#endregion

	//Sceptile Pokemon Class
	#region Sceptile
	public class Sceptile : Pokemon
	{
		#region Sceptile Builders
		/// <summary>
		/// Sceptile Builder waiting for a Nickname & a Level
		/// </summary>
		public Sceptile(string nickname, int level)
		: base(
				254,
				SpecieSceptile.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sceptile Builder only waiting for a Level
		/// </summary>
		public Sceptile(int level)
		: base(
				254,
				SpecieSceptile.Instance, // Pokemon Specie
				"Sceptile", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sceptile Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sceptile() : base(
			254,
			SpecieSceptile.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}