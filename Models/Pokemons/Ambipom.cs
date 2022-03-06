using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Ambipom Specie to store common natural stats of all Ambipoms
	#region SpecieAmbipom
	public class SpecieAmbipom : PokemonSpecie
	{
#nullable enable
		private static SpecieAmbipom? _instance = null;
#nullable restore
        public static SpecieAmbipom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAmbipom();
                }
                return _instance;
            }
        }

		#region SpecieAmbipom Builder
		public SpecieAmbipom() : base(
			"Ambipom",
			75, // HPs
			100, 66, // Attack & Defense
			60, 66, // Special Attack & Defense
			115		
		)
		{
			this._height = 12;
			this._weight = 203;
		}
		#endregion
	}
	#endregion

	//Ambipom Pokemon Class
	#region Ambipom
	public class Ambipom : Pokemon
	{
		#region Ambipom Builders
		/// <summary>
		/// Ambipom Builder waiting for a Nickname & a Level
		/// </summary>
		public Ambipom(string nickname, int level)
		: base(
				424,
				SpecieAmbipom.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ambipom Builder only waiting for a Level
		/// </summary>
		public Ambipom(int level)
		: base(
				424,
				SpecieAmbipom.Instance, // Pokemon Specie
				"Ambipom", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ambipom Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Ambipom() : base(
			424,
			SpecieAmbipom.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}