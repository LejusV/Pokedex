using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Nidoqueen Species to store common natural stats of all Nidoqueens
	#region SpeciesNidoqueen
	public class SpeciesNidoqueen : PokemonSpecies
	{
#nullable enable
		private static SpeciesNidoqueen? _instance = null;
#nullable restore
        public static SpeciesNidoqueen Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNidoqueen();
                }
                return _instance;
            }
        }

		#region SpeciesNidoqueen Constructor
		public SpeciesNidoqueen() : base(
			"Nidoqueen",
			1.3,
			60.0,
			90, // HPs
			92, 87, // Attack & Defense
			75, 85, // Special Attack & Defense
			76		
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
				"Scratch",
				"Cut",
				"Double-Kick",
				"Mega-Kick",
				"Headbutt",
				"Horn-Drill",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Poison-Sting",
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
				"Defense-Curl",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Skull-Bash",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Icy-Wind",
				"Detect",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
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
				"Hone-Claws",
				"Venoshock",
				"Smack-Down",
				"Sludge-Wave",
				"Round",
				"Echoed-Voice",
				"Chip-Away",
				"Incinerate",
				"Quash",
				"Bulldoze",
				"Dragon-Tail",
				"Drill-Run",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Nidoqueen PokemonInstance Class
	#region Nidoqueen
	public class NidoqueenInstance : PokemonInstance
	{
		#region Nidoqueen Constructors
		/// <summary>
		/// Nidoqueen Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NidoqueenInstance(string nickname, int level)
		: base(
				31,
				SpeciesNidoqueen.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoqueen Builder only waiting for a Level
		/// </summary>
		public NidoqueenInstance(int level)
		: base(
				31,
				SpeciesNidoqueen.Instance, // PokemonInstance Species
				"Nidoqueen", level,
				Poison.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoqueen Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Nidoqueen() : base(
			31,
			SpeciesNidoqueen.Instance, // PokemonInstance Species
			Poison.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}