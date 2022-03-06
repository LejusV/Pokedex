using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Scorbunny Specie to store common natural stats of all Scorbunnys
	#region SpecieScorbunny
	public class SpecieScorbunny : PokemonSpecie
	{
#nullable enable
		private static SpecieScorbunny? _instance = null;
#nullable restore
        public static SpecieScorbunny Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieScorbunny();
                }
                return _instance;
            }
        }

		#region SpecieScorbunny Builder
		public SpecieScorbunny() : base(
			"Scorbunny",
			50, // HPs
			71, 40, // Attack & Defense
			40, 40, // Special Attack & Defense
			69		
		)
		{
			this._height = 3;
			this._weight = 45;
		}
		#endregion
	}
	#endregion

	//Scorbunny Pokemon Class
	#region Scorbunny
	public class Scorbunny : Pokemon
	{
		#region Scorbunny Builders
		/// <summary>
		/// Scorbunny Builder waiting for a Nickname & a Level
		/// </summary>
		public Scorbunny(string nickname, int level)
		: base(
				813,
				SpecieScorbunny.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scorbunny Builder only waiting for a Level
		/// </summary>
		public Scorbunny(int level)
		: base(
				813,
				SpecieScorbunny.Instance, // Pokemon Specie
				"Scorbunny", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scorbunny Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Scorbunny() : base(
			813,
			SpecieScorbunny.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}