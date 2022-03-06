using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Donphan Specie to store common natural stats of all Donphans
	#region SpecieDonphan
	public class SpecieDonphan : PokemonSpecie
	{
#nullable enable
		private static SpecieDonphan? _instance = null;
#nullable restore
        public static SpecieDonphan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDonphan();
                }
                return _instance;
            }
        }

		#region SpecieDonphan Builder
		public SpecieDonphan() : base(
			"Donphan",
			90, // HPs
			120, 120, // Attack & Defense
			60, 60, // Special Attack & Defense
			50		
		)
		{
			this._height = 11;
			this._weight = 1200;
		}
		#endregion
	}
	#endregion

	//Donphan Pokemon Class
	#region Donphan
	public class Donphan : Pokemon
	{
		#region Donphan Builders
		/// <summary>
		/// Donphan Builder waiting for a Nickname & a Level
		/// </summary>
		public Donphan(string nickname, int level)
		: base(
				232,
				SpecieDonphan.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Donphan Builder only waiting for a Level
		/// </summary>
		public Donphan(int level)
		: base(
				232,
				SpecieDonphan.Instance, // Pokemon Specie
				"Donphan", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Donphan Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Donphan() : base(
			232,
			SpecieDonphan.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}