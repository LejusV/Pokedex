using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Purrloin Species to store common natural stats of all Purrloins
	#region PurrloinSpecies
	public class PurrloinSpecies : PokemonSpecies
	{
#nullable enable
		private static PurrloinSpecies? _instance = null;
#nullable restore
        public static PurrloinSpecies Instance => _instance ?? (_instance = new PurrloinSpecies());

		#region PurrloinSpecies Constructor
		public PurrloinSpecies() : base(
			509,
			"Purrloin",
			Dark.Instance,
			0.4,
			10.1,
			new PokemonStats(
				41, // HPs
				50, 37, // Attack & Defense
				50, 37, // Spacial Attack & Defense
				66 // Speed
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
				"Pay-Day",
				"Scratch",
				"Cut",
				"Sand-Attack",
				"Growl",
				"Thunder-Wave",
				"Toxic",
				"Double-Team",
				"Dream-Eater",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Pursuit",
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
				"Trick",
				"Role-Play",
				"Assist",
				"Yawn",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Aerial-Ace",
				"Covet",
				"U-Turn",
				"Payback",
				"Assurance",
				"Embargo",
				"Copycat",
				"Sucker-Punch",
				"Dark-Pulse",
				"Night-Slash",
				"Seed-Bomb",
				"Nasty-Plot",
				"Shadow-Claw",
				"Gunk-Shot",
				"Captivate",
				"Grass-Knot",
				"Hone-Claws",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Snarl",
				"Play-Rough",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}