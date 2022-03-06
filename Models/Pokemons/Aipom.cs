using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Aipom Specie to store common natural stats of all Aipoms
	#region SpecieAipom
	public class SpecieAipom : PokemonSpecie
	{
#nullable enable
		private static SpecieAipom? _instance = null;
#nullable restore
        public static SpecieAipom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAipom();
                }
                return _instance;
            }
        }

		#region SpecieAipom Builder
		public SpecieAipom() : base(
			"Aipom",
			55, // HPs
			70, 55, // Attack & Defense
			40, 55, // Special Attack & Defense
			85		
		)
		{
			this._height = 8;
			this._weight = 115;
		}
		#endregion
	}
	#endregion

	//Aipom Pokemon Class
	#region Aipom
	public class Aipom : Pokemon
	{
		#region Aipom Builders
		/// <summary>
		/// Aipom Builder waiting for a Nickname & a Level
		/// </summary>
		public Aipom(string nickname, int level)
		: base(
				190,
				SpecieAipom.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aipom Builder only waiting for a Level
		/// </summary>
		public Aipom(int level)
		: base(
				190,
				SpecieAipom.Instance, // Pokemon Specie
				"Aipom", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aipom Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Aipom() : base(
			190,
			SpecieAipom.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}