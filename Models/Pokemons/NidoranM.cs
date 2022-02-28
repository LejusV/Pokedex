using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Nidoran-M Specie to store common natural stats of all Nidoran-Ms
	#region SpecieNidoran-M
	public class SpecieNidoranM : PokemonSpecie
	{
#nullable enable
		private static SpecieNidoranM? _instance = null;
#nullable restore
        public static SpecieNidoranM Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNidoranM();
                }
                return _instance;
            }
        }

		#region SpecieNidoran-M Builder
		public SpecieNidoranM() : base(
			"Nidoran-M",
			46, // HPs
			57, 40, // Attack & Defense
			40, 40, // Special Attack & Defense
			50			
		) {}
		#endregion
	}
	#endregion

	//Nidoran-M Pokemon Class
	#region Nidoran-M
	public class NidoranM : Pokemon
	{
		#region Nidoran-M Builders
		/// <summary>
		/// Nidoran-M Builder waiting for a Nickname & a Level
		/// </summary>
		public NidoranM(string nickname, int level)
		: base(
				32,
				SpecieNidoranM.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoran-M Builder only waiting for a Level
		/// </summary>
		public NidoranM(int level)
		: base(
				32,
				SpecieNidoranM.Instance, // Pokemon Specie
				"Nidoran-M", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoran-M Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public NidoranM() : base(
			32,
			SpecieNidoranM.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}