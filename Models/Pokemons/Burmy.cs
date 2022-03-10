using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Burmy Species to store common natural stats of all Burmys
	#region SpeciesBurmy
	public class SpeciesBurmy : PokemonSpecies
	{
#nullable enable
		private static SpeciesBurmy? _instance = null;
#nullable restore
        public static SpeciesBurmy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBurmy();
                }
                return _instance;
            }
        }

		#region SpeciesBurmy Constructor
		public SpeciesBurmy() : base(
			"Burmy",
			0.2,
			3.4,
			40, // HPs
			29, 45, // Attack & Defense
			29, 45, // Special Attack & Defense
			36		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Tackle",
				"String-Shot",
				"Snore",
				"Protect",
				"Hidden-Power",
				"Bug-Bite",
				"Electroweb"
			};
		}
		#endregion
	}
	#endregion

	//Burmy PokemonInstance Class
	#region Burmy
	public class BurmyInstance : PokemonInstance
	{
		#region Burmy Constructors
		/// <summary>
		/// Burmy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BurmyInstance(string nickname, int level)
		: base(
				412,
				SpeciesBurmy.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Burmy Builder only waiting for a Level
		/// </summary>
		public BurmyInstance(int level)
		: base(
				412,
				SpeciesBurmy.Instance, // PokemonInstance Species
				"Burmy", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Burmy Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Burmy() : base(
			412,
			SpeciesBurmy.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}