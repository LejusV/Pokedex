using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sudowoodo Specie to store common natural stats of all Sudowoodos
	#region SpecieSudowoodo
	public class SpecieSudowoodo : PokemonSpecie
	{
#nullable enable
		private static SpecieSudowoodo? _instance = null;
#nullable restore
        public static SpecieSudowoodo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSudowoodo();
                }
                return _instance;
            }
        }

		#region SpecieSudowoodo Builder
		public SpecieSudowoodo() : base(
			"Sudowoodo",
			1.2,
			38.0,
			70, // HPs
			100, 115, // Attack & Defense
			30, 65, // Special Attack & Defense
			30		
		)
		{}
		#endregion
	}
	#endregion

	//Sudowoodo Pokemon Class
	#region Sudowoodo
	public class Sudowoodo : Pokemon
	{
		#region Sudowoodo Builders
		/// <summary>
		/// Sudowoodo Builder waiting for a Nickname & a Level
		/// </summary>
		public Sudowoodo(string nickname, int level)
		: base(
				185,
				SpecieSudowoodo.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sudowoodo Builder only waiting for a Level
		/// </summary>
		public Sudowoodo(int level)
		: base(
				185,
				SpecieSudowoodo.Instance, // Pokemon Specie
				"Sudowoodo", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sudowoodo Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sudowoodo() : base(
			185,
			SpecieSudowoodo.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}