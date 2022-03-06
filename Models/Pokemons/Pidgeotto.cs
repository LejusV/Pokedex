using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Pidgeotto Specie to store common natural stats of all Pidgeottos
	#region SpeciePidgeotto
	public class SpeciePidgeotto : PokemonSpecie
	{
#nullable enable
		private static SpeciePidgeotto? _instance = null;
#nullable restore
        public static SpeciePidgeotto Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePidgeotto();
                }
                return _instance;
            }
        }

		#region SpeciePidgeotto Builder
		public SpeciePidgeotto() : base(
			"Pidgeotto",
			63, // HPs
			60, 55, // Attack & Defense
			50, 50, // Special Attack & Defense
			71		
		)
		{
			this._height = 11;
			this._weight = 300;
		}
		#endregion
	}
	#endregion

	//Pidgeotto Pokemon Class
	#region Pidgeotto
	public class Pidgeotto : Pokemon
	{
		#region Pidgeotto Builders
		/// <summary>
		/// Pidgeotto Builder waiting for a Nickname & a Level
		/// </summary>
		public Pidgeotto(string nickname, int level)
		: base(
				17,
				SpeciePidgeotto.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidgeotto Builder only waiting for a Level
		/// </summary>
		public Pidgeotto(int level)
		: base(
				17,
				SpeciePidgeotto.Instance, // Pokemon Specie
				"Pidgeotto", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pidgeotto Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Pidgeotto() : base(
			17,
			SpeciePidgeotto.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}