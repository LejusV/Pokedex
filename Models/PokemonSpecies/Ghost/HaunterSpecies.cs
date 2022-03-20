using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Haunter Species to store common natural stats of all Haunters
	#region HaunterSpecies
	public class HaunterSpecies : PokemonSpecies
	{
#nullable enable
		private static HaunterSpecies? _instance = null;
#nullable restore
        public static HaunterSpecies Instance => _instance ?? (_instance = new HaunterSpecies());

		#region HaunterSpecies Constructor
		public HaunterSpecies() : base(
			93,
			"Haunter",
			Ghost.Instance, Poison.Instance,
			1.6,
			0.1,
			new PokemonStats(
				45, // HPs
				50, 45, // Attack & Defense
				115, 55, // Spacial Attack & Defense
				95 // Speed
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Drain",
				"Thunderbolt",
				"Thunder",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Rage",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Bide",
				"Self-Destruct",
				"Lick",
				"Dream-Eater",
				"Psywave",
				"Explosion",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Zap-Cannon",
				"Destiny-Bond",
				"Icy-Wind",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Trick",
				"Knock-Off",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Shadow-Punch",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Fling",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"Energy-Ball",
				"Shadow-Claw",
				"Trick-Room",
				"Captivate",
				"Ominous-Wind",
				"Wonder-Room",
				"Venoshock",
				"Telekinesis",
				"Foul-Play",
				"Round",
				"Hex",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}