using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Muk Species to store common natural stats of all Muks
	#region MukSpecies
	public class MukSpecies : PokemonSpecies
	{
#nullable enable
		private static MukSpecies? _instance = null;
#nullable restore
        public static MukSpecies Instance => _instance ?? (_instance = new MukSpecies());

		#region MukSpecies Constructor
		public MukSpecies() : base(
			89,
			"Muk",
			Poison.Instance,
			1.2,
			30.0,
			new PokemonStats(
				105, // HPs
				105, 75, // Attack & Defense
				65, 100, // Spacial Attack & Defense
				50 // Speed
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
				"Pound",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Body-Slam",
				"Disable",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Mega-Drain",
				"Thunderbolt",
				"Thunder",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Harden",
				"Minimize",
				"Bide",
				"Self-Destruct",
				"Sludge",
				"Fire-Blast",
				"Poison-Gas",
				"Acid-Armor",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Zap-Cannon",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Torment",
				"Memento",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Block",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Dark-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Mud-Bomb",
				"Gunk-Shot",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Round",
				"Incinerate",
				"Belch",
				"Confide",
				"Venom-Drench",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}