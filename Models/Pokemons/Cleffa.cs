using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cleffa Species to store common natural stats of all Cleffas
	#region SpeciesCleffa
	public class SpeciesCleffa : PokemonSpecies
	{
#nullable enable
		private static SpeciesCleffa? _instance = null;
#nullable restore
        public static SpeciesCleffa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCleffa();
                }
                return _instance;
            }
        }

		#region SpeciesCleffa Constructor
		public SpeciesCleffa() : base(
			173,
			"Cleffa",
			0.3,
			3.0,
			50, // HPs
			25, 28, // Attack & Defense
			45, 55, // Special Attack & Defense
			15		
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
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Sing",
				"Flamethrower",
				"Counter",
				"Seismic-Toss",
				"Solar-Beam",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Metronome",
				"Fire-Blast",
				"Amnesia",
				"Soft-Boiled",
				"Dream-Eater",
				"Flash",
				"Splash",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Sweet-Kiss",
				"Belly-Drum",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Present",
				"Frustration",
				"Safeguard",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Wish",
				"Magic-Coat",
				"Recycle",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Aromatherapy",
				"Fake-Tears",
				"Tickle",
				"Signal-Beam",
				"Covet",
				"Magical-Leaf",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Natural-Gift",
				"Fling",
				"Copycat",
				"Last-Resort",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Stored-Power",
				"Heal-Pulse",
				"Incinerate",
				"Work-Up",
				"Misty-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Cleffa PokemonInstance Class
	#region Cleffa
	public class CleffaInstance : PokemonInstance
	{
		#region Cleffa Constructors
		/// <summary>
		/// Cleffa Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CleffaInstance(string nickname, int level)
		: base(
				SpeciesCleffa.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cleffa Builder only waiting for a Level
		/// </summary>
		public CleffaInstance(int level)
		: base(
				SpeciesCleffa.Instance, // PokemonInstance Species
				"Cleffa", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cleffa Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CleffaInstance() : base(
			SpeciesCleffa.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}