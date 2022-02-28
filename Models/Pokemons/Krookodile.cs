using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Krookodile Specie to store common natural stats of all Krookodiles
	#region SpecieKrookodile
	public class SpecieKrookodile : PokemonSpecie
	{
#nullable enable
		private static SpecieKrookodile? _instance = null;
#nullable restore
        public static SpecieKrookodile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKrookodile();
                }
                return _instance;
            }
        }

		#region SpecieKrookodile Builder
		public SpecieKrookodile() : base(
			"Krookodile",
			95, // HPs
			117, 80, // Attack & Defense
			65, 70, // Special Attack & Defense
			92			
		) {}
		#endregion
	}
	#endregion

	//Krookodile Pokemon Class
	#region Krookodile
	public class Krookodile : Pokemon
	{
		#region Krookodile Builders
		/// <summary>
		/// Krookodile Builder waiting for a Nickname & a Level
		/// </summary>
		public Krookodile(string nickname, int level)
		: base(
				553,
				SpecieKrookodile.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Krookodile Builder only waiting for a Level
		/// </summary>
		public Krookodile(int level)
		: base(
				553,
				SpecieKrookodile.Instance, // Pokemon Specie
				"Krookodile", level,
				Ground.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Krookodile Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Krookodile() : base(
			553,
			SpecieKrookodile.Instance, // Pokemon Specie
			Ground.Instance, Dark.Instance			
		) {}
		#endregion
	}
	#endregion
}