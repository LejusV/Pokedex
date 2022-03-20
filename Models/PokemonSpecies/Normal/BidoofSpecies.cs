using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Bidoof Species to store common natural stats of all Bidoofs
	#region BidoofSpecies
	public class BidoofSpecies : PokemonSpecies
	{
#nullable enable
		private static BidoofSpecies? _instance = null;
#nullable restore
        public static BidoofSpecies Instance => _instance ?? (_instance = new BidoofSpecies());

		#region BidoofSpecies Constructor
		public BidoofSpecies() : base(
			399,
			"Bidoof",
			Normal.Instance,
			0.5,
			20.0,
			new PokemonStats(
				59, // HPs
				45, 40, // Attack & Defense
				35, 40, // Spacial Attack & Defense
				31 // Speed
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
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Ice-Beam",
				"Blizzard",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Defense-Curl",
				"Swift",
				"Skull-Bash",
				"Amnesia",
				"Fury-Swipes",
				"Rest",
				"Hyper-Fang",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Taunt",
				"Superpower",
				"Yawn",
				"Secret-Power",
				"Mud-Sport",
				"Odor-Sleuth",
				"Covet",
				"Water-Sport",
				"Shock-Wave",
				"Natural-Gift",
				"Pluck",
				"Last-Resort",
				"Aqua-Tail",
				"Rock-Climb",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}