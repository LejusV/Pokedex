using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Abra Species to store common natural stats of all Abras
	#region SpeciesAbra
	public class SpeciesAbra : PokemonSpecies
	{
#nullable enable
		private static SpeciesAbra? _instance = null;
#nullable restore
        public static SpeciesAbra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAbra();
                }
                return _instance;
            }
        }

		#region SpeciesAbra Constructor
		public SpeciesAbra() : base(
			63,
			"Abra",
			0.9,
			19.5,
			25, // HPs
			20, 15, // Attack & Defense
			105, 55, // Special Attack & Defense
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
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
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
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
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
				"Natural-Gift",
				"Embargo",
				"Fling",
				"Psycho-Shift",
				"Power-Trick",
				"Guard-Swap",
				"Drain-Punch",
				"Energy-Ball",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Guard-Split",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Ally-Switch",
				"Confide",
				"Dazzling-Gleam",
				"Psychic-Terrain"
			};
		}
		#endregion
	}
	#endregion

	//Abra PokemonInstance Class
	#region Abra
	public class AbraInstance : PokemonInstance
	{
		#region Abra Constructors
		/// <summary>
		/// Abra Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AbraInstance(string nickname, int level)
		: base(
				SpeciesAbra.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Abra Builder only waiting for a Level
		/// </summary>
		public AbraInstance(int level)
		: base(
				SpeciesAbra.Instance, // PokemonInstance Species
				"Abra", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Abra Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public AbraInstance() : base(
			SpeciesAbra.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}