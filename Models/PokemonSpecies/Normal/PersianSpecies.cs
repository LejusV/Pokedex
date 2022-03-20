using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Persian Species to store common natural stats of all Persians
	#region PersianSpecies
	public class PersianSpecies : PokemonSpecies
	{
#nullable enable
		private static PersianSpecies? _instance = null;
#nullable restore
        public static PersianSpecies Instance => _instance ?? (_instance = new PersianSpecies());

		#region PersianSpecies Constructor
		public PersianSpecies() : base(
			53,
			"Persian",
			Normal.Instance,
			1.0,
			32.0,
			new PokemonStats(
				65, // HPs
				70, 60, // Attack & Defense
				65, 65, // Spacial Attack & Defense
				115 // Speed
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
				"Bite",
				"Growl",
				"Roar",
				"Water-Gun",
				"Bubble-Beam",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Swift",
				"Skull-Bash",
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
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Detect",
				"Endure",
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
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Feint",
				"U-Turn",
				"Payback",
				"Assurance",
				"Embargo",
				"Last-Resort",
				"Dark-Pulse",
				"Night-Slash",
				"Seed-Bomb",
				"Power-Gem",
				"Switcheroo",
				"Giga-Impact",
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
				"Play-Rough",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}