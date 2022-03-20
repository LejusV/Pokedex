using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Swalot Species to store common natural stats of all Swalots
	#region SwalotSpecies
	public class SwalotSpecies : PokemonSpecies
	{
#nullable enable
		private static SwalotSpecies? _instance = null;
#nullable restore
        public static SwalotSpecies Instance => _instance ?? (_instance = new SwalotSpecies());

		#region SwalotSpecies Constructor
		public SwalotSpecies() : base(
			317,
			"Swalot",
			Poison.Instance,
			1.7,
			80.0,
			new PokemonStats(
				100, // HPs
				73, 83, // Attack & Defense
				73, 83, // Spacial Attack & Defense
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
				"Pound",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Ice-Beam",
				"Hyper-Beam",
				"Counter",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Self-Destruct",
				"Sludge",
				"Amnesia",
				"Dream-Eater",
				"Poison-Gas",
				"Explosion",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Dynamic-Punch",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Yawn",
				"Snatch",
				"Secret-Power",
				"Bullet-Seed",
				"Block",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Wring-Out",
				"Gastro-Acid",
				"Seed-Bomb",
				"Giga-Impact",
				"Gunk-Shot",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Acid-Spray",
				"Round",
				"Bulldoze",
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