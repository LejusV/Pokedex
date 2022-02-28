using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Paras Specie to store common natural stats of all Parass
	#region SpecieParas
	public class SpecieParas : PokemonSpecie
	{
#nullable enable
		private static SpecieParas? _instance = null;
#nullable restore
        public static SpecieParas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieParas();
                }
                return _instance;
            }
        }

		#region SpecieParas Builder
		public SpecieParas() : base(
			"Paras",
			35, // HPs
			70, 55, // Attack & Defense
			45, 55, // Special Attack & Defense
			25			
		) {}
		#endregion
	}
	#endregion

	//Paras Pokemon Class
	#region Paras
	public class Paras : Pokemon
	{
		#region Paras Builders
		/// <summary>
		/// Paras Builder waiting for a Nickname & a Level
		/// </summary>
		public Paras(string nickname, int level)
		: base(
				46,
				SpecieParas.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Paras Builder only waiting for a Level
		/// </summary>
		public Paras(int level)
		: base(
				46,
				SpecieParas.Instance, // Pokemon Specie
				"Paras", level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Paras Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Paras() : base(
			46,
			SpecieParas.Instance, // Pokemon Specie
			Bug.Instance, Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}