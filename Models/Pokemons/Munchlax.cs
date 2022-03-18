using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Munchlax Species to store common natural stats of all Munchlaxs
	#region SpeciesMunchlax
	public class SpeciesMunchlax : PokemonSpecies
	{
#nullable enable
		private static SpeciesMunchlax? _instance = null;
#nullable restore
        public static SpeciesMunchlax Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMunchlax();
                }
                return _instance;
            }
        }

		#region SpeciesMunchlax Constructor
		public SpeciesMunchlax() : base(
			446,
			"Munchlax",
			0.6,
			105.0,
			135, // HPs
			85, 40, // Attack & Defense
			40, 85, // Special Attack & Defense
			5		
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
				"Whirlwind",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Counter",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Metronome",
				"Self-Destruct",
				"Lick",
				"Fire-Blast",
				"Amnesia",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Belly-Drum",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Stockpile",
				"Swallow",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Recycle",
				"Brick-Break",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Seed-Bomb",
				"Zen-Headbutt",
				"Rock-Climb",
				"Gunk-Shot",
				"Captivate",
				"After-You",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Belch",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Munchlax PokemonInstance Class
	#region Munchlax
	public class MunchlaxInstance : PokemonInstance
	{
		#region Munchlax Constructors
		/// <summary>
		/// Munchlax Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MunchlaxInstance(string nickname, int level)
		: base(
				SpeciesMunchlax.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Munchlax Builder only waiting for a Level
		/// </summary>
		public MunchlaxInstance(int level)
		: base(
				SpeciesMunchlax.Instance, // PokemonInstance Species
				"Munchlax", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Munchlax Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MunchlaxInstance() : base(
			SpeciesMunchlax.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}