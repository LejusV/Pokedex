using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Nidoran-F Specie to store common natural stats of all Nidoran-Fs
	#region SpecieNidoran-F
	public class SpecieNidoranF : PokemonSpecie
	{
#nullable enable
		private static SpecieNidoranF? _instance = null;
#nullable restore
        public static SpecieNidoranF Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNidoranF();
                }
                return _instance;
            }
        }

		#region SpecieNidoran-F Builder
		public SpecieNidoranF() : base(
			"Nidoran-F",
			55, // HPs
			47, 52, // Attack & Defense
			40, 40, // Special Attack & Defense
			41		
		)
		{
			this._height = 4;
			this._weight = 70;
		}
		#endregion
	}
	#endregion

	//Nidoran-F Pokemon Class
	#region Nidoran-F
	public class NidoranF : Pokemon
	{
		#region Nidoran-F Builders
		/// <summary>
		/// Nidoran-F Builder waiting for a Nickname & a Level
		/// </summary>
		public NidoranF(string nickname, int level)
		: base(
				29,
				SpecieNidoranF.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoran-F Builder only waiting for a Level
		/// </summary>
		public NidoranF(int level)
		: base(
				29,
				SpecieNidoranF.Instance, // Pokemon Specie
				"Nidoran-F", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoran-F Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public NidoranF() : base(
			29,
			SpecieNidoranF.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}