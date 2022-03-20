using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pumpkaboo-Average Species to store common natural stats of all Pumpkaboo-Averages
	#region Pumpkaboo-AverageSpecies
	public class PumpkabooAverageSpecies : PokemonSpecies
	{
#nullable enable
		private static PumpkabooAverageSpecies? _instance = null;
#nullable restore
        public static PumpkabooAverageSpecies Instance => _instance ?? (_instance = new PumpkabooAverageSpecies());

		#region Pumpkaboo-AverageSpecies Constructor
		public PumpkabooAverageSpecies() : base(
			710,
			"Pumpkaboo-Average",
			Ghost.Instance, Grass.Instance,
			0.4,
			5.0,
			new PokemonStats(
				49, // HPs
				66, 70, // Attack & Defense
				44, 55, // Spacial Attack & Defense
				51 // Speed
			)			
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
}