using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Alakazam Species to store common natural stats of all Alakazams
	#region SpeciesAlakazam
	public class SpeciesAlakazam : PokemonSpecies
	{
#nullable enable
		private static SpeciesAlakazam? _instance = null;
#nullable restore
        public static SpeciesAlakazam Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAlakazam();
                }
                return _instance;
            }
        }

		#region SpeciesAlakazam Constructor
		public SpeciesAlakazam() : base(
			65,
			"Alakazam",
			1.5,
			48.0,
			55, // HPs
			50, 45, // Attack & Defense
			135, 95, // Special Attack & Defense
			120		
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
				"Hyper-Beam",
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
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
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

	//Alakazam PokemonInstance Class
	#region Alakazam
	public class AlakazamInstance : PokemonInstance
	{
		#region Alakazam Constructors
		/// <summary>
		/// Alakazam Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AlakazamInstance(string nickname, int level)
		: base(
				SpeciesAlakazam.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Alakazam Builder only waiting for a Level
		/// </summary>
		public AlakazamInstance(int level)
		: base(
				SpeciesAlakazam.Instance, // PokemonInstance Species
				"Alakazam", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Alakazam Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public AlakazamInstance() : base(
			SpeciesAlakazam.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}