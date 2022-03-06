using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Typhlosion Specie to store common natural stats of all Typhlosions
	#region SpecieTyphlosion
	public class SpecieTyphlosion : PokemonSpecie
	{
#nullable enable
		private static SpecieTyphlosion? _instance = null;
#nullable restore
        public static SpecieTyphlosion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTyphlosion();
                }
                return _instance;
            }
        }

		#region SpecieTyphlosion Builder
		public SpecieTyphlosion() : base(
			"Typhlosion",
			78, // HPs
			84, 78, // Attack & Defense
			109, 85, // Special Attack & Defense
			100		
		)
		{
			this._height = 17;
			this._weight = 795;
		}
		#endregion
	}
	#endregion

	//Typhlosion Pokemon Class
	#region Typhlosion
	public class Typhlosion : Pokemon
	{
		#region Typhlosion Builders
		/// <summary>
		/// Typhlosion Builder waiting for a Nickname & a Level
		/// </summary>
		public Typhlosion(string nickname, int level)
		: base(
				157,
				SpecieTyphlosion.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Typhlosion Builder only waiting for a Level
		/// </summary>
		public Typhlosion(int level)
		: base(
				157,
				SpecieTyphlosion.Instance, // Pokemon Specie
				"Typhlosion", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Typhlosion Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Typhlosion() : base(
			157,
			SpecieTyphlosion.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}