using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Liepard Species to store common natural stats of all Liepards
	#region LiepardSpecies
	public class LiepardSpecies : PokemonSpecies
	{
#nullable enable
		private static LiepardSpecies? _instance = null;
#nullable restore
        public static LiepardSpecies Instance => _instance ?? (_instance = new LiepardSpecies());

		#region LiepardSpecies Constructor
		public LiepardSpecies() : base(
			510,
			"Liepard",
			Dark.Instance,
			1.1,
			37.5,
			new PokemonStats(
				64, // HPs
				88, 50, // Attack & Defense
				88, 50, // Spacial Attack & Defense
				106 // Speed
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
				"Growl",
				"Hyper-Beam",
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
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Fake-Out",
				"Torment",
				"Facade",
				"Taunt",
				"Trick",
				"Role-Play",
				"Assist",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Aerial-Ace",
				"Covet",
				"U-Turn",
				"Payback",
				"Assurance",
				"Embargo",
				"Sucker-Punch",
				"Dark-Pulse",
				"Night-Slash",
				"Seed-Bomb",
				"Giga-Impact",
				"Nasty-Plot",
				"Shadow-Claw",
				"Gunk-Shot",
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