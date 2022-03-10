using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Whismur Species to store common natural stats of all Whismurs
	#region SpeciesWhismur
	public class SpeciesWhismur : PokemonSpecies
	{
#nullable enable
		private static SpeciesWhismur? _instance = null;
#nullable restore
        public static SpeciesWhismur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWhismur();
                }
                return _instance;
            }
        }

		#region SpeciesWhismur Constructor
		public SpeciesWhismur() : base(
			"Whismur",
			0.6,
			16.3,
			64, // HPs
			51, 23, // Attack & Defense
			51, 23, // Special Attack & Defense
			28		
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
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Whirlwind",
				"Stomp",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Roar",
				"Supersonic",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Counter",
				"Seismic-Toss",
				"Solar-Beam",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Smokescreen",
				"Defense-Curl",
				"Fire-Blast",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Smelling-Salts",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Fake-Tears",
				"Extrasensory",
				"Howl",
				"Shock-Wave",
				"Water-Pulse",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Zen-Headbutt",
				"Captivate",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Circle-Throw",
				"Incinerate",
				"Retaliate",
				"Work-Up",
				"Disarming-Voice",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Whismur PokemonInstance Class
	#region Whismur
	public class WhismurInstance : PokemonInstance
	{
		#region Whismur Constructors
		/// <summary>
		/// Whismur Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WhismurInstance(string nickname, int level)
		: base(
				293,
				SpeciesWhismur.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whismur Builder only waiting for a Level
		/// </summary>
		public WhismurInstance(int level)
		: base(
				293,
				SpeciesWhismur.Instance, // PokemonInstance Species
				"Whismur", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Whismur Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Whismur() : base(
			293,
			SpeciesWhismur.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}