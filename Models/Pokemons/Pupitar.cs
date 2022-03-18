using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pupitar Species to store common natural stats of all Pupitars
	#region SpeciesPupitar
	public class SpeciesPupitar : PokemonSpecies
	{
#nullable enable
		private static SpeciesPupitar? _instance = null;
#nullable restore
        public static SpeciesPupitar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPupitar();
                }
                return _instance;
            }
        }

		#region SpeciesPupitar Constructor
		public SpeciesPupitar() : base(
			247,
			"Pupitar",
			1.2,
			152.0,
			70, // HPs
			84, 70, // Attack & Defense
			65, 70, // Special Attack & Defense
			51		
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
				"Headbutt",
				"Body-Slam",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Hyper-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Detect",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Natural-Gift",
				"Payback",
				"Rock-Polish",
				"Dark-Pulse",
				"Earth-Power",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Smack-Down",
				"Round",
				"Chip-Away",
				"Retaliate",
				"Bulldoze",
				"Snarl",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Pupitar PokemonInstance Class
	#region Pupitar
	public class PupitarInstance : PokemonInstance
	{
		#region Pupitar Constructors
		/// <summary>
		/// Pupitar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PupitarInstance(string nickname, int level)
		: base(
				SpeciesPupitar.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pupitar Builder only waiting for a Level
		/// </summary>
		public PupitarInstance(int level)
		: base(
				SpeciesPupitar.Instance, // PokemonInstance Species
				"Pupitar", level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pupitar Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PupitarInstance() : base(
			SpeciesPupitar.Instance, // PokemonInstance Species
			Rock.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}