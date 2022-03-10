using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Grumpig Species to store common natural stats of all Grumpigs
	#region SpeciesGrumpig
	public class SpeciesGrumpig : PokemonSpecies
	{
#nullable enable
		private static SpeciesGrumpig? _instance = null;
#nullable restore
        public static SpeciesGrumpig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGrumpig();
                }
                return _instance;
            }
        }

		#region SpeciesGrumpig Constructor
		public SpeciesGrumpig() : base(
			"Grumpig",
			0.9,
			71.5,
			80, // HPs
			45, 65, // Attack & Defense
			90, 110, // Special Attack & Defense
			80		
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
				"Double-Edge",
				"Psybeam",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Splash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Dynamic-Punch",
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
				"Brick-Break",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Teeter-Dance",
				"Odor-Sleuth",
				"Signal-Beam",
				"Bounce",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Power-Gem",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Round",
				"Bulldoze",
				"Belch",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Grumpig PokemonInstance Class
	#region Grumpig
	public class GrumpigInstance : PokemonInstance
	{
		#region Grumpig Constructors
		/// <summary>
		/// Grumpig Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GrumpigInstance(string nickname, int level)
		: base(
				326,
				SpeciesGrumpig.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grumpig Builder only waiting for a Level
		/// </summary>
		public GrumpigInstance(int level)
		: base(
				326,
				SpeciesGrumpig.Instance, // PokemonInstance Species
				"Grumpig", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grumpig Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Grumpig() : base(
			326,
			SpeciesGrumpig.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}