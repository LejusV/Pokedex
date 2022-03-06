using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Palossand Specie to store common natural stats of all Palossands
	#region SpeciePalossand
	public class SpeciePalossand : PokemonSpecie
	{
#nullable enable
		private static SpeciePalossand? _instance = null;
#nullable restore
        public static SpeciePalossand Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePalossand();
                }
                return _instance;
            }
        }

		#region SpeciePalossand Builder
		public SpeciePalossand() : base(
			"Palossand",
			1.3,
			250.0,
			85, // HPs
			75, 110, // Attack & Defense
			100, 75, // Special Attack & Defense
			35		
		)
		{}
		#endregion
	}
	#endregion

	//Palossand Pokemon Class
	#region Palossand
	public class Palossand : Pokemon
	{
		#region Palossand Builders
		/// <summary>
		/// Palossand Builder waiting for a Nickname & a Level
		/// </summary>
		public Palossand(string nickname, int level)
		: base(
				770,
				SpeciePalossand.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Palossand Builder only waiting for a Level
		/// </summary>
		public Palossand(int level)
		: base(
				770,
				SpeciePalossand.Instance, // Pokemon Specie
				"Palossand", level,
				Ghost.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Palossand Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Palossand() : base(
			770,
			SpeciePalossand.Instance, // Pokemon Specie
			Ghost.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}