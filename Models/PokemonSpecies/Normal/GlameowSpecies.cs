using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Glameow Species to store common natural stats of all Glameows
	#region GlameowSpecies
	public class GlameowSpecies : PokemonSpecies
	{
#nullable enable
		private static GlameowSpecies? _instance = null;
#nullable restore
        public static GlameowSpecies Instance => _instance ?? (_instance = new GlameowSpecies());

		#region GlameowSpecies Constructor
		public GlameowSpecies() : base(
			431,
			"Glameow",
			Normal.Instance,
			0.5,
			3.9,
			new PokemonStats(
				49, // HPs
				55, 42, // Attack & Defense
				42, 37, // Spacial Attack & Defense
				85 // Speed
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
				"Sand-Attack",
				"Headbutt",
				"Tail-Whip",
				"Bite",
				"Growl",
				"Thunderbolt",
				"Thunder",
				"Dig",
				"Toxic",
				"Hypnosis",
				"Quick-Attack",
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
				"Flail",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Endure",
				"Charm",
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
				"Fake-Tears",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Wake-Up-Slap",
				"Natural-Gift",
				"U-Turn",
				"Payback",
				"Assurance",
				"Last-Resort",
				"Sucker-Punch",
				"Shadow-Claw",
				"Captivate",
				"Hone-Claws",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Play-Rough",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}