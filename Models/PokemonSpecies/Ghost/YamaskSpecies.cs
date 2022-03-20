using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Yamask Species to store common natural stats of all Yamasks
	#region YamaskSpecies
	public class YamaskSpecies : PokemonSpecies
	{
#nullable enable
		private static YamaskSpecies? _instance = null;
#nullable restore
        public static YamaskSpecies Instance => _instance ?? (_instance = new YamaskSpecies());

		#region YamaskSpecies Constructor
		public YamaskSpecies() : base(
			562,
			"Yamask",
			Ghost.Instance,
			0.5,
			1.5,
			new PokemonStats(
				38, // HPs
				30, 85, // Attack & Defense
				55, 65, // Spacial Attack & Defense
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
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Destiny-Bond",
				"Endure",
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
				"Memento",
				"Facade",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Knock-Off",
				"Skill-Swap",
				"Imprison",
				"Grudge",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Fake-Tears",
				"Iron-Defense",
				"Block",
				"Calm-Mind",
				"Shock-Wave",
				"Payback",
				"Embargo",
				"Heal-Block",
				"Toxic-Spikes",
				"Dark-Pulse",
				"Energy-Ball",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Trick-Room",
				"Ominous-Wind",
				"Guard-Split",
				"Power-Split",
				"Wonder-Room",
				"Telekinesis",
				"After-You",
				"Round",
				"Ally-Switch",
				"Hex",
				"Crafty-Shield",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}