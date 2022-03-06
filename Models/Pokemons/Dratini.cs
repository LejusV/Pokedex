using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dratini Specie to store common natural stats of all Dratinis
	#region SpecieDratini
	public class SpecieDratini : PokemonSpecie
	{
#nullable enable
		private static SpecieDratini? _instance = null;
#nullable restore
        public static SpecieDratini Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDratini();
                }
                return _instance;
            }
        }

		#region SpecieDratini Builder
		public SpecieDratini() : base(
			"Dratini",
			1.8,
			3.3,
			41, // HPs
			64, 45, // Attack & Defense
			50, 50, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Dratini Pokemon Class
	#region Dratini
	public class Dratini : Pokemon
	{
		#region Dratini Builders
		/// <summary>
		/// Dratini Builder waiting for a Nickname & a Level
		/// </summary>
		public Dratini(string nickname, int level)
		: base(
				147,
				SpecieDratini.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dratini Builder only waiting for a Level
		/// </summary>
		public Dratini(int level)
		: base(
				147,
				SpecieDratini.Instance, // Pokemon Specie
				"Dratini", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dratini Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dratini() : base(
			147,
			SpecieDratini.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}