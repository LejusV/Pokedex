using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ralts Species to store common natural stats of all Raltss
	#region SpeciesRalts
	public class SpeciesRalts : PokemonSpecies
	{
#nullable enable
		private static SpeciesRalts? _instance = null;
#nullable restore
        public static SpeciesRalts Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRalts();
                }
                return _instance;
            }
        }

		#region SpeciesRalts Constructor
		public SpeciesRalts() : base(
			280,
			"Ralts",
			0.4,
			6.6,
			28, // HPs
			25, 25, // Attack & Defense
			45, 35, // Special Attack & Defense
			40		
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Disable",
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Destiny-Bond",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Torment",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Imprison",
				"Grudge",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Signal-Beam",
				"Magical-Leaf",
				"Calm-Mind",
				"Shock-Wave",
				"Natural-Gift",
				"Fling",
				"Lucky-Chant",
				"Shadow-Sneak",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Stored-Power",
				"Ally-Switch",
				"Heal-Pulse",
				"Disarming-Voice",
				"Draining-Kiss",
				"Misty-Terrain",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Ralts PokemonInstance Class
	#region Ralts
	public class RaltsInstance : PokemonInstance
	{
		#region Ralts Constructors
		/// <summary>
		/// Ralts Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RaltsInstance(string nickname, int level)
		: base(
				SpeciesRalts.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ralts Builder only waiting for a Level
		/// </summary>
		public RaltsInstance(int level)
		: base(
				SpeciesRalts.Instance, // PokemonInstance Species
				"Ralts", level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ralts Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RaltsInstance() : base(
			SpeciesRalts.Instance, // PokemonInstance Species
			Psychic.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}