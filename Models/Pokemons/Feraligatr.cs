using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Feraligatr Species to store common natural stats of all Feraligatrs
	#region SpeciesFeraligatr
	public class SpeciesFeraligatr : PokemonSpecies
	{
#nullable enable
		private static SpeciesFeraligatr? _instance = null;
#nullable restore
        public static SpeciesFeraligatr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFeraligatr();
                }
                return _instance;
            }
        }

		#region SpeciesFeraligatr Constructor
		public SpeciesFeraligatr() : base(
			"Feraligatr",
			2.3,
			88.8,
			85, // HPs
			105, 100, // Attack & Defense
			79, 83, // Special Attack & Defense
			78		
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
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
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
				"Outrage",
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
				"Hydro-Cannon",
				"Rock-Tomb",
				"Aerial-Ace",
				"Block",
				"Dragon-Claw",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Avalanche",
				"Shadow-Claw",
				"Ice-Fang",
				"Rock-Climb",
				"Captivate",
				"Hone-Claws",
				"Round",
				"Chip-Away",
				"Scald",
				"Water-Pledge",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Feraligatr PokemonInstance Class
	#region Feraligatr
	public class FeraligatrInstance : PokemonInstance
	{
		#region Feraligatr Constructors
		/// <summary>
		/// Feraligatr Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FeraligatrInstance(string nickname, int level)
		: base(
				160,
				SpeciesFeraligatr.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Feraligatr Builder only waiting for a Level
		/// </summary>
		public FeraligatrInstance(int level)
		: base(
				160,
				SpeciesFeraligatr.Instance, // PokemonInstance Species
				"Feraligatr", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Feraligatr Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Feraligatr() : base(
			160,
			SpeciesFeraligatr.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}