using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Copperajah Specie to store common natural stats of all Copperajahs
	#region SpecieCopperajah
	public class SpecieCopperajah : PokemonSpecie
	{
#nullable enable
		private static SpecieCopperajah? _instance = null;
#nullable restore
        public static SpecieCopperajah Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCopperajah();
                }
                return _instance;
            }
        }

		#region SpecieCopperajah Builder
		public SpecieCopperajah() : base(
			"Copperajah",
			122, // HPs
			130, 69, // Attack & Defense
			80, 69, // Special Attack & Defense
			30		
		)
		{
			this._height = 30;
			this._weight = 6500;
		}
		#endregion
	}
	#endregion

	//Copperajah Pokemon Class
	#region Copperajah
	public class Copperajah : Pokemon
	{
		#region Copperajah Builders
		/// <summary>
		/// Copperajah Builder waiting for a Nickname & a Level
		/// </summary>
		public Copperajah(string nickname, int level)
		: base(
				879,
				SpecieCopperajah.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Copperajah Builder only waiting for a Level
		/// </summary>
		public Copperajah(int level)
		: base(
				879,
				SpecieCopperajah.Instance, // Pokemon Specie
				"Copperajah", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Copperajah Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Copperajah() : base(
			879,
			SpecieCopperajah.Instance, // Pokemon Specie
			Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}