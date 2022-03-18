using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mr-Mime Species to store common natural stats of all Mr-Mimes
	#region SpeciesMr-Mime
	public class SpeciesMrMime : PokemonSpecies
	{
#nullable enable
		private static SpeciesMrMime? _instance = null;
#nullable restore
        public static SpeciesMrMime Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMrMime();
                }
                return _instance;
            }
        }

		#region SpeciesMr-Mime Constructor
		public SpeciesMrMime() : base(
			122,
			"Mr-Mime",
			1.3,
			54.5,
			40, // HPs
			45, 65, // Attack & Defense
			100, 120, // Special Attack & Defense
			90		
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
				"Psybeam",
				"Hyper-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Meditate",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Barrier",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Metronome",
				"Skull-Bash",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Baton-Pass",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Fake-Out",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Teeter-Dance",
				"Signal-Beam",
				"Aerial-Ace",
				"Iron-Defense",
				"Covet",
				"Magical-Leaf",
				"Calm-Mind",
				"Shock-Wave",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Copycat",
				"Power-Swap",
				"Guard-Swap",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Wide-Guard",
				"Power-Split",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Quick-Guard",
				"Misty-Terrain",
				"Confide",
				"Dazzling-Gleam",
				"Infestation",
				"Power-Up-Punch",
				"Psychic-Terrain"
			};
		}
		#endregion
	}
	#endregion

	//Mr-Mime PokemonInstance Class
	#region Mr-Mime
	public class MrMimeInstance : PokemonInstance
	{
		#region Mr-Mime Constructors
		/// <summary>
		/// Mr-Mime Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MrMimeInstance(string nickname, int level)
		: base(
				SpeciesMrMime.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mr-Mime Builder only waiting for a Level
		/// </summary>
		public MrMimeInstance(int level)
		: base(
				SpeciesMrMime.Instance, // PokemonInstance Species
				"Mr-Mime", level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mr-Mime Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MrMimeInstance() : base(
			SpeciesMrMime.Instance, // PokemonInstance Species
			Psychic.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}