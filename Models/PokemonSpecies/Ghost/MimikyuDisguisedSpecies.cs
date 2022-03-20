using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mimikyu-Disguised Species to store common natural stats of all Mimikyu-Disguiseds
	#region Mimikyu-DisguisedSpecies
	public class MimikyuDisguisedSpecies : PokemonSpecies
	{
#nullable enable
		private static MimikyuDisguisedSpecies? _instance = null;
#nullable restore
        public static MimikyuDisguisedSpecies Instance => _instance ?? (_instance = new MimikyuDisguisedSpecies());

		#region Mimikyu-DisguisedSpecies Constructor
		public MimikyuDisguisedSpecies() : base(
			778,
			"Mimikyu-Disguised",
			Ghost.Instance, Fairy.Instance,
			0.2,
			0.7,
			new PokemonStats(
				55, // HPs
				90, 80, // Attack & Defense
				50, 105, // Spacial Attack & Defense
				96 // Speed
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
				"Scratch",
				"Swords-Dance",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Dream-Eater",
				"Leech-Life",
				"Splash",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Nightmare",
				"Curse",
				"Protect",
				"Feint-Attack",
				"Destiny-Bond",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Psych-Up",
				"Shadow-Ball",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Grudge",
				"Astonish",
				"Bulk-Up",
				"Payback",
				"Embargo",
				"Fling",
				"Copycat",
				"Dark-Pulse",
				"X-Scissor",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Trick-Room",
				"Charge-Beam",
				"Wood-Hammer",
				"Hone-Claws",
				"Round",
				"Work-Up",
				"Play-Rough",
				"Confide",
				"Dazzling-Gleam",
				"Baby-Doll-Eyes",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}