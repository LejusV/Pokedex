using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Purugly Species to store common natural stats of all Puruglys
	#region PuruglySpecies
	public class PuruglySpecies : PokemonSpecies
	{
#nullable enable
		private static PuruglySpecies? _instance = null;
#nullable restore
        public static PuruglySpecies Instance => _instance ?? (_instance = new PuruglySpecies());

		#region PuruglySpecies Constructor
		public PuruglySpecies() : base(
			432,
			"Purugly",
			Normal.Instance,
			1.0,
			43.8,
			new PokemonStats(
				71, // HPs
				82, 64, // Attack & Defense
				64, 59, // Spacial Attack & Defense
				112 // Speed
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
				"Cut",
				"Headbutt",
				"Body-Slam",
				"Growl",
				"Roar",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder",
				"Dig",
				"Toxic",
				"Hypnosis",
				"Double-Team",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Super-Fang",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Endure",
				"Charm",
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
				"Psych-Up",
				"Shadow-Ball",
				"Fake-Out",
				"Torment",
				"Facade",
				"Taunt",
				"Assist",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"U-Turn",
				"Payback",
				"Last-Resort",
				"Sucker-Punch",
				"Giga-Impact",
				"Shadow-Claw",
				"Captivate",
				"Hone-Claws",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}