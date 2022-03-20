using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Monferno Species to store common natural stats of all Monfernos
	#region MonfernoSpecies
	public class MonfernoSpecies : PokemonSpecies
	{
#nullable enable
		private static MonfernoSpecies? _instance = null;
#nullable restore
        public static MonfernoSpecies Instance => _instance ?? (_instance = new MonfernoSpecies());

		#region MonfernoSpecies Constructor
		public MonfernoSpecies() : base(
			391,
			"Monferno",
			Fire.Instance, Fighting.Instance,
			0.9,
			22.0,
			new PokemonStats(
				64, // HPs
				78, 52, // Attack & Defense
				78, 52, // Spacial Attack & Defense
				81 // Speed
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
				"Headbutt",
				"Leer",
				"Ember",
				"Flamethrower",
				"Low-Kick",
				"Strength",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Swift",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Protect",
				"Mach-Punch",
				"Mud-Slap",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Slack-Off",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Natural-Gift",
				"Feint",
				"U-Turn",
				"Close-Combat",
				"Fling",
				"Flare-Blitz",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
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
				"Incinerate",
				"Acrobatics",
				"Retaliate",
				"Fire-Pledge",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}