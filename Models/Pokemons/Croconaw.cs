using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Croconaw Species to store common natural stats of all Croconaws
	#region SpeciesCroconaw
	public class SpeciesCroconaw : PokemonSpecies
	{
#nullable enable
		private static SpeciesCroconaw? _instance = null;
#nullable restore
        public static SpeciesCroconaw Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCroconaw();
                }
                return _instance;
            }
        }

		#region SpeciesCroconaw Constructor
		public SpeciesCroconaw() : base(
			159,
			"Croconaw",
			1.1,
			25.0,
			65, // HPs
			80, 80, // Attack & Defense
			59, 63, // Special Attack & Defense
			58		
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
				"Ice-Punch",
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Waterfall",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Icy-Wind",
				"Detect",
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
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Aerial-Ace",
				"Block",
				"Dragon-Claw",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Aqua-Tail",
				"Shadow-Claw",
				"Ice-Fang",
				"Captivate",
				"Hone-Claws",
				"Round",
				"Chip-Away",
				"Scald",
				"Water-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Croconaw PokemonInstance Class
	#region Croconaw
	public class CroconawInstance : PokemonInstance
	{
		#region Croconaw Constructors
		/// <summary>
		/// Croconaw Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CroconawInstance(string nickname, int level)
		: base(
				SpeciesCroconaw.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Croconaw Builder only waiting for a Level
		/// </summary>
		public CroconawInstance(int level)
		: base(
				SpeciesCroconaw.Instance, // PokemonInstance Species
				"Croconaw", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Croconaw Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CroconawInstance() : base(
			SpeciesCroconaw.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}