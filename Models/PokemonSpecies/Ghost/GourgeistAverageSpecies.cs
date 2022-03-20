using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gourgeist-Average Species to store common natural stats of all Gourgeist-Averages
	#region Gourgeist-AverageSpecies
	public class GourgeistAverageSpecies : PokemonSpecies
	{
#nullable enable
		private static GourgeistAverageSpecies? _instance = null;
#nullable restore
        public static GourgeistAverageSpecies Instance => _instance ?? (_instance = new GourgeistAverageSpecies());

		#region Gourgeist-AverageSpecies Constructor
		public GourgeistAverageSpecies() : base(
			711,
			"Gourgeist-Average",
			Ghost.Instance, Grass.Instance,
			0.9,
			12.5,
			new PokemonStats(
				65, // HPs
				90, 122, // Attack & Defense
				58, 75, // Spacial Attack & Defense
				84 // Speed
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
}