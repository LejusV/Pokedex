using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Kirlia Specie to store common natural stats of all Kirlias
	#region SpecieKirlia
	public class SpecieKirlia : PokemonSpecie
	{
#nullable enable
		private static SpecieKirlia? _instance = null;
#nullable restore
        public static SpecieKirlia Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKirlia();
                }
                return _instance;
            }
        }

		#region SpecieKirlia Builder
		public SpecieKirlia() : base(
			"Kirlia",
			38, // HPs
			35, 35, // Attack & Defense
			65, 55, // Special Attack & Defense
			50		
		)
		{
			this._height = 8;
			this._weight = 202;
		}
		#endregion
	}
	#endregion

	//Kirlia Pokemon Class
	#region Kirlia
	public class Kirlia : Pokemon
	{
		#region Kirlia Builders
		/// <summary>
		/// Kirlia Builder waiting for a Nickname & a Level
		/// </summary>
		public Kirlia(string nickname, int level)
		: base(
				281,
				SpecieKirlia.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kirlia Builder only waiting for a Level
		/// </summary>
		public Kirlia(int level)
		: base(
				281,
				SpecieKirlia.Instance, // Pokemon Specie
				"Kirlia", level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kirlia Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Kirlia() : base(
			281,
			SpecieKirlia.Instance, // Pokemon Specie
			Psychic.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}