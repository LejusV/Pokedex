using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Snorunt Species to store common natural stats of all Snorunts
	#region SnoruntSpecies
	public class SnoruntSpecies : PokemonSpecies
	{
#nullable enable
		private static SnoruntSpecies? _instance = null;
#nullable restore
        public static SnoruntSpecies Instance => _instance ?? (_instance = new SnoruntSpecies());

		#region SnoruntSpecies Constructor
		public SnoruntSpecies() : base(
			361,
			"Snorunt",
			Ice.Instance,
			0.7,
			16.8,
			new PokemonStats(
				50, // HPs
				50, 50, // Attack & Defense
				50, 50, // Spacial Attack & Defense
				50 // Speed
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
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Disable",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Bide",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Spite",
				"Powder-Snow",
				"Protect",
				"Spikes",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Shadow-Ball",
				"Hail",
				"Facade",
				"Secret-Power",
				"Weather-Ball",
				"Fake-Tears",
				"Block",
				"Water-Pulse",
				"Natural-Gift",
				"Switcheroo",
				"Avalanche",
				"Ice-Shard",
				"Ice-Fang",
				"Captivate",
				"Round",
				"Hex",
				"Frost-Breath",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}