using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Nidoking Species to store common natural stats of all Nidokings
	#region SpeciesNidoking
	public class SpeciesNidoking : PokemonSpecies
	{
#nullable enable
		private static SpeciesNidoking? _instance = null;
#nullable restore
        public static SpeciesNidoking Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNidoking();
                }
                return _instance;
            }
        }

		#region SpeciesNidoking Constructor
		public SpeciesNidoking() : base(
			34,
			"Nidoking",
			1.4,
			62.0,
			81, // HPs
			102, 77, // Attack & Defense
			85, 75, // Special Attack & Defense
			85		
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
				"Cut",
				"Double-Kick",
				"Mega-Kick",
				"Headbutt",
				"Horn-Attack",
				"Horn-Drill",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Poison-Sting",
				"Roar",
				"Flamethrower",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Peck",
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
				"Focus-Energy",
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
				"Megahorn",
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
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Sucker-Punch",
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
				"Power-Up-Punch",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Nidoking PokemonInstance Class
	#region Nidoking
	public class NidokingInstance : PokemonInstance
	{
		#region Nidoking Constructors
		/// <summary>
		/// Nidoking Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NidokingInstance(string nickname, int level)
		: base(
				SpeciesNidoking.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoking Builder only waiting for a Level
		/// </summary>
		public NidokingInstance(int level)
		: base(
				SpeciesNidoking.Instance, // PokemonInstance Species
				"Nidoking", level,
				Poison.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoking Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public NidokingInstance() : base(
			SpeciesNidoking.Instance, // PokemonInstance Species
			Poison.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}