using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Stantler Species to store common natural stats of all Stantlers
	#region StantlerSpecies
	public class StantlerSpecies : PokemonSpecies
	{
#nullable enable
		private static StantlerSpecies? _instance = null;
#nullable restore
        public static StantlerSpecies Instance => _instance ?? (_instance = new StantlerSpecies());

		#region StantlerSpecies Constructor
		public StantlerSpecies() : base(
			234,
			"Stantler",
			Normal.Instance,
			1.4,
			71.2,
			new PokemonStats(
				73, // HPs
				95, 62, // Attack & Defense
				85, 65, // Spacial Attack & Defense
				85 // Speed
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
				"Stomp",
				"Double-Kick",
				"Jump-Kick",
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Disable",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Rage",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Megahorn",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Role-Play",
				"Skill-Swap",
				"Imprison",
				"Secret-Power",
				"Mud-Sport",
				"Astonish",
				"Signal-Beam",
				"Extrasensory",
				"Bounce",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Me-First",
				"Last-Resort",
				"Sucker-Punch",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Charge-Beam",
				"Psyshock",
				"Magic-Room",
				"Round",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}