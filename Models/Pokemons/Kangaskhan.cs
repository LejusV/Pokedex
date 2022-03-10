using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Kangaskhan Species to store common natural stats of all Kangaskhans
	#region SpeciesKangaskhan
	public class SpeciesKangaskhan : PokemonSpecies
	{
#nullable enable
		private static SpeciesKangaskhan? _instance = null;
#nullable restore
        public static SpeciesKangaskhan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKangaskhan();
                }
                return _instance;
            }
        }

		#region SpeciesKangaskhan Constructor
		public SpeciesKangaskhan() : base(
			"Kangaskhan",
			2.2,
			80.0,
			105, // HPs
			95, 80, // Attack & Defense
			40, 80, // Special Attack & Defense
			90		
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
				"Comet-Punch",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Cut",
				"Stomp",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Leer",
				"Bite",
				"Roar",
				"Disable",
				"Flamethrower",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Fire-Blast",
				"Skull-Bash",
				"Dizzy-Punch",
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
				"Zap-Cannon",
				"Foresight",
				"Icy-Wind",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Fake-Out",
				"Uproar",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Crush-Claw",
				"Rock-Tomb",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Trump-Card",
				"Sucker-Punch",
				"Aqua-Tail",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Avalanche",
				"Shadow-Claw",
				"Rock-Climb",
				"Captivate",
				"Double-Hit",
				"Round",
				"Chip-Away",
				"Circle-Throw",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Kangaskhan PokemonInstance Class
	#region Kangaskhan
	public class KangaskhanInstance : PokemonInstance
	{
		#region Kangaskhan Constructors
		/// <summary>
		/// Kangaskhan Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KangaskhanInstance(string nickname, int level)
		: base(
				115,
				SpeciesKangaskhan.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kangaskhan Builder only waiting for a Level
		/// </summary>
		public KangaskhanInstance(int level)
		: base(
				115,
				SpeciesKangaskhan.Instance, // PokemonInstance Species
				"Kangaskhan", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kangaskhan Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Kangaskhan() : base(
			115,
			SpeciesKangaskhan.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}