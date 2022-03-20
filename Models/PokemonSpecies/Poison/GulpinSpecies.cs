using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Gulpin Species to store common natural stats of all Gulpins
	#region GulpinSpecies
	public class GulpinSpecies : PokemonSpecies
	{
#nullable enable
		private static GulpinSpecies? _instance = null;
#nullable restore
        public static GulpinSpecies Instance => _instance ?? (_instance = new GulpinSpecies());

		#region GulpinSpecies Constructor
		public GulpinSpecies() : base(
			316,
			"Gulpin",
			Poison.Instance,
			0.4,
			10.3,
			new PokemonStats(
				70, // HPs
				43, 53, // Attack & Defense
				43, 53, // Spacial Attack & Defense
				40 // Speed
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
				"Counter",
				"Strength",
				"Solar-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Self-Destruct",
				"Smog",
				"Sludge",
				"Amnesia",
				"Dream-Eater",
				"Poison-Gas",
				"Acid-Armor",
				"Explosion",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Destiny-Bond",
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
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Wring-Out",
				"Gastro-Acid",
				"Seed-Bomb",
				"Gunk-Shot",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Acid-Spray",
				"Round",
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