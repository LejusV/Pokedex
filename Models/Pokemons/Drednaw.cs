using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Drednaw Specie to store common natural stats of all Drednaws
	#region SpecieDrednaw
	public class SpecieDrednaw : PokemonSpecie
	{
#nullable enable
		private static SpecieDrednaw? _instance = null;
#nullable restore
        public static SpecieDrednaw Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDrednaw();
                }
                return _instance;
            }
        }

		#region SpecieDrednaw Builder
		public SpecieDrednaw() : base(
			"Drednaw",
			90, // HPs
			115, 90, // Attack & Defense
			48, 68, // Special Attack & Defense
			74			
		) {}
		#endregion
	}
	#endregion

	//Drednaw Pokemon Class
	#region Drednaw
	public class Drednaw : Pokemon
	{
		#region Drednaw Builders
		/// <summary>
		/// Drednaw Builder waiting for a Nickname & a Level
		/// </summary>
		public Drednaw(string nickname, int level)
		: base(
				834,
				SpecieDrednaw.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drednaw Builder only waiting for a Level
		/// </summary>
		public Drednaw(int level)
		: base(
				834,
				SpecieDrednaw.Instance, // Pokemon Specie
				"Drednaw", level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drednaw Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Drednaw() : base(
			834,
			SpecieDrednaw.Instance, // Pokemon Specie
			Water.Instance, Rock.Instance			
		) {}
		#endregion
	}
	#endregion
}