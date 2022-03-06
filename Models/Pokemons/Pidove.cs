using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Pidove Specie to store common natural stats of all Pidoves
	#region SpeciePidove
	public class SpeciePidove : PokemonSpecie
	{
#nullable enable
		private static SpeciePidove? _instance = null;
#nullable restore
        public static SpeciePidove Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePidove();
                }
                return _instance;
            }
        }

		#region SpeciePidove Builder
		public SpeciePidove() : base(
			"Pidove",
			50, // HPs
			55, 50, // Attack & Defense
			36, 30, // Special Attack & Defense
			43		
		)
		{
			this._height = 3;
			this._weight = 21;
		}
		#endregion
	}
	#endregion

	//Pidove Pokemon Class
	#region Pidove
	public class Pidove : Pokemon
	{
		#region Pidove Builders
		/// <summary>
		/// Pidove Builder waiting for a Nickname & a Level
		/// </summary>
		public Pidove(string nickname, int level)
		: base(
				519,
				SpeciePidove.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidove Builder only waiting for a Level
		/// </summary>
		public Pidove(int level)
		: base(
				519,
				SpeciePidove.Instance, // Pokemon Specie
				"Pidove", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidove Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Pidove() : base(
			519,
			SpeciePidove.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}