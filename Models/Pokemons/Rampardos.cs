using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rampardos Specie to store common natural stats of all Rampardoss
	#region SpecieRampardos
	public class SpecieRampardos : PokemonSpecie
	{
#nullable enable
		private static SpecieRampardos? _instance = null;
#nullable restore
        public static SpecieRampardos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRampardos();
                }
                return _instance;
            }
        }

		#region SpecieRampardos Builder
		public SpecieRampardos() : base(
			"Rampardos",
			97, // HPs
			165, 60, // Attack & Defense
			65, 50, // Special Attack & Defense
			58			
		) {}
		#endregion
	}
	#endregion

	//Rampardos Pokemon Class
	#region Rampardos
	public class Rampardos : Pokemon
	{
		#region Rampardos Builders
		/// <summary>
		/// Rampardos Builder waiting for a Nickname & a Level
		/// </summary>
		public Rampardos(string nickname, int level)
		: base(
				409,
				SpecieRampardos.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rampardos Builder only waiting for a Level
		/// </summary>
		public Rampardos(int level)
		: base(
				409,
				SpecieRampardos.Instance, // Pokemon Specie
				"Rampardos", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rampardos Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Rampardos() : base(
			409,
			SpecieRampardos.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
		#endregion
	}
	#endregion
}