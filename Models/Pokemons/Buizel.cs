using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Buizel Specie to store common natural stats of all Buizels
	#region SpecieBuizel
	public class SpecieBuizel : PokemonSpecie
	{
#nullable enable
		private static SpecieBuizel? _instance = null;
#nullable restore
        public static SpecieBuizel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBuizel();
                }
                return _instance;
            }
        }

		#region SpecieBuizel Builder
		public SpecieBuizel() : base(
			"Buizel",
			55, // HPs
			65, 35, // Attack & Defense
			60, 30, // Special Attack & Defense
			85			
		) {}
		#endregion
	}
	#endregion

	//Buizel Pokemon Class
	#region Buizel
	public class Buizel : Pokemon
	{
		#region Buizel Builders
		/// <summary>
		/// Buizel Builder waiting for a Nickname & a Level
		/// </summary>
		public Buizel(string nickname, int level)
		: base(
				418,
				SpecieBuizel.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Buizel Builder only waiting for a Level
		/// </summary>
		public Buizel(int level)
		: base(
				418,
				SpecieBuizel.Instance, // Pokemon Specie
				"Buizel", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Buizel Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Buizel() : base(
			418,
			SpecieBuizel.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}