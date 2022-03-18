using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Kecleon Species to store common natural stats of all Kecleons
	#region SpeciesKecleon
	public class SpeciesKecleon : PokemonSpecies
	{
#nullable enable
		private static SpeciesKecleon? _instance = null;
#nullable restore
        public static SpeciesKecleon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKecleon();
                }
                return _instance;
            }
        }

		#region SpeciesKecleon Constructor
		public SpeciesKecleon() : base(
			352,
			"Kecleon",
			1.0,
			22.0,
			60, // HPs
			90, 70, // Attack & Defense
			60, 120, // Special Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Scratch",
				"Cut",
				"Bind",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Disable",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Psybeam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Recover",
				"Defense-Curl",
				"Metronome",
				"Lick",
				"Fire-Blast",
				"Swift",
				"Dizzy-Punch",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Icy-Wind",
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
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Fake-Out",
				"Facade",
				"Focus-Punch",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Camouflage",
				"Astonish",
				"Rock-Tomb",
				"Aerial-Ace",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Feint",
				"Fling",
				"Last-Resort",
				"Sucker-Punch",
				"Aqua-Tail",
				"Drain-Punch",
				"Nasty-Plot",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Trick-Room",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Hone-Claws",
				"Wonder-Room",
				"Synchronoise",
				"Foul-Play",
				"After-You",
				"Round",
				"Incinerate",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Kecleon PokemonInstance Class
	#region Kecleon
	public class KecleonInstance : PokemonInstance
	{
		#region Kecleon Constructors
		/// <summary>
		/// Kecleon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KecleonInstance(string nickname, int level)
		: base(
				SpeciesKecleon.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kecleon Builder only waiting for a Level
		/// </summary>
		public KecleonInstance(int level)
		: base(
				SpeciesKecleon.Instance, // PokemonInstance Species
				"Kecleon", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kecleon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public KecleonInstance() : base(
			SpeciesKecleon.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}