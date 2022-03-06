using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Magikarp Specie to store common natural stats of all Magikarps
	#region SpecieMagikarp
	public class SpecieMagikarp : PokemonSpecie
	{
#nullable enable
		private static SpecieMagikarp? _instance = null;
#nullable restore
        public static SpecieMagikarp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMagikarp();
                }
                return _instance;
            }
        }

		#region SpecieMagikarp Builder
		public SpecieMagikarp() : base(
			"Magikarp",
			20, // HPs
			10, 55, // Attack & Defense
			15, 20, // Special Attack & Defense
			80		
		)
		{
			this._height = 9;
			this._weight = 100;
		}
		#endregion
	}
	#endregion

	//Magikarp Pokemon Class
	#region Magikarp
	public class Magikarp : Pokemon
	{
		#region Magikarp Builders
		/// <summary>
		/// Magikarp Builder waiting for a Nickname & a Level
		/// </summary>
		public Magikarp(string nickname, int level)
		: base(
				129,
				SpecieMagikarp.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magikarp Builder only waiting for a Level
		/// </summary>
		public Magikarp(int level)
		: base(
				129,
				SpecieMagikarp.Instance, // Pokemon Specie
				"Magikarp", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magikarp Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Magikarp() : base(
			129,
			SpecieMagikarp.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}