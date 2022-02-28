using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Muk Specie to store common natural stats of all Muks
	#region SpecieMuk
	public class SpecieMuk : PokemonSpecie
	{
#nullable enable
		private static SpecieMuk? _instance = null;
#nullable restore
        public static SpecieMuk Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMuk();
                }
                return _instance;
            }
        }

		#region SpecieMuk Builder
		public SpecieMuk() : base(
			"Muk",
			105, // HPs
			105, 75, // Attack & Defense
			65, 100, // Special Attack & Defense
			50			
		) {}
		#endregion
	}
	#endregion

	//Muk Pokemon Class
	#region Muk
	public class Muk : Pokemon
	{
		#region Muk Builders
		/// <summary>
		/// Muk Builder waiting for a Nickname & a Level
		/// </summary>
		public Muk(string nickname, int level)
		: base(
				89,
				SpecieMuk.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Muk Builder only waiting for a Level
		/// </summary>
		public Muk(int level)
		: base(
				89,
				SpecieMuk.Instance, // Pokemon Specie
				"Muk", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Muk Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Muk() : base(
			89,
			SpecieMuk.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}