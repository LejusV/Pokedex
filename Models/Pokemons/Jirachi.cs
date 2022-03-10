using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Jirachi Species to store common natural stats of all Jirachis
	#region SpeciesJirachi
	public class SpeciesJirachi : PokemonSpecies
	{
#nullable enable
		private static SpeciesJirachi? _instance = null;
#nullable restore
        public static SpeciesJirachi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesJirachi();
                }
                return _instance;
            }
        }

		#region SpeciesJirachi Constructor
		public SpeciesJirachi() : base(
			"Jirachi",
			0.3,
			1.1,
			100, // HPs
			100, 100, // Attack & Defense
			100, 100, // Special Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Confusion",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Metronome",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Future-Sight",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Wish",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Refresh",
				"Secret-Power",
				"Cosmic-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Iron-Defense",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Doom-Desire",
				"Gravity",
				"Healing-Wish",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Lucky-Chant",
				"Last-Resort",
				"Drain-Punch",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Trick-Room",
				"Iron-Head",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Round",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Jirachi PokemonInstance Class
	#region Jirachi
	public class JirachiInstance : PokemonInstance
	{
		#region Jirachi Constructors
		/// <summary>
		/// Jirachi Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public JirachiInstance(string nickname, int level)
		: base(
				385,
				SpeciesJirachi.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jirachi Builder only waiting for a Level
		/// </summary>
		public JirachiInstance(int level)
		: base(
				385,
				SpeciesJirachi.Instance, // PokemonInstance Species
				"Jirachi", level,
				Steel.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jirachi Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Jirachi() : base(
			385,
			SpeciesJirachi.Instance, // PokemonInstance Species
			Steel.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}