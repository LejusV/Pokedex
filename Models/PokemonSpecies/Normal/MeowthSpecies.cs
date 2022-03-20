using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Meowth Species to store common natural stats of all Meowths
	#region MeowthSpecies
	public class MeowthSpecies : PokemonSpecies
	{
#nullable enable
		private static MeowthSpecies? _instance = null;
#nullable restore
        public static MeowthSpecies Instance => _instance ?? (_instance = new MeowthSpecies());

		#region MeowthSpecies Constructor
		public MeowthSpecies() : base(
			52,
			"Meowth",
			Normal.Instance,
			0.4,
			4.2,
			new PokemonStats(
				40, // HPs
				45, 35, // Attack & Defense
				40, 40, // Spacial Attack & Defense
				90 // Speed
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
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Bite",
				"Growl",
				"Water-Gun",
				"Bubble-Beam",
				"Thunderbolt",
				"Thunder",
				"Dig",
				"Toxic",
				"Hypnosis",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Amnesia",
				"Dream-Eater",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Flail",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Charm",
				"Swagger",
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
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Assist",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Odor-Sleuth",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Feint",
				"U-Turn",
				"Payback",
				"Assurance",
				"Punishment",
				"Last-Resort",
				"Dark-Pulse",
				"Night-Slash",
				"Seed-Bomb",
				"Nasty-Plot",
				"Shadow-Claw",
				"Gunk-Shot",
				"Captivate",
				"Hone-Claws",
				"Foul-Play",
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