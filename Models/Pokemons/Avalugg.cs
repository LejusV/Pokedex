using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Avalugg Specie to store common natural stats of all Avaluggs
	#region SpecieAvalugg
	public class SpecieAvalugg : PokemonSpecie
	{
#nullable enable
		private static SpecieAvalugg? _instance = null;
#nullable restore
        public static SpecieAvalugg Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAvalugg();
                }
                return _instance;
            }
        }

		#region SpecieAvalugg Builder
		public SpecieAvalugg() : base(
			"Avalugg",
			95, // HPs
			117, 184, // Attack & Defense
			44, 46, // Special Attack & Defense
			28			
		) {}
		#endregion
	}
	#endregion

	//Avalugg Pokemon Class
	#region Avalugg
	public class Avalugg : Pokemon
	{
		#region Avalugg Builders
		/// <summary>
		/// Avalugg Builder waiting for a Nickname & a Level
		/// </summary>
		public Avalugg(string nickname, int level)
		: base(
				713,
				SpecieAvalugg.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Avalugg Builder only waiting for a Level
		/// </summary>
		public Avalugg(int level)
		: base(
				713,
				SpecieAvalugg.Instance, // Pokemon Specie
				"Avalugg", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Avalugg Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Avalugg() : base(
			713,
			SpecieAvalugg.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
		#endregion
	}
	#endregion
}