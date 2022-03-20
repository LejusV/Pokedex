using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Phantump Species to store common natural stats of all Phantumps
	#region PhantumpSpecies
	public class PhantumpSpecies : PokemonSpecies
	{
#nullable enable
		private static PhantumpSpecies? _instance = null;
#nullable restore
        public static PhantumpSpecies Instance => _instance ?? (_instance = new PhantumpSpecies());

		#region PhantumpSpecies Constructor
		public PhantumpSpecies() : base(
			708,
			"Phantump",
			Ghost.Instance, Grass.Instance,
			0.4,
			7.0,
			new PokemonStats(
				43, // HPs
				70, 48, // Attack & Defense
				50, 60, // Spacial Attack & Defense
				38 // Speed
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
				"Cut",
				"Tackle",
				"Strength",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Confuse-Ray",
				"Reflect",
				"Dream-Eater",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Destiny-Bond",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Will-O-Wisp",
				"Facade",
				"Nature-Power",
				"Trick",
				"Role-Play",
				"Ingrain",
				"Magic-Coat",
				"Skill-Swap",
				"Imprison",
				"Grudge",
				"Secret-Power",
				"Astonish",
				"Worry-Seed",
				"Poison-Jab",
				"Dark-Pulse",
				"Seed-Bomb",
				"Energy-Ball",
				"Shadow-Claw",
				"Trick-Room",
				"Grass-Knot",
				"Wood-Hammer",
				"Foul-Play",
				"Round",
				"Bestow",
				"Bulldoze",
				"Horn-Leech",
				"Phantom-Force",
				"Forests-Curse",
				"Confide",
				"Venom-Drench",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}