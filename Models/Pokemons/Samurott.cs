using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Samurott Specie to store common natural stats of all Samurotts
	#region SpecieSamurott
	public class SpecieSamurott : PokemonSpecie
	{
#nullable enable
		private static SpecieSamurott? _instance = null;
#nullable restore
        public static SpecieSamurott Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSamurott();
                }
                return _instance;
            }
        }

		#region SpecieSamurott Builder
		public SpecieSamurott() : base(
			"Samurott",
			1.5,
			94.6,
			95, // HPs
			100, 85, // Attack & Defense
			108, 70, // Special Attack & Defense
			70		
		)
		{}
		#endregion
	}
	#endregion

	//Samurott Pokemon Class
	#region Samurott
	public class Samurott : Pokemon
	{
		#region Samurott Builders
		/// <summary>
		/// Samurott Builder waiting for a Nickname & a Level
		/// </summary>
		public Samurott(string nickname, int level)
		: base(
				503,
				SpecieSamurott.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Samurott Builder only waiting for a Level
		/// </summary>
		public Samurott(int level)
		: base(
				503,
				SpecieSamurott.Instance, // Pokemon Specie
				"Samurott", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Samurott Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Samurott() : base(
			503,
			SpecieSamurott.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}