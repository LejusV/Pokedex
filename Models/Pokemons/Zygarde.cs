using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Zygarde Specie to store common natural stats of all Zygardes
	#region SpecieZygarde
	public class SpecieZygarde : PokemonSpecie
	{
#nullable enable
		private static SpecieZygarde? _instance = null;
#nullable restore
        public static SpecieZygarde Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZygarde();
                }
                return _instance;
            }
        }

		#region SpecieZygarde Builder
		public SpecieZygarde() : base(
			"Zygarde",
			108, // HPs
			100, 121, // Attack & Defense
			81, 95, // Special Attack & Defense
			95			
		) {}
		#endregion
	}
	#endregion

	//Zygarde Pokemon Class
	#region Zygarde
	public class Zygarde : Pokemon
	{
		#region Zygarde Builders
		/// <summary>
		/// Zygarde Builder waiting for a Nickname & a Level
		/// </summary>
		public Zygarde(string nickname, int level)
		: base(
				718,
				SpecieZygarde.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zygarde Builder only waiting for a Level
		/// </summary>
		public Zygarde(int level)
		: base(
				718,
				SpecieZygarde.Instance, // Pokemon Specie
				"Zygarde", level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zygarde Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Zygarde() : base(
			718,
			SpecieZygarde.Instance, // Pokemon Specie
			Dragon.Instance, Ground.Instance			
		) {}
		#endregion
	}
	#endregion
}