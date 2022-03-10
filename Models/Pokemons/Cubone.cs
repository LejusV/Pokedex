using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cubone Species to store common natural stats of all Cubones
	#region SpeciesCubone
	public class SpeciesCubone : PokemonSpecies
	{
#nullable enable
		private static SpeciesCubone? _instance = null;
#nullable restore
        public static SpeciesCubone Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCubone();
                }
                return _instance;
            }
        }

		#region SpeciesCubone Constructor
		public SpeciesCubone() : base(
			"Cubone",
			0.4,
			6.5,
			50, // HPs
			50, 95, // Attack & Defense
			40, 50, // Special Attack & Defense
			35		
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
				"Thunder-Punch",
				"Swords-Dance",
				"Double-Kick",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Tail-Whip",
				"Leer",
				"Growl",
				"Flamethrower",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Bone-Club",
				"Fire-Blast",
				"Skull-Bash",
				"Bonemerang",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Belly-Drum",
				"Mud-Slap",
				"Perish-Song",
				"Icy-Wind",
				"Detect",
				"Bone-Rush",
				"Sandstorm",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Natural-Gift",
				"Fling",
				"Earth-Power",
				"Rock-Climb",
				"Iron-Head",
				"Captivate",
				"Stealth-Rock",
				"Smack-Down",
				"Round",
				"Echoed-Voice",
				"Chip-Away",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing",
				"Stomping-Tantrum"
			};
		}
		#endregion
	}
	#endregion

	//Cubone PokemonInstance Class
	#region Cubone
	public class CuboneInstance : PokemonInstance
	{
		#region Cubone Constructors
		/// <summary>
		/// Cubone Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CuboneInstance(string nickname, int level)
		: base(
				104,
				SpeciesCubone.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cubone Builder only waiting for a Level
		/// </summary>
		public CuboneInstance(int level)
		: base(
				104,
				SpeciesCubone.Instance, // PokemonInstance Species
				"Cubone", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cubone Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Cubone() : base(
			104,
			SpeciesCubone.Instance, // PokemonInstance Species
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}