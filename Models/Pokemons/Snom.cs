using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Snom Specie to store common natural stats of all Snoms
	#region SpecieSnom
	public class SpecieSnom : PokemonSpecie
	{
#nullable enable
		private static SpecieSnom? _instance = null;
#nullable restore
        public static SpecieSnom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSnom();
                }
                return _instance;
            }
        }

		#region SpecieSnom Builder
		public SpecieSnom() : base(
			"Snom",
			30, // HPs
			25, 35, // Attack & Defense
			45, 30, // Special Attack & Defense
			20		
		)
		{
			this._height = 3;
			this._weight = 38;
		}
		#endregion
	}
	#endregion

	//Snom Pokemon Class
	#region Snom
	public class Snom : Pokemon
	{
		#region Snom Builders
		/// <summary>
		/// Snom Builder waiting for a Nickname & a Level
		/// </summary>
		public Snom(string nickname, int level)
		: base(
				872,
				SpecieSnom.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snom Builder only waiting for a Level
		/// </summary>
		public Snom(int level)
		: base(
				872,
				SpecieSnom.Instance, // Pokemon Specie
				"Snom", level,
				Ice.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snom Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Snom() : base(
			872,
			SpecieSnom.Instance, // Pokemon Specie
			Ice.Instance, Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}