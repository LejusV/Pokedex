using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Stantler Species to store common natural stats of all Stantlers
	#region SpeciesStantler
	public class SpeciesStantler : PokemonSpecies
	{
#nullable enable
		private static SpeciesStantler? _instance = null;
#nullable restore
        public static SpeciesStantler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesStantler();
                }
                return _instance;
            }
        }

		#region SpeciesStantler Constructor
		public SpeciesStantler() : base(
			"Stantler",
			1.4,
			71.2,
			73, // HPs
			95, 62, // Attack & Defense
			85, 65, // Special Attack & Defense
			85		
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
				"Stomp",
				"Double-Kick",
				"Jump-Kick",
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Disable",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Rage",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
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
				"Curse",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Megahorn",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Role-Play",
				"Skill-Swap",
				"Imprison",
				"Secret-Power",
				"Mud-Sport",
				"Astonish",
				"Signal-Beam",
				"Extrasensory",
				"Bounce",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Me-First",
				"Last-Resort",
				"Sucker-Punch",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Charge-Beam",
				"Psyshock",
				"Magic-Room",
				"Round",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Stantler PokemonInstance Class
	#region Stantler
	public class StantlerInstance : PokemonInstance
	{
		#region Stantler Constructors
		/// <summary>
		/// Stantler Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public StantlerInstance(string nickname, int level)
		: base(
				234,
				SpeciesStantler.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stantler Builder only waiting for a Level
		/// </summary>
		public StantlerInstance(int level)
		: base(
				234,
				SpeciesStantler.Instance, // PokemonInstance Species
				"Stantler", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stantler Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Stantler() : base(
			234,
			SpeciesStantler.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}