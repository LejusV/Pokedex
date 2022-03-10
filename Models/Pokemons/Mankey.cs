using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mankey Species to store common natural stats of all Mankeys
	#region SpeciesMankey
	public class SpeciesMankey : PokemonSpecies
	{
#nullable enable
		private static SpeciesMankey? _instance = null;
#nullable restore
        public static SpeciesMankey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMankey();
                }
                return _instance;
            }
        }

		#region SpeciesMankey Constructor
		public SpeciesMankey() : base(
			"Mankey",
			0.5,
			28.0,
			40, // HPs
			80, 35, // Attack & Defense
			35, 45, // Special Attack & Defense
			70		
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
				"Karate-Chop",
				"Mega-Punch",
				"Pay-Day",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Scratch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Meditate",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Bide",
				"Metronome",
				"Swift",
				"Skull-Bash",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Reversal",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Outrage",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Encore",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Cross-Chop",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Rock-Smash",
				"Beat-Up",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Smelling-Salts",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Revenge",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Natural-Gift",
				"U-Turn",
				"Close-Combat",
				"Payback",
				"Assurance",
				"Fling",
				"Punishment",
				"Poison-Jab",
				"Night-Slash",
				"Seed-Bomb",
				"Vacuum-Wave",
				"Focus-Blast",
				"Rock-Climb",
				"Gunk-Shot",
				"Captivate",
				"Hone-Claws",
				"Smack-Down",
				"Low-Sweep",
				"Round",
				"Acrobatics",
				"Retaliate",
				"Final-Gambit",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch",
				"Power-Trip",
				"Stomping-Tantrum"
			};
		}
		#endregion
	}
	#endregion

	//Mankey PokemonInstance Class
	#region Mankey
	public class MankeyInstance : PokemonInstance
	{
		#region Mankey Constructors
		/// <summary>
		/// Mankey Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MankeyInstance(string nickname, int level)
		: base(
				56,
				SpeciesMankey.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mankey Builder only waiting for a Level
		/// </summary>
		public MankeyInstance(int level)
		: base(
				56,
				SpeciesMankey.Instance, // PokemonInstance Species
				"Mankey", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mankey Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Mankey() : base(
			56,
			SpeciesMankey.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}