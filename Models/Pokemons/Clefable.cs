using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Clefable Species to store common natural stats of all Clefables
	#region SpeciesClefable
	public class SpeciesClefable : PokemonSpecies
	{
#nullable enable
		private static SpeciesClefable? _instance = null;
#nullable restore
        public static SpeciesClefable Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesClefable();
                }
                return _instance;
            }
        }

		#region SpeciesClefable Constructor
		public SpeciesClefable() : base(
			36,
			"Clefable",
			1.3,
			40.0,
			95, // HPs
			70, 73, // Attack & Defense
			95, 90, // Special Attack & Defense
			60		
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
				"Double-Slap",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Sing",
				"Flamethrower",
				"Water-Gun",
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
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Minimize",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Metronome",
				"Fire-Blast",
				"Skull-Bash",
				"Soft-Boiled",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Iron-Tail",
				"Moonlight",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Signal-Beam",
				"Bounce",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Retaliate",
				"Work-Up",
				"Disarming-Voice",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch",
				"Spotlight"
			};
		}
		#endregion
	}
	#endregion

	//Clefable PokemonInstance Class
	#region Clefable
	public class ClefableInstance : PokemonInstance
	{
		#region Clefable Constructors
		/// <summary>
		/// Clefable Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ClefableInstance(string nickname, int level)
		: base(
				SpeciesClefable.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clefable Builder only waiting for a Level
		/// </summary>
		public ClefableInstance(int level)
		: base(
				SpeciesClefable.Instance, // PokemonInstance Species
				"Clefable", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clefable Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ClefableInstance() : base(
			SpeciesClefable.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}