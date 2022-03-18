using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Aggron Species to store common natural stats of all Aggrons
	#region SpeciesAggron
	public class SpeciesAggron : PokemonSpecies
	{
#nullable enable
		private static SpeciesAggron? _instance = null;
#nullable restore
        public static SpeciesAggron Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAggron();
                }
                return _instance;
            }
        }

		#region SpeciesAggron Constructor
		public SpeciesAggron() : base(
			306,
			"Aggron",
			2.1,
			360.0,
			70, // HPs
			110, 180, // Attack & Defense
			60, 60, // Special Attack & Defense
			50		
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
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
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
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
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
				"Dynamic-Punch",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Dragon-Claw",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Metal-Burst",
				"Payback",
				"Fling",
				"Magnet-Rise",
				"Rock-Polish",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Shadow-Claw",
				"Flash-Cannon",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Hone-Claws",
				"Autotomize",
				"Smack-Down",
				"Heavy-Slam",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Power-Up-Punch",
				"Smart-Strike",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Aggron PokemonInstance Class
	#region Aggron
	public class AggronInstance : PokemonInstance
	{
		#region Aggron Constructors
		/// <summary>
		/// Aggron Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AggronInstance(string nickname, int level)
		: base(
				SpeciesAggron.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aggron Builder only waiting for a Level
		/// </summary>
		public AggronInstance(int level)
		: base(
				SpeciesAggron.Instance, // PokemonInstance Species
				"Aggron", level,
				Steel.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aggron Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public AggronInstance() : base(
			SpeciesAggron.Instance, // PokemonInstance Species
			Steel.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}