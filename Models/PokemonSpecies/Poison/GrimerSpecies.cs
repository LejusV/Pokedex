using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Grimer Species to store common natural stats of all Grimers
	#region GrimerSpecies
	public class GrimerSpecies : PokemonSpecies
	{
#nullable enable
		private static GrimerSpecies? _instance = null;
#nullable restore
        public static GrimerSpecies Instance => _instance ?? (_instance = new GrimerSpecies());

		#region GrimerSpecies Constructor
		public GrimerSpecies() : base(
			88,
			"Grimer",
			Poison.Instance,
			0.9,
			30.0,
			new PokemonStats(
				80, // HPs
				80, 50, // Attack & Defense
				40, 50, // Spacial Attack & Defense
				25 // Speed
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
				"Haze",
				"Bide",
				"Self-Destruct",
				"Lick",
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
				"Scary-Face",
				"Sludge-Bomb",
				"Mud-Slap",
				"Zap-Cannon",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Mean-Look",
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
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Torment",
				"Memento",
				"Facade",
				"Taunt",
				"Imprison",
				"Secret-Power",
				"Rock-Tomb",
				"Shadow-Punch",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Shadow-Sneak",
				"Mud-Bomb",
				"Gunk-Shot",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Acid-Spray",
				"Round",
				"Incinerate",
				"Belch",
				"Confide",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}