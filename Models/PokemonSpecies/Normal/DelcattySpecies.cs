using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Delcatty Species to store common natural stats of all Delcattys
	#region DelcattySpecies
	public class DelcattySpecies : PokemonSpecies
	{
#nullable enable
		private static DelcattySpecies? _instance = null;
#nullable restore
        public static DelcattySpecies Instance => _instance ?? (_instance = new DelcattySpecies());

		#region DelcattySpecies Constructor
		public DelcattySpecies() : base(
			301,
			"Delcatty",
			Normal.Instance,
			1.1,
			32.6,
			new PokemonStats(
				70, // HPs
				65, 65, // Attack & Defense
				55, 55, // Spacial Attack & Defense
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
				"Double-Slap",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Sing",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Fake-Out",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Hyper-Voice",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Payback",
				"Last-Resort",
				"Sucker-Punch",
				"Giga-Impact",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}