using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Miltank Species to store common natural stats of all Miltanks
	#region SpeciesMiltank
	public class SpeciesMiltank : PokemonSpecies
	{
#nullable enable
		private static SpeciesMiltank? _instance = null;
#nullable restore
        public static SpeciesMiltank Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMiltank();
                }
                return _instance;
            }
        }

		#region SpeciesMiltank Constructor
		public SpeciesMiltank() : base(
			241,
			"Miltank",
			1.2,
			75.5,
			95, // HPs
			80, 105, // Attack & Defense
			40, 70, // Special Attack & Defense
			100		
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
				"Stomp",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Metronome",
				"Dizzy-Punch",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Milk-Drink",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Present",
				"Frustration",
				"Dynamic-Punch",
				"Sweet-Scent",
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
				"Helping-Hand",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Block",
				"Shock-Wave",
				"Water-Pulse",
				"Wake-Up-Slap",
				"Hammer-Arm",
				"Gyro-Ball",
				"Natural-Gift",
				"Fling",
				"Punishment",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Iron-Head",
				"Captivate",
				"Stealth-Rock",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Heart-Stamp",
				"Belch",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Miltank PokemonInstance Class
	#region Miltank
	public class MiltankInstance : PokemonInstance
	{
		#region Miltank Constructors
		/// <summary>
		/// Miltank Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MiltankInstance(string nickname, int level)
		: base(
				SpeciesMiltank.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Miltank Builder only waiting for a Level
		/// </summary>
		public MiltankInstance(int level)
		: base(
				SpeciesMiltank.Instance, // PokemonInstance Species
				"Miltank", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Miltank Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MiltankInstance() : base(
			SpeciesMiltank.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}