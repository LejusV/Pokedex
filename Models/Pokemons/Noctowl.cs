using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Noctowl Specie to store common natural stats of all Noctowls
	#region SpecieNoctowl
	public class SpecieNoctowl : PokemonSpecie
	{
#nullable enable
		private static SpecieNoctowl? _instance = null;
#nullable restore
        public static SpecieNoctowl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNoctowl();
                }
                return _instance;
            }
        }

		#region SpecieNoctowl Builder
		public SpecieNoctowl() : base(
			"Noctowl",
			100, // HPs
			50, 50, // Attack & Defense
			86, 96, // Special Attack & Defense
			70		
		)
		{
			this._height = 16;
			this._weight = 408;
		}
		#endregion
	}
	#endregion

	//Noctowl Pokemon Class
	#region Noctowl
	public class Noctowl : Pokemon
	{
		#region Noctowl Builders
		/// <summary>
		/// Noctowl Builder waiting for a Nickname & a Level
		/// </summary>
		public Noctowl(string nickname, int level)
		: base(
				164,
				SpecieNoctowl.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Noctowl Builder only waiting for a Level
		/// </summary>
		public Noctowl(int level)
		: base(
				164,
				SpecieNoctowl.Instance, // Pokemon Specie
				"Noctowl", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Noctowl Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Noctowl() : base(
			164,
			SpecieNoctowl.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}