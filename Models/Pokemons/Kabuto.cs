using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kabuto Specie to store common natural stats of all Kabutos
	#region SpecieKabuto
	public class SpecieKabuto : PokemonSpecie
	{
#nullable enable
		private static SpecieKabuto? _instance = null;
#nullable restore
        public static SpecieKabuto Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKabuto();
                }
                return _instance;
            }
        }

		#region SpecieKabuto Builder
		public SpecieKabuto() : base(
			"Kabuto",
			30, // HPs
			80, 90, // Attack & Defense
			55, 45, // Special Attack & Defense
			55			
		) {}
		#endregion
	}
	#endregion

	//Kabuto Pokemon Class
	#region Kabuto
	public class Kabuto : Pokemon
	{
		#region Kabuto Builders
		/// <summary>
		/// Kabuto Builder waiting for a Nickname & a Level
		/// </summary>
		public Kabuto(string nickname, int level)
		: base(
				140,
				SpecieKabuto.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kabuto Builder only waiting for a Level
		/// </summary>
		public Kabuto(int level)
		: base(
				140,
				SpecieKabuto.Instance, // Pokemon Specie
				"Kabuto", level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kabuto Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Kabuto() : base(
			140,
			SpecieKabuto.Instance, // Pokemon Specie
			Rock.Instance, Water.Instance			
		) {}
		#endregion
	}
	#endregion
}