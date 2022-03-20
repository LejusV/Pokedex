using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sentret Species to store common natural stats of all Sentrets
	#region SentretSpecies
	public class SentretSpecies : PokemonSpecies
	{
#nullable enable
		private static SentretSpecies? _instance = null;
#nullable restore
        public static SentretSpecies Instance => _instance ?? (_instance = new SentretSpecies());

		#region SentretSpecies Constructor
		public SentretSpecies() : base(
			161,
			"Sentret",
			Normal.Instance,
			0.8,
			6.0,
			new PokemonStats(
				35, // HPs
				46, 34, // Attack & Defense
				35, 45, // Spacial Attack & Defense
				20 // Speed
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Scratch",
				"Cut",
				"Slam",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Swift",
				"Amnesia",
				"Fury-Swipes",
				"Rest",
				"Super-Fang",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Baton-Pass",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Whirlpool",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Follow-Me",
				"Helping-Hand",
				"Trick",
				"Assist",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Hyper-Voice",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Me-First",
				"Last-Resort",
				"Sucker-Punch",
				"Aqua-Tail",
				"Shadow-Claw",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}