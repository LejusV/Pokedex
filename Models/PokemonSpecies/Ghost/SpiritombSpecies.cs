using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Spiritomb Species to store common natural stats of all Spiritombs
	#region SpiritombSpecies
	public class SpiritombSpecies : PokemonSpecies
	{
#nullable enable
		private static SpiritombSpecies? _instance = null;
#nullable restore
        public static SpiritombSpecies Instance => _instance ?? (_instance = new SpiritombSpecies());

		#region SpiritombSpecies Constructor
		public SpiritombSpecies() : base(
			442,
			"Spiritomb",
			Ghost.Instance, Dark.Instance,
			1.0,
			108.0,
			new PokemonStats(
				50, // HPs
				92, 108, // Attack & Defense
				92, 108, // Spacial Attack & Defense
				35 // Speed
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
				"Hypnosis",
				"Double-Team",
				"Smokescreen",
				"Confuse-Ray",
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
				"Feint-Attack",
				"Destiny-Bond",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Torment",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Taunt",
				"Trick",
				"Imprison",
				"Grudge",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Silver-Wind",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Embargo",
				"Sucker-Punch",
				"Dark-Pulse",
				"Giga-Impact",
				"Nasty-Plot",
				"Shadow-Sneak",
				"Captivate",
				"Ominous-Wind",
				"Wonder-Room",
				"Telekinesis",
				"Foul-Play",
				"Round",
				"Quash",
				"Retaliate",
				"Snarl",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}