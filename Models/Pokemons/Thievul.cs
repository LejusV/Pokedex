using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Thievul Specie to store common natural stats of all Thievuls
	#region SpecieThievul
	public class SpecieThievul : PokemonSpecie
	{
#nullable enable
		private static SpecieThievul? _instance = null;
#nullable restore
        public static SpecieThievul Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieThievul();
                }
                return _instance;
            }
        }

		#region SpecieThievul Builder
		public SpecieThievul() : base(
			"Thievul",
			70, // HPs
			58, 58, // Attack & Defense
			87, 92, // Special Attack & Defense
			90		
		)
		{
			this._height = 12;
			this._weight = 199;
		}
		#endregion
	}
	#endregion

	//Thievul Pokemon Class
	#region Thievul
	public class Thievul : Pokemon
	{
		#region Thievul Builders
		/// <summary>
		/// Thievul Builder waiting for a Nickname & a Level
		/// </summary>
		public Thievul(string nickname, int level)
		: base(
				828,
				SpecieThievul.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Thievul Builder only waiting for a Level
		/// </summary>
		public Thievul(int level)
		: base(
				828,
				SpecieThievul.Instance, // Pokemon Specie
				"Thievul", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Thievul Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Thievul() : base(
			828,
			SpecieThievul.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}