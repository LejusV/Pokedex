using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Meloetta-Aria Specie to store common natural stats of all Meloetta-Arias
	#region SpecieMeloetta-Aria
	public class SpecieMeloettaAria : PokemonSpecie
	{
#nullable enable
		private static SpecieMeloettaAria? _instance = null;
#nullable restore
        public static SpecieMeloettaAria Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMeloettaAria();
                }
                return _instance;
            }
        }

		#region SpecieMeloetta-Aria Builder
		public SpecieMeloettaAria() : base(
			"Meloetta-Aria",
			0.6,
			6.5,
			100, // HPs
			77, 77, // Attack & Defense
			128, 128, // Special Attack & Defense
			90		
		)
		{}
		#endregion
	}
	#endregion

	//Meloetta-Aria Pokemon Class
	#region Meloetta-Aria
	public class MeloettaAria : Pokemon
	{
		#region Meloetta-Aria Builders
		/// <summary>
		/// Meloetta-Aria Builder waiting for a Nickname & a Level
		/// </summary>
		public MeloettaAria(string nickname, int level)
		: base(
				648,
				SpecieMeloettaAria.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meloetta-Aria Builder only waiting for a Level
		/// </summary>
		public MeloettaAria(int level)
		: base(
				648,
				SpecieMeloettaAria.Instance, // Pokemon Specie
				"Meloetta-Aria", level,
				Normal.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meloetta-Aria Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public MeloettaAria() : base(
			648,
			SpecieMeloettaAria.Instance, // Pokemon Specie
			Normal.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}