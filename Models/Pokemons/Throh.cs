using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Throh Specie to store common natural stats of all Throhs
	#region SpecieThroh
	public class SpecieThroh : PokemonSpecie
	{
#nullable enable
		private static SpecieThroh? _instance = null;
#nullable restore
        public static SpecieThroh Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieThroh();
                }
                return _instance;
            }
        }

		#region SpecieThroh Builder
		public SpecieThroh() : base(
			"Throh",
			120, // HPs
			100, 85, // Attack & Defense
			30, 85, // Special Attack & Defense
			45			
		) {}
		#endregion
	}
	#endregion

	//Throh Pokemon Class
	#region Throh
	public class Throh : Pokemon
	{
		#region Throh Builders
		/// <summary>
		/// Throh Builder waiting for a Nickname & a Level
		/// </summary>
		public Throh(string nickname, int level)
		: base(
				538,
				SpecieThroh.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Throh Builder only waiting for a Level
		/// </summary>
		public Throh(int level)
		: base(
				538,
				SpecieThroh.Instance, // Pokemon Specie
				"Throh", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Throh Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Throh() : base(
			538,
			SpecieThroh.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}