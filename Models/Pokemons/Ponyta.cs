using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Ponyta Specie to store common natural stats of all Ponytas
	#region SpeciePonyta
	public class SpeciePonyta : PokemonSpecie
	{
#nullable enable
		private static SpeciePonyta? _instance = null;
#nullable restore
        public static SpeciePonyta Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePonyta();
                }
                return _instance;
            }
        }

		#region SpeciePonyta Builder
		public SpeciePonyta() : base(
			"Ponyta",
			50, // HPs
			85, 55, // Attack & Defense
			65, 65, // Special Attack & Defense
			90		
		)
		{
			this._height = 10;
			this._weight = 300;
		}
		#endregion
	}
	#endregion

	//Ponyta Pokemon Class
	#region Ponyta
	public class Ponyta : Pokemon
	{
		#region Ponyta Builders
		/// <summary>
		/// Ponyta Builder waiting for a Nickname & a Level
		/// </summary>
		public Ponyta(string nickname, int level)
		: base(
				77,
				SpeciePonyta.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ponyta Builder only waiting for a Level
		/// </summary>
		public Ponyta(int level)
		: base(
				77,
				SpeciePonyta.Instance, // Pokemon Specie
				"Ponyta", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ponyta Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Ponyta() : base(
			77,
			SpeciePonyta.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}