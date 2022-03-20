using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Trevenant Species to store common natural stats of all Trevenants
	#region TrevenantSpecies
	public class TrevenantSpecies : PokemonSpecies
	{
#nullable enable
		private static TrevenantSpecies? _instance = null;
#nullable restore
        public static TrevenantSpecies Instance => _instance ?? (_instance = new TrevenantSpecies());

		#region TrevenantSpecies Constructor
		public TrevenantSpecies() : base(
			709,
			"Trevenant",
			Ghost.Instance, Grass.Instance,
			1.5,
			71.0,
			new PokemonStats(
				85, // HPs
				110, 76, // Attack & Defense
				65, 82, // Spacial Attack & Defense
				56 // Speed
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
				"Hyper-Beam",
				"Strength",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Earthquake",
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
				"Secret-Power",
				"Astonish",
				"Block",
				"Calm-Mind",
				"Worry-Seed",
				"Poison-Jab",
				"Dark-Pulse",
				"Seed-Bomb",
				"X-Scissor",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Trick-Room",
				"Grass-Knot",
				"Wood-Hammer",
				"Hone-Claws",
				"Foul-Play",
				"Round",
				"Bulldoze",
				"Horn-Leech",
				"Phantom-Force",
				"Forests-Curse",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}