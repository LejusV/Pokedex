using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cofagrigus Species to store common natural stats of all Cofagriguss
	#region CofagrigusSpecies
	public class CofagrigusSpecies : PokemonSpecies
	{
#nullable enable
		private static CofagrigusSpecies? _instance = null;
#nullable restore
        public static CofagrigusSpecies Instance => _instance ?? (_instance = new CofagrigusSpecies());

		#region CofagrigusSpecies Constructor
		public CofagrigusSpecies() : base(
			563,
			"Cofagrigus",
			Ghost.Instance,
			1.7,
			76.5,
			new PokemonStats(
				58, // HPs
				50, 145, // Attack & Defense
				95, 105, // Spacial Attack & Defense
				30 // Speed
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
				"Hyper-Beam",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Double-Team",
				"Haze",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Scary-Face",
				"Destiny-Bond",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Will-O-Wisp",
				"Facade",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Knock-Off",
				"Skill-Swap",
				"Grudge",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Iron-Defense",
				"Block",
				"Calm-Mind",
				"Shock-Wave",
				"Payback",
				"Embargo",
				"Dark-Pulse",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Grass-Knot",
				"Ominous-Wind",
				"Guard-Split",
				"Power-Split",
				"Wonder-Room",
				"Telekinesis",
				"After-You",
				"Round",
				"Hex",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}