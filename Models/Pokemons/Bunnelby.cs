using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bunnelby Specie to store common natural stats of all Bunnelbys
	#region SpecieBunnelby
	public class SpecieBunnelby : PokemonSpecie
	{
#nullable enable
		private static SpecieBunnelby? _instance = null;
#nullable restore
        public static SpecieBunnelby Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBunnelby();
                }
                return _instance;
            }
        }

		#region SpecieBunnelby Builder
		public SpecieBunnelby() : base(
			"Bunnelby",
			38, // HPs
			36, 38, // Attack & Defense
			32, 36, // Special Attack & Defense
			57			
		) {}
		#endregion
	}
	#endregion

	//Bunnelby Pokemon Class
	#region Bunnelby
	public class Bunnelby : Pokemon
	{
		#region Bunnelby Builders
		/// <summary>
		/// Bunnelby Builder waiting for a Nickname & a Level
		/// </summary>
		public Bunnelby(string nickname, int level)
		: base(
				659,
				SpecieBunnelby.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bunnelby Builder only waiting for a Level
		/// </summary>
		public Bunnelby(int level)
		: base(
				659,
				SpecieBunnelby.Instance, // Pokemon Specie
				"Bunnelby", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bunnelby Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Bunnelby() : base(
			659,
			SpecieBunnelby.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}