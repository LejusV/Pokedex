using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Rattata Species to store common natural stats of all Rattatas
	#region SpeciesRattata
	public class SpeciesRattata : PokemonSpecies
	{
#nullable enable
		private static SpeciesRattata? _instance = null;
#nullable restore
        public static SpeciesRattata Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRattata();
                }
                return _instance;
            }
        }

		#region SpeciesRattata Constructor
		public SpeciesRattata() : base(
			19,
			"Rattata",
			0.3,
			3.5,
			30, // HPs
			56, 35, // Attack & Defense
			25, 35, // Special Attack & Defense
			72		
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
				"Cut",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Bite",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Counter",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Fury-Swipes",
				"Rest",
				"Hyper-Fang",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Flame-Wheel",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Taunt",
				"Revenge",
				"Endeavor",
				"Secret-Power",
				"Covet",
				"Shock-Wave",
				"Natural-Gift",
				"Pluck",
				"U-Turn",
				"Assurance",
				"Me-First",
				"Last-Resort",
				"Sucker-Punch",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Retaliate",
				"Final-Gambit",
				"Work-Up",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Rattata PokemonInstance Class
	#region Rattata
	public class RattataInstance : PokemonInstance
	{
		#region Rattata Constructors
		/// <summary>
		/// Rattata Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RattataInstance(string nickname, int level)
		: base(
				SpeciesRattata.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rattata Builder only waiting for a Level
		/// </summary>
		public RattataInstance(int level)
		: base(
				SpeciesRattata.Instance, // PokemonInstance Species
				"Rattata", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rattata Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RattataInstance() : base(
			SpeciesRattata.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}