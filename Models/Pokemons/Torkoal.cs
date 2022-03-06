using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Torkoal Specie to store common natural stats of all Torkoals
	#region SpecieTorkoal
	public class SpecieTorkoal : PokemonSpecie
	{
#nullable enable
		private static SpecieTorkoal? _instance = null;
#nullable restore
        public static SpecieTorkoal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTorkoal();
                }
                return _instance;
            }
        }

		#region SpecieTorkoal Builder
		public SpecieTorkoal() : base(
			"Torkoal",
			0.5,
			80.4,
			70, // HPs
			85, 140, // Attack & Defense
			85, 70, // Special Attack & Defense
			20		
		)
		{}
		#endregion
	}
	#endregion

	//Torkoal Pokemon Class
	#region Torkoal
	public class Torkoal : Pokemon
	{
		#region Torkoal Builders
		/// <summary>
		/// Torkoal Builder waiting for a Nickname & a Level
		/// </summary>
		public Torkoal(string nickname, int level)
		: base(
				324,
				SpecieTorkoal.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torkoal Builder only waiting for a Level
		/// </summary>
		public Torkoal(int level)
		: base(
				324,
				SpecieTorkoal.Instance, // Pokemon Specie
				"Torkoal", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torkoal Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Torkoal() : base(
			324,
			SpecieTorkoal.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}