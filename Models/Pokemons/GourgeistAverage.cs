using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gourgeist-Average Species to store common natural stats of all Gourgeist-Averages
	#region SpeciesGourgeist-Average
	public class SpeciesGourgeistAverage : PokemonSpecies
	{
#nullable enable
		private static SpeciesGourgeistAverage? _instance = null;
#nullable restore
        public static SpeciesGourgeistAverage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGourgeistAverage();
                }
                return _instance;
            }
        }

		#region SpeciesGourgeist-Average Constructor
		public SpeciesGourgeistAverage() : base(
			"Gourgeist-Average",
			0.9,
			12.5,
			65, // HPs
			90, 122, // Attack & Defense
			58, 75, // Special Attack & Defense
			84		
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
				"Flamethrower",
				"Hyper-Beam",
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
				"Spite",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
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
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Sneak",
				"Trick-Room",
				"Grass-Knot",
				"Charge-Beam",
				"Flame-Charge",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Phantom-Force",
				"Trick-Or-Treat",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Gourgeist-Average PokemonInstance Class
	#region Gourgeist-Average
	public class GourgeistAverageInstance : PokemonInstance
	{
		#region Gourgeist-Average Constructors
		/// <summary>
		/// Gourgeist-Average Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GourgeistAverageInstance(string nickname, int level)
		: base(
				711,
				SpeciesGourgeistAverage.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gourgeist-Average Builder only waiting for a Level
		/// </summary>
		public GourgeistAverageInstance(int level)
		: base(
				711,
				SpeciesGourgeistAverage.Instance, // PokemonInstance Species
				"Gourgeist-Average", level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gourgeist-Average Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GourgeistAverage() : base(
			711,
			SpeciesGourgeistAverage.Instance, // PokemonInstance Species
			Ghost.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}