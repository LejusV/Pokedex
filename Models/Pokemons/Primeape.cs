using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Primeape Specie to store common natural stats of all Primeapes
	#region SpeciePrimeape
	public class SpeciePrimeape : PokemonSpecie
	{
#nullable enable
		private static SpeciePrimeape? _instance = null;
#nullable restore
        public static SpeciePrimeape Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePrimeape();
                }
                return _instance;
            }
        }

		#region SpeciePrimeape Builder
		public SpeciePrimeape() : base(
			"Primeape",
			65, // HPs
			105, 60, // Attack & Defense
			60, 70, // Special Attack & Defense
			95			
		) {}
		#endregion
	}
	#endregion

	//Primeape Pokemon Class
	#region Primeape
	public class Primeape : Pokemon
	{
		#region Primeape Builders
		/// <summary>
		/// Primeape Builder waiting for a Nickname & a Level
		/// </summary>
		public Primeape(string nickname, int level)
		: base(
				57,
				SpeciePrimeape.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Primeape Builder only waiting for a Level
		/// </summary>
		public Primeape(int level)
		: base(
				57,
				SpeciePrimeape.Instance, // Pokemon Specie
				"Primeape", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Primeape Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Primeape() : base(
			57,
			SpeciePrimeape.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}