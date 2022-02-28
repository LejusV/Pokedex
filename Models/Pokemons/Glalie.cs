using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Glalie Specie to store common natural stats of all Glalies
	#region SpecieGlalie
	public class SpecieGlalie : PokemonSpecie
	{
#nullable enable
		private static SpecieGlalie? _instance = null;
#nullable restore
        public static SpecieGlalie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGlalie();
                }
                return _instance;
            }
        }

		#region SpecieGlalie Builder
		public SpecieGlalie() : base(
			"Glalie",
			80, // HPs
			80, 80, // Attack & Defense
			80, 80, // Special Attack & Defense
			80			
		) {}
		#endregion
	}
	#endregion

	//Glalie Pokemon Class
	#region Glalie
	public class Glalie : Pokemon
	{
		#region Glalie Builders
		/// <summary>
		/// Glalie Builder waiting for a Nickname & a Level
		/// </summary>
		public Glalie(string nickname, int level)
		: base(
				362,
				SpecieGlalie.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glalie Builder only waiting for a Level
		/// </summary>
		public Glalie(int level)
		: base(
				362,
				SpecieGlalie.Instance, // Pokemon Specie
				"Glalie", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glalie Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Glalie() : base(
			362,
			SpecieGlalie.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
		#endregion
	}
	#endregion
}