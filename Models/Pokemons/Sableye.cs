using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sableye Species to store common natural stats of all Sableyes
	#region SpeciesSableye
	public class SpeciesSableye : PokemonSpecies
	{
#nullable enable
		private static SpeciesSableye? _instance = null;
#nullable restore
        public static SpeciesSableye Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSableye();
                }
                return _instance;
            }
        }

		#region SpeciesSableye Constructor
		public SpeciesSableye() : base(
			302,
			"Sableye",
			0.5,
			11.0,
			50, // HPs
			75, 75, // Attack & Defense
			65, 65, // Special Attack & Defense
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
				"Scratch",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Dig",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Recover",
				"Confuse-Ray",
				"Metronome",
				"Dream-Eater",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Dynamic-Punch",
				"Moonlight",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Fake-Out",
				"Torment",
				"Flatter",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Brick-Break",
				"Knock-Off",
				"Imprison",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Signal-Beam",
				"Aerial-Ace",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Natural-Gift",
				"Feint",
				"Metal-Burst",
				"Payback",
				"Embargo",
				"Fling",
				"Punishment",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"Power-Gem",
				"Nasty-Plot",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Zen-Headbutt",
				"Captivate",
				"Ominous-Wind",
				"Hone-Claws",
				"Wonder-Room",
				"Telekinesis",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Quash",
				"Retaliate",
				"Snarl",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Sableye PokemonInstance Class
	#region Sableye
	public class SableyeInstance : PokemonInstance
	{
		#region Sableye Constructors
		/// <summary>
		/// Sableye Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SableyeInstance(string nickname, int level)
		: base(
				SpeciesSableye.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sableye Builder only waiting for a Level
		/// </summary>
		public SableyeInstance(int level)
		: base(
				SpeciesSableye.Instance, // PokemonInstance Species
				"Sableye", level,
				Dark.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sableye Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SableyeInstance() : base(
			SpeciesSableye.Instance, // PokemonInstance Species
			Dark.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}