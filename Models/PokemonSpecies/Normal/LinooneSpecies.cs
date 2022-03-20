using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Linoone Species to store common natural stats of all Linoones
	#region LinooneSpecies
	public class LinooneSpecies : PokemonSpecies
	{
#nullable enable
		private static LinooneSpecies? _instance = null;
#nullable restore
        public static LinooneSpecies Instance => _instance ?? (_instance = new LinooneSpecies());

		#region LinooneSpecies Constructor
		public LinooneSpecies() : base(
			264,
			"Linoone",
			Normal.Instance,
			0.5,
			32.5,
			new PokemonStats(
				78, // HPs
				70, 61, // Attack & Defense
				50, 61, // Spacial Attack & Defense
				100 // Speed
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
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Growl",
				"Roar",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Swift",
				"Fury-Swipes",
				"Rest",
				"Super-Fang",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Belly-Drum",
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
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Secret-Power",
				"Mud-Sport",
				"Hyper-Voice",
				"Odor-Sleuth",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Seed-Bomb",
				"Switcheroo",
				"Giga-Impact",
				"Shadow-Claw",
				"Gunk-Shot",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Bestow",
				"Work-Up",
				"Rototiller",
				"Play-Rough",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}