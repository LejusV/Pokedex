using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Chimchar Species to store common natural stats of all Chimchars
	#region ChimcharSpecies
	public class ChimcharSpecies : PokemonSpecies
	{
#nullable enable
		private static ChimcharSpecies? _instance = null;
#nullable restore
        public static ChimcharSpecies Instance => _instance ?? (_instance = new ChimcharSpecies());

		#region ChimcharSpecies Constructor
		public ChimcharSpecies() : base(
			390,
			"Chimchar",
			Fire.Instance,
			0.5,
			6.2,
			new PokemonStats(
				44, // HPs
				58, 44, // Attack & Defense
				58, 44, // Spacial Attack & Defense
				61 // Speed
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
				"Thunder-Punch",
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Double-Kick",
				"Headbutt",
				"Leer",
				"Ember",
				"Flamethrower",
				"Submission",
				"Low-Kick",
				"Counter",
				"Strength",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Double-Team",
				"Focus-Energy",
				"Fire-Blast",
				"Swift",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Fake-Out",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Assist",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Blaze-Kick",
				"Slack-Off",
				"Overheat",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Vacuum-Wave",
				"Nasty-Plot",
				"Shadow-Claw",
				"Rock-Climb",
				"Gunk-Shot",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Quick-Guard",
				"Incinerate",
				"Acrobatics",
				"Fire-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}