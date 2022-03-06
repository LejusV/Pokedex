using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Naganadel Specie to store common natural stats of all Naganadels
	#region SpecieNaganadel
	public class SpecieNaganadel : PokemonSpecie
	{
#nullable enable
		private static SpecieNaganadel? _instance = null;
#nullable restore
        public static SpecieNaganadel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNaganadel();
                }
                return _instance;
            }
        }

		#region SpecieNaganadel Builder
		public SpecieNaganadel() : base(
			"Naganadel",
			73, // HPs
			73, 73, // Attack & Defense
			127, 73, // Special Attack & Defense
			121		
		)
		{
			this._height = 36;
			this._weight = 1500;
		}
		#endregion
	}
	#endregion

	//Naganadel Pokemon Class
	#region Naganadel
	public class Naganadel : Pokemon
	{
		#region Naganadel Builders
		/// <summary>
		/// Naganadel Builder waiting for a Nickname & a Level
		/// </summary>
		public Naganadel(string nickname, int level)
		: base(
				804,
				SpecieNaganadel.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Naganadel Builder only waiting for a Level
		/// </summary>
		public Naganadel(int level)
		: base(
				804,
				SpecieNaganadel.Instance, // Pokemon Specie
				"Naganadel", level,
				Poison.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Naganadel Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Naganadel() : base(
			804,
			SpecieNaganadel.Instance, // Pokemon Specie
			Poison.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}