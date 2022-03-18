using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Kricketot Species to store common natural stats of all Kricketots
	#region SpeciesKricketot
	public class SpeciesKricketot : PokemonSpecies
	{
#nullable enable
		private static SpeciesKricketot? _instance = null;
#nullable restore
        public static SpeciesKricketot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKricketot();
                }
                return _instance;
            }
        }

		#region SpeciesKricketot Constructor
		public SpeciesKricketot() : base(
			401,
			"Kricketot",
			0.3,
			2.2,
			37, // HPs
			25, 41, // Attack & Defense
			25, 41, // Special Attack & Defense
			25		
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
				"Growl",
				"String-Shot",
				"Bide",
				"Snore",
				"Mud-Slap",
				"Uproar",
				"Endeavor",
				"Bug-Bite",
				"Struggle-Bug"
			};
		}
		#endregion
	}
	#endregion

	//Kricketot PokemonInstance Class
	#region Kricketot
	public class KricketotInstance : PokemonInstance
	{
		#region Kricketot Constructors
		/// <summary>
		/// Kricketot Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KricketotInstance(string nickname, int level)
		: base(
				SpeciesKricketot.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kricketot Builder only waiting for a Level
		/// </summary>
		public KricketotInstance(int level)
		: base(
				SpeciesKricketot.Instance, // PokemonInstance Species
				"Kricketot", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kricketot Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public KricketotInstance() : base(
			SpeciesKricketot.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}