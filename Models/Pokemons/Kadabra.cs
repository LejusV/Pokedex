using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Kadabra Species to store common natural stats of all Kadabras
	#region SpeciesKadabra
	public class SpeciesKadabra : PokemonSpecies
	{
#nullable enable
		private static SpeciesKadabra? _instance = null;
#nullable restore
        public static SpeciesKadabra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKadabra();
                }
                return _instance;
            }
        }

		#region SpeciesKadabra Constructor
		public SpeciesKadabra() : base(
			64,
			"Kadabra",
			1.3,
			56.5,
			40, // HPs
			35, 30, // Attack & Defense
			120, 70, // Special Attack & Defense
			105		
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
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Disable",
				"Psybeam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Confusion",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Metronome",
				"Skull-Bash",
				"Kinesis",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Zap-Cannon",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Knock-Off",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Signal-Beam",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Miracle-Eye",
				"Natural-Gift",
				"Embargo",
				"Fling",
				"Drain-Punch",
				"Energy-Ball",
				"Psycho-Cut",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Ally-Switch",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Kadabra PokemonInstance Class
	#region Kadabra
	public class KadabraInstance : PokemonInstance
	{
		#region Kadabra Constructors
		/// <summary>
		/// Kadabra Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KadabraInstance(string nickname, int level)
		: base(
				SpeciesKadabra.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kadabra Builder only waiting for a Level
		/// </summary>
		public KadabraInstance(int level)
		: base(
				SpeciesKadabra.Instance, // PokemonInstance Species
				"Kadabra", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kadabra Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public KadabraInstance() : base(
			SpeciesKadabra.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}