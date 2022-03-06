using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Ralts Specie to store common natural stats of all Raltss
	#region SpecieRalts
	public class SpecieRalts : PokemonSpecie
	{
#nullable enable
		private static SpecieRalts? _instance = null;
#nullable restore
        public static SpecieRalts Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRalts();
                }
                return _instance;
            }
        }

		#region SpecieRalts Builder
		public SpecieRalts() : base(
			"Ralts",
			28, // HPs
			25, 25, // Attack & Defense
			45, 35, // Special Attack & Defense
			40		
		)
		{
			this._height = 4;
			this._weight = 66;
		}
		#endregion
	}
	#endregion

	//Ralts Pokemon Class
	#region Ralts
	public class Ralts : Pokemon
	{
		#region Ralts Builders
		/// <summary>
		/// Ralts Builder waiting for a Nickname & a Level
		/// </summary>
		public Ralts(string nickname, int level)
		: base(
				280,
				SpecieRalts.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ralts Builder only waiting for a Level
		/// </summary>
		public Ralts(int level)
		: base(
				280,
				SpecieRalts.Instance, // Pokemon Specie
				"Ralts", level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ralts Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Ralts() : base(
			280,
			SpecieRalts.Instance, // Pokemon Specie
			Psychic.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}