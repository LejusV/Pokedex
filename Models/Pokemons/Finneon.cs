using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Finneon Specie to store common natural stats of all Finneons
	#region SpecieFinneon
	public class SpecieFinneon : PokemonSpecie
	{
#nullable enable
		private static SpecieFinneon? _instance = null;
#nullable restore
        public static SpecieFinneon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFinneon();
                }
                return _instance;
            }
        }

		#region SpecieFinneon Builder
		public SpecieFinneon() : base(
			"Finneon",
			0.4,
			7.0,
			49, // HPs
			49, 56, // Attack & Defense
			49, 61, // Special Attack & Defense
			66		
		)
		{}
		#endregion
	}
	#endregion

	//Finneon Pokemon Class
	#region Finneon
	public class Finneon : Pokemon
	{
		#region Finneon Builders
		/// <summary>
		/// Finneon Builder waiting for a Nickname & a Level
		/// </summary>
		public Finneon(string nickname, int level)
		: base(
				456,
				SpecieFinneon.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Finneon Builder only waiting for a Level
		/// </summary>
		public Finneon(int level)
		: base(
				456,
				SpecieFinneon.Instance, // Pokemon Specie
				"Finneon", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Finneon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Finneon() : base(
			456,
			SpecieFinneon.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}