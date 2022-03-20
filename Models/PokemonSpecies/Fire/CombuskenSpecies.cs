using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Combusken Species to store common natural stats of all Combuskens
	#region CombuskenSpecies
	public class CombuskenSpecies : PokemonSpecies
	{
#nullable enable
		private static CombuskenSpecies? _instance = null;
#nullable restore
        public static CombuskenSpecies Instance => _instance ?? (_instance = new CombuskenSpecies());

		#region CombuskenSpecies Constructor
		public CombuskenSpecies() : base(
			256,
			"Combusken",
			Fire.Instance, Fighting.Instance,
			0.9,
			19.5,
			new PokemonStats(
				60, // HPs
				85, 60, // Attack & Defense
				85, 60, // Spacial Attack & Defense
				55 // Speed
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
				"Mega-Punch",
				"Fire-Punch",
				"Thunder-Punch",
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Double-Kick",
				"Mega-Kick",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Ember",
				"Flamethrower",
				"Peck",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Mirror-Move",
				"Fire-Blast",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Sky-Uppercut",
				"Aerial-Ace",
				"Bulk-Up",
				"Bounce",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Flare-Blitz",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
				"Shadow-Claw",
				"Captivate",
				"Hone-Claws",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Echoed-Voice",
				"Incinerate",
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