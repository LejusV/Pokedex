using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Medicham Specie to store common natural stats of all Medichams
	#region SpecieMedicham
	public class SpecieMedicham : PokemonSpecie
	{
#nullable enable
		private static SpecieMedicham? _instance = null;
#nullable restore
        public static SpecieMedicham Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMedicham();
                }
                return _instance;
            }
        }

		#region SpecieMedicham Builder
		public SpecieMedicham() : base(
			"Medicham",
			1.3,
			31.5,
			60, // HPs
			60, 75, // Attack & Defense
			60, 75, // Special Attack & Defense
			80		
		)
		{}
		#endregion
	}
	#endregion

	//Medicham Pokemon Class
	#region Medicham
	public class Medicham : Pokemon
	{
		#region Medicham Builders
		/// <summary>
		/// Medicham Builder waiting for a Nickname & a Level
		/// </summary>
		public Medicham(string nickname, int level)
		: base(
				308,
				SpecieMedicham.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Medicham Builder only waiting for a Level
		/// </summary>
		public Medicham(int level)
		: base(
				308,
				SpecieMedicham.Instance, // Pokemon Specie
				"Medicham", level,
				Fighting.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Medicham Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Medicham() : base(
			308,
			SpecieMedicham.Instance, // Pokemon Specie
			Fighting.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}