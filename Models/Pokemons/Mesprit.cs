using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mesprit Specie to store common natural stats of all Mesprits
	#region SpecieMesprit
	public class SpecieMesprit : PokemonSpecie
	{
#nullable enable
		private static SpecieMesprit? _instance = null;
#nullable restore
        public static SpecieMesprit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMesprit();
                }
                return _instance;
            }
        }

		#region SpecieMesprit Builder
		public SpecieMesprit() : base(
			"Mesprit",
			80, // HPs
			105, 105, // Attack & Defense
			105, 105, // Special Attack & Defense
			80			
		) {}
		#endregion
	}
	#endregion

	//Mesprit Pokemon Class
	#region Mesprit
	public class Mesprit : Pokemon
	{
		#region Mesprit Builders
		/// <summary>
		/// Mesprit Builder waiting for a Nickname & a Level
		/// </summary>
		public Mesprit(string nickname, int level)
		: base(
				481,
				SpecieMesprit.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mesprit Builder only waiting for a Level
		/// </summary>
		public Mesprit(int level)
		: base(
				481,
				SpecieMesprit.Instance, // Pokemon Specie
				"Mesprit", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mesprit Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Mesprit() : base(
			481,
			SpecieMesprit.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}