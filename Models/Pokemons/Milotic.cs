using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Milotic Specie to store common natural stats of all Milotics
	#region SpecieMilotic
	public class SpecieMilotic : PokemonSpecie
	{
#nullable enable
		private static SpecieMilotic? _instance = null;
#nullable restore
        public static SpecieMilotic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMilotic();
                }
                return _instance;
            }
        }

		#region SpecieMilotic Builder
		public SpecieMilotic() : base(
			"Milotic",
			95, // HPs
			60, 79, // Attack & Defense
			100, 125, // Special Attack & Defense
			81			
		) {}
		#endregion
	}
	#endregion

	//Milotic Pokemon Class
	#region Milotic
	public class Milotic : Pokemon
	{
		#region Milotic Builders
		/// <summary>
		/// Milotic Builder waiting for a Nickname & a Level
		/// </summary>
		public Milotic(string nickname, int level)
		: base(
				350,
				SpecieMilotic.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Milotic Builder only waiting for a Level
		/// </summary>
		public Milotic(int level)
		: base(
				350,
				SpecieMilotic.Instance, // Pokemon Specie
				"Milotic", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Milotic Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Milotic() : base(
			350,
			SpecieMilotic.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}