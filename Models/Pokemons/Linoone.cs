using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Linoone Specie to store common natural stats of all Linoones
	#region SpecieLinoone
	public class SpecieLinoone : PokemonSpecie
	{
#nullable enable
		private static SpecieLinoone? _instance = null;
#nullable restore
        public static SpecieLinoone Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLinoone();
                }
                return _instance;
            }
        }

		#region SpecieLinoone Builder
		public SpecieLinoone() : base(
			"Linoone",
			78, // HPs
			70, 61, // Attack & Defense
			50, 61, // Special Attack & Defense
			100		
		)
		{
			this._height = 5;
			this._weight = 325;
		}
		#endregion
	}
	#endregion

	//Linoone Pokemon Class
	#region Linoone
	public class Linoone : Pokemon
	{
		#region Linoone Builders
		/// <summary>
		/// Linoone Builder waiting for a Nickname & a Level
		/// </summary>
		public Linoone(string nickname, int level)
		: base(
				264,
				SpecieLinoone.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Linoone Builder only waiting for a Level
		/// </summary>
		public Linoone(int level)
		: base(
				264,
				SpecieLinoone.Instance, // Pokemon Specie
				"Linoone", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Linoone Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Linoone() : base(
			264,
			SpecieLinoone.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}