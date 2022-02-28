using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Woobat Specie to store common natural stats of all Woobats
	#region SpecieWoobat
	public class SpecieWoobat : PokemonSpecie
	{
#nullable enable
		private static SpecieWoobat? _instance = null;
#nullable restore
        public static SpecieWoobat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWoobat();
                }
                return _instance;
            }
        }

		#region SpecieWoobat Builder
		public SpecieWoobat() : base(
			"Woobat",
			65, // HPs
			45, 43, // Attack & Defense
			55, 43, // Special Attack & Defense
			72			
		) {}
		#endregion
	}
	#endregion

	//Woobat Pokemon Class
	#region Woobat
	public class Woobat : Pokemon
	{
		#region Woobat Builders
		/// <summary>
		/// Woobat Builder waiting for a Nickname & a Level
		/// </summary>
		public Woobat(string nickname, int level)
		: base(
				527,
				SpecieWoobat.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Woobat Builder only waiting for a Level
		/// </summary>
		public Woobat(int level)
		: base(
				527,
				SpecieWoobat.Instance, // Pokemon Specie
				"Woobat", level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Woobat Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Woobat() : base(
			527,
			SpecieWoobat.Instance, // Pokemon Specie
			Psychic.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}