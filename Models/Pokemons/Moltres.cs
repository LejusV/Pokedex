using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Moltres Specie to store common natural stats of all Moltress
	#region SpecieMoltres
	public class SpecieMoltres : PokemonSpecie
	{
#nullable enable
		private static SpecieMoltres? _instance = null;
#nullable restore
        public static SpecieMoltres Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMoltres();
                }
                return _instance;
            }
        }

		#region SpecieMoltres Builder
		public SpecieMoltres() : base(
			"Moltres",
			90, // HPs
			100, 90, // Attack & Defense
			125, 85, // Special Attack & Defense
			90			
		) {}
		#endregion
	}
	#endregion

	//Moltres Pokemon Class
	#region Moltres
	public class Moltres : Pokemon
	{
		#region Moltres Builders
		/// <summary>
		/// Moltres Builder waiting for a Nickname & a Level
		/// </summary>
		public Moltres(string nickname, int level)
		: base(
				146,
				SpecieMoltres.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Moltres Builder only waiting for a Level
		/// </summary>
		public Moltres(int level)
		: base(
				146,
				SpecieMoltres.Instance, // Pokemon Specie
				"Moltres", level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Moltres Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Moltres() : base(
			146,
			SpecieMoltres.Instance, // Pokemon Specie
			Fire.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}