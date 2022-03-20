using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Yanmega Species to store common natural stats of all Yanmegas
	#region YanmegaSpecies
	public class YanmegaSpecies : PokemonSpecies
	{
#nullable enable
		private static YanmegaSpecies? _instance = null;
#nullable restore
        public static YanmegaSpecies Instance => _instance ?? (_instance = new YanmegaSpecies());

		#region YanmegaSpecies Constructor
		public YanmegaSpecies() : base(
			469,
			"Yanmega",
			Bug.Instance, Flying.Instance,
			1.9,
			51.5,
			new PokemonStats(
				86, // HPs
				76, 86, // Attack & Defense
				116, 56, // Spacial Attack & Defense
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
				"Headbutt",
				"Tackle",
				"Supersonic",
				"Sonic-Boom",
				"Hyper-Beam",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Psychic",
				"Quick-Attack",
				"Screech",
				"Double-Team",
				"Swift",
				"Dream-Eater",
				"Leech-Life",
				"Flash",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Feint",
				"Tailwind",
				"U-Turn",
				"Night-Slash",
				"Air-Slash",
				"Bug-Buzz",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Round",
				"Struggle-Bug",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}