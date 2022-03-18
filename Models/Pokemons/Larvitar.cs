using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Larvitar Species to store common natural stats of all Larvitars
	#region SpeciesLarvitar
	public class SpeciesLarvitar : PokemonSpecies
	{
#nullable enable
		private static SpeciesLarvitar? _instance = null;
#nullable restore
        public static SpeciesLarvitar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLarvitar();
                }
                return _instance;
            }
        }

		#region SpeciesLarvitar Constructor
		public SpeciesLarvitar() : base(
			246,
			"Larvitar",
			0.6,
			72.0,
			50, // HPs
			64, 50, // Attack & Defense
			45, 50, // Special Attack & Defense
			41		
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
				"Focus-Energy",
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
				"Pursuit",
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
				"Dragon-Dance",
				"Natural-Gift",
				"Payback",
				"Assurance",
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

	//Larvitar PokemonInstance Class
	#region Larvitar
	public class LarvitarInstance : PokemonInstance
	{
		#region Larvitar Constructors
		/// <summary>
		/// Larvitar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LarvitarInstance(string nickname, int level)
		: base(
				SpeciesLarvitar.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Larvitar Builder only waiting for a Level
		/// </summary>
		public LarvitarInstance(int level)
		: base(
				SpeciesLarvitar.Instance, // PokemonInstance Species
				"Larvitar", level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Larvitar Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LarvitarInstance() : base(
			SpeciesLarvitar.Instance, // PokemonInstance Species
			Rock.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}