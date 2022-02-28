using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rattata Specie to store common natural stats of all Rattatas
	#region SpecieRattata
	public class SpecieRattata : PokemonSpecie
	{
#nullable enable
		private static SpecieRattata? _instance = null;
#nullable restore
        public static SpecieRattata Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRattata();
                }
                return _instance;
            }
        }

		#region SpecieRattata Builder
		public SpecieRattata() : base(
			"Rattata",
			30, // HPs
			56, 35, // Attack & Defense
			25, 35, // Special Attack & Defense
			72			
		) {}
		#endregion
	}
	#endregion

	//Rattata Pokemon Class
	#region Rattata
	public class Rattata : Pokemon
	{
		#region Rattata Builders
		/// <summary>
		/// Rattata Builder waiting for a Nickname & a Level
		/// </summary>
		public Rattata(string nickname, int level)
		: base(
				19,
				SpecieRattata.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rattata Builder only waiting for a Level
		/// </summary>
		public Rattata(int level)
		: base(
				19,
				SpecieRattata.Instance, // Pokemon Specie
				"Rattata", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rattata Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Rattata() : base(
			19,
			SpecieRattata.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}