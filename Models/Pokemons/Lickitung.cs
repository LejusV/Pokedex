using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lickitung Species to store common natural stats of all Lickitungs
	#region SpeciesLickitung
	public class SpeciesLickitung : PokemonSpecies
	{
#nullable enable
		private static SpeciesLickitung? _instance = null;
#nullable restore
        public static SpeciesLickitung Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLickitung();
                }
                return _instance;
            }
        }

		#region SpeciesLickitung Constructor
		public SpeciesLickitung() : base(
			108,
			"Lickitung",
			1.2,
			65.5,
			90, // HPs
			55, 75, // Attack & Defense
			60, 75, // Special Attack & Defense
			30		
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
				"Swords-Dance",
				"Cut",
				"Bind",
				"Slam",
				"Stomp",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Wrap",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Supersonic",
				"Disable",
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
				"Solar-Beam",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Lick",
				"Fire-Blast",
				"Skull-Bash",
				"Amnesia",
				"Dream-Eater",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Belly-Drum",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Facade",
				"Focus-Punch",
				"Smelling-Salts",
				"Brick-Break",
				"Knock-Off",
				"Refresh",
				"Secret-Power",
				"Rock-Tomb",
				"Muddy-Water",
				"Shock-Wave",
				"Water-Pulse",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Wring-Out",
				"Me-First",
				"Aqua-Tail",
				"Giga-Impact",
				"Zen-Headbutt",
				"Rock-Climb",
				"Power-Whip",
				"Captivate",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Belch",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Lickitung PokemonInstance Class
	#region Lickitung
	public class LickitungInstance : PokemonInstance
	{
		#region Lickitung Constructors
		/// <summary>
		/// Lickitung Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LickitungInstance(string nickname, int level)
		: base(
				SpeciesLickitung.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lickitung Builder only waiting for a Level
		/// </summary>
		public LickitungInstance(int level)
		: base(
				SpeciesLickitung.Instance, // PokemonInstance Species
				"Lickitung", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lickitung Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LickitungInstance() : base(
			SpeciesLickitung.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}