using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Clefairy Species to store common natural stats of all Clefairys
	#region SpeciesClefairy
	public class SpeciesClefairy : PokemonSpecies
	{
#nullable enable
		private static SpeciesClefairy? _instance = null;
#nullable restore
        public static SpeciesClefairy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesClefairy();
                }
                return _instance;
            }
        }

		#region SpeciesClefairy Constructor
		public SpeciesClefairy() : base(
			"Clefairy",
			0.6,
			7.5,
			70, // HPs
			45, 48, // Attack & Defense
			60, 65, // Special Attack & Defense
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
				"Pound",
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
				"Growl",
				"Sing",
				"Flamethrower",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
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
				"Encore",
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
				"Follow-Me",
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
				"Meteor-Mash",
				"Cosmic-Power",
				"Signal-Beam",
				"Bounce",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Wake-Up-Slap",
				"Healing-Wish",
				"Natural-Gift",
				"Fling",
				"Lucky-Chant",
				"Last-Resort",
				"Drain-Punch",
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
				"Stored-Power",
				"Incinerate",
				"Retaliate",
				"Bestow",
				"Work-Up",
				"Disarming-Voice",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch",
				"Spotlight"
			};
		}
		#endregion
	}
	#endregion

	//Clefairy PokemonInstance Class
	#region Clefairy
	public class ClefairyInstance : PokemonInstance
	{
		#region Clefairy Constructors
		/// <summary>
		/// Clefairy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ClefairyInstance(string nickname, int level)
		: base(
				35,
				SpeciesClefairy.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clefairy Builder only waiting for a Level
		/// </summary>
		public ClefairyInstance(int level)
		: base(
				35,
				SpeciesClefairy.Instance, // PokemonInstance Species
				"Clefairy", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clefairy Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Clefairy() : base(
			35,
			SpeciesClefairy.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}