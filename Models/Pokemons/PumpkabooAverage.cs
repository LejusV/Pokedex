using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Pumpkaboo-Average Species to store common natural stats of all Pumpkaboo-Averages
	#region SpeciesPumpkaboo-Average
	public class SpeciesPumpkabooAverage : PokemonSpecies
	{
#nullable enable
		private static SpeciesPumpkabooAverage? _instance = null;
#nullable restore
        public static SpeciesPumpkabooAverage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPumpkabooAverage();
                }
                return _instance;
            }
        }

		#region SpeciesPumpkaboo-Average Constructor
		public SpeciesPumpkabooAverage() : base(
			710,
			"Pumpkaboo-Average",
			0.4,
			5.0,
			49, // HPs
			66, 70, // Attack & Defense
			44, 55, // Special Attack & Defense
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
				"Disable",
				"Flamethrower",
				"Leech-Seed",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Fire-Blast",
				"Dream-Eater",
				"Flash",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Curse",
				"Spite",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
				"Destiny-Bond",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Will-O-Wisp",
				"Facade",
				"Nature-Power",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Skill-Swap",
				"Secret-Power",
				"Astonish",
				"Bullet-Seed",
				"Gyro-Ball",
				"Worry-Seed",
				"Dark-Pulse",
				"Seed-Bomb",
				"Energy-Ball",
				"Shadow-Sneak",
				"Trick-Room",
				"Grass-Knot",
				"Charge-Beam",
				"Flame-Charge",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Bestow",
				"Trick-Or-Treat",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Pumpkaboo-Average PokemonInstance Class
	#region Pumpkaboo-Average
	public class PumpkabooAverageInstance : PokemonInstance
	{
		#region Pumpkaboo-Average Constructors
		/// <summary>
		/// Pumpkaboo-Average Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PumpkabooAverageInstance(string nickname, int level)
		: base(
				SpeciesPumpkabooAverage.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pumpkaboo-Average Builder only waiting for a Level
		/// </summary>
		public PumpkabooAverageInstance(int level)
		: base(
				SpeciesPumpkabooAverage.Instance, // PokemonInstance Species
				"Pumpkaboo-Average", level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pumpkaboo-Average Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public PumpkabooAverageInstance() : base(
			SpeciesPumpkabooAverage.Instance, // PokemonInstance Species
			Ghost.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}