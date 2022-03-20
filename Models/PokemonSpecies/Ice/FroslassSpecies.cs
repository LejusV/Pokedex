using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Froslass Species to store common natural stats of all Froslasss
	#region FroslassSpecies
	public class FroslassSpecies : PokemonSpecies
	{
#nullable enable
		private static FroslassSpecies? _instance = null;
#nullable restore
        public static FroslassSpecies Instance => _instance ?? (_instance = new FroslassSpecies());

		#region FroslassSpecies Constructor
		public FroslassSpecies() : base(
			478,
			"Froslass",
			Ice.Instance, Ghost.Instance,
			1.3,
			26.6,
			new PokemonStats(
				70, // HPs
				80, 70, // Attack & Defense
				80, 70, // Spacial Attack & Defense
				110 // Speed
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
				"Ice-Punch",
				"Headbutt",
				"Leer",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Spite",
				"Powder-Snow",
				"Protect",
				"Mud-Slap",
				"Destiny-Bond",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
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
				"Hail",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Trick",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Signal-Beam",
				"Block",
				"Shock-Wave",
				"Water-Pulse",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Fling",
				"Sucker-Punch",
				"Giga-Impact",
				"Avalanche",
				"Ice-Shard",
				"Captivate",
				"Ominous-Wind",
				"Telekinesis",
				"Round",
				"Frost-Breath",
				"Draining-Kiss",
				"Confide",
				"Aurora-Veil"
			};
		}
		#endregion
	}
	#endregion
}