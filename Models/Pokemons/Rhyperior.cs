using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Rhyperior Species to store common natural stats of all Rhyperiors
	#region SpeciesRhyperior
	public class SpeciesRhyperior : PokemonSpecies
	{
#nullable enable
		private static SpeciesRhyperior? _instance = null;
#nullable restore
        public static SpeciesRhyperior Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRhyperior();
                }
                return _instance;
            }
        }

		#region SpeciesRhyperior Constructor
		public SpeciesRhyperior() : base(
			"Rhyperior",
			2.4,
			282.8,
			115, // HPs
			140, 130, // Attack & Defense
			55, 55, // Special Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Stomp",
				"Headbutt",
				"Horn-Attack",
				"Fury-Attack",
				"Horn-Drill",
				"Take-Down",
				"Tail-Whip",
				"Roar",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
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
				"Flash-Cannon",
				"Rock-Climb",
				"Rock-Wrecker",
				"Iron-Head",
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

	//Rhyperior PokemonInstance Class
	#region Rhyperior
	public class RhyperiorInstance : PokemonInstance
	{
		#region Rhyperior Constructors
		/// <summary>
		/// Rhyperior Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RhyperiorInstance(string nickname, int level)
		: base(
				464,
				SpeciesRhyperior.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rhyperior Builder only waiting for a Level
		/// </summary>
		public RhyperiorInstance(int level)
		: base(
				464,
				SpeciesRhyperior.Instance, // PokemonInstance Species
				"Rhyperior", level,
				Ground.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rhyperior Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Rhyperior() : base(
			464,
			SpeciesRhyperior.Instance, // PokemonInstance Species
			Ground.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}