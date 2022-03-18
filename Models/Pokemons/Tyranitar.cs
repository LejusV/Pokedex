using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tyranitar Species to store common natural stats of all Tyranitars
	#region SpeciesTyranitar
	public class SpeciesTyranitar : PokemonSpecies
	{
#nullable enable
		private static SpeciesTyranitar? _instance = null;
#nullable restore
        public static SpeciesTyranitar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTyranitar();
                }
                return _instance;
            }
        }

		#region SpeciesTyranitar Constructor
		public SpeciesTyranitar() : base(
			248,
			"Tyranitar",
			2.0,
			202.0,
			100, // HPs
			134, 110, // Attack & Defense
			95, 100, // Special Attack & Defense
			61		
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
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
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Dragon-Claw",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Rock-Polish",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Shadow-Claw",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Hone-Claws",
				"Smack-Down",
				"Foul-Play",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Dragon-Tail",
				"Snarl",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Tyranitar PokemonInstance Class
	#region Tyranitar
	public class TyranitarInstance : PokemonInstance
	{
		#region Tyranitar Constructors
		/// <summary>
		/// Tyranitar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TyranitarInstance(string nickname, int level)
		: base(
				SpeciesTyranitar.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyranitar Builder only waiting for a Level
		/// </summary>
		public TyranitarInstance(int level)
		: base(
				SpeciesTyranitar.Instance, // PokemonInstance Species
				"Tyranitar", level,
				Rock.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyranitar Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TyranitarInstance() : base(
			SpeciesTyranitar.Instance, // PokemonInstance Species
			Rock.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}