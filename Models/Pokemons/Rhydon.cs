using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Rhydon Species to store common natural stats of all Rhydons
	#region SpeciesRhydon
	public class SpeciesRhydon : PokemonSpecies
	{
#nullable enable
		private static SpeciesRhydon? _instance = null;
#nullable restore
        public static SpeciesRhydon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRhydon();
                }
                return _instance;
            }
        }

		#region SpeciesRhydon Constructor
		public SpeciesRhydon() : base(
			"Rhydon",
			1.9,
			120.0,
			105, // HPs
			130, 120, // Attack & Defense
			45, 45, // Special Attack & Defense
			40		
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
				"Mega-Punch",
				"Pay-Day",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Stomp",
				"Mega-Kick",
				"Headbutt",
				"Horn-Attack",
				"Fury-Attack",
				"Horn-Drill",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Leer",
				"Roar",
				"Flamethrower",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Bide",
				"Fire-Blast",
				"Skull-Bash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Megahorn",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Block",
				"Rock-Blast",
				"Shock-Wave",
				"Hammer-Arm",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Rock-Polish",
				"Poison-Jab",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Shadow-Claw",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Smack-Down",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Drill-Run",
				"Confide",
				"Power-Up-Punch",
				"Smart-Strike",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Rhydon PokemonInstance Class
	#region Rhydon
	public class RhydonInstance : PokemonInstance
	{
		#region Rhydon Constructors
		/// <summary>
		/// Rhydon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RhydonInstance(string nickname, int level)
		: base(
				112,
				SpeciesRhydon.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rhydon Builder only waiting for a Level
		/// </summary>
		public RhydonInstance(int level)
		: base(
				112,
				SpeciesRhydon.Instance, // PokemonInstance Species
				"Rhydon", level,
				Ground.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rhydon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Rhydon() : base(
			112,
			SpeciesRhydon.Instance, // PokemonInstance Species
			Ground.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}