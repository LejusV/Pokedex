using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Jigglypuff Specie to store common natural stats of all Jigglypuffs
	#region SpecieJigglypuff
	public class SpecieJigglypuff : PokemonSpecie
	{
#nullable enable
		private static SpecieJigglypuff? _instance = null;
#nullable restore
        public static SpecieJigglypuff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieJigglypuff();
                }
                return _instance;
            }
        }

		#region SpecieJigglypuff Builder
		public SpecieJigglypuff() : base(
			"Jigglypuff",
			115, // HPs
			45, 20, // Attack & Defense
			45, 25, // Special Attack & Defense
			20			
		) {}
		#endregion
	}
	#endregion

	//Jigglypuff Pokemon Class
	#region Jigglypuff
	public class Jigglypuff : Pokemon
	{
		#region Jigglypuff Builders
		/// <summary>
		/// Jigglypuff Builder waiting for a Nickname & a Level
		/// </summary>
		public Jigglypuff(string nickname, int level)
		: base(
				39,
				SpecieJigglypuff.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jigglypuff Builder only waiting for a Level
		/// </summary>
		public Jigglypuff(int level)
		: base(
				39,
				SpecieJigglypuff.Instance, // Pokemon Specie
				"Jigglypuff", level,
				Normal.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jigglypuff Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Jigglypuff() : base(
			39,
			SpecieJigglypuff.Instance, // Pokemon Specie
			Normal.Instance, Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}