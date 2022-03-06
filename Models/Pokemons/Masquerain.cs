using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Masquerain Specie to store common natural stats of all Masquerains
	#region SpecieMasquerain
	public class SpecieMasquerain : PokemonSpecie
	{
#nullable enable
		private static SpecieMasquerain? _instance = null;
#nullable restore
        public static SpecieMasquerain Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMasquerain();
                }
                return _instance;
            }
        }

		#region SpecieMasquerain Builder
		public SpecieMasquerain() : base(
			"Masquerain",
			70, // HPs
			60, 62, // Attack & Defense
			100, 82, // Special Attack & Defense
			80		
		)
		{
			this._height = 8;
			this._weight = 36;
		}
		#endregion
	}
	#endregion

	//Masquerain Pokemon Class
	#region Masquerain
	public class Masquerain : Pokemon
	{
		#region Masquerain Builders
		/// <summary>
		/// Masquerain Builder waiting for a Nickname & a Level
		/// </summary>
		public Masquerain(string nickname, int level)
		: base(
				284,
				SpecieMasquerain.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Masquerain Builder only waiting for a Level
		/// </summary>
		public Masquerain(int level)
		: base(
				284,
				SpecieMasquerain.Instance, // Pokemon Specie
				"Masquerain", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Masquerain Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Masquerain() : base(
			284,
			SpecieMasquerain.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}