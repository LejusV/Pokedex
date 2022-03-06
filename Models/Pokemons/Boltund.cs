using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Boltund Specie to store common natural stats of all Boltunds
	#region SpecieBoltund
	public class SpecieBoltund : PokemonSpecie
	{
#nullable enable
		private static SpecieBoltund? _instance = null;
#nullable restore
        public static SpecieBoltund Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBoltund();
                }
                return _instance;
            }
        }

		#region SpecieBoltund Builder
		public SpecieBoltund() : base(
			"Boltund",
			1.0,
			34.0,
			69, // HPs
			90, 60, // Attack & Defense
			90, 60, // Special Attack & Defense
			121		
		)
		{}
		#endregion
	}
	#endregion

	//Boltund Pokemon Class
	#region Boltund
	public class Boltund : Pokemon
	{
		#region Boltund Builders
		/// <summary>
		/// Boltund Builder waiting for a Nickname & a Level
		/// </summary>
		public Boltund(string nickname, int level)
		: base(
				836,
				SpecieBoltund.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Boltund Builder only waiting for a Level
		/// </summary>
		public Boltund(int level)
		: base(
				836,
				SpecieBoltund.Instance, // Pokemon Specie
				"Boltund", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Boltund Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Boltund() : base(
			836,
			SpecieBoltund.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}