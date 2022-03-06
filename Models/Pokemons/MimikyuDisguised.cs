using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Mimikyu-Disguised Specie to store common natural stats of all Mimikyu-Disguiseds
	#region SpecieMimikyu-Disguised
	public class SpecieMimikyuDisguised : PokemonSpecie
	{
#nullable enable
		private static SpecieMimikyuDisguised? _instance = null;
#nullable restore
        public static SpecieMimikyuDisguised Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMimikyuDisguised();
                }
                return _instance;
            }
        }

		#region SpecieMimikyu-Disguised Builder
		public SpecieMimikyuDisguised() : base(
			"Mimikyu-Disguised",
			55, // HPs
			90, 80, // Attack & Defense
			50, 105, // Special Attack & Defense
			96		
		)
		{
			this._height = 2;
			this._weight = 7;
		}
		#endregion
	}
	#endregion

	//Mimikyu-Disguised Pokemon Class
	#region Mimikyu-Disguised
	public class MimikyuDisguised : Pokemon
	{
		#region Mimikyu-Disguised Builders
		/// <summary>
		/// Mimikyu-Disguised Builder waiting for a Nickname & a Level
		/// </summary>
		public MimikyuDisguised(string nickname, int level)
		: base(
				778,
				SpecieMimikyuDisguised.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mimikyu-Disguised Builder only waiting for a Level
		/// </summary>
		public MimikyuDisguised(int level)
		: base(
				778,
				SpecieMimikyuDisguised.Instance, // Pokemon Specie
				"Mimikyu-Disguised", level,
				Ghost.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mimikyu-Disguised Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public MimikyuDisguised() : base(
			778,
			SpecieMimikyuDisguised.Instance, // Pokemon Specie
			Ghost.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}