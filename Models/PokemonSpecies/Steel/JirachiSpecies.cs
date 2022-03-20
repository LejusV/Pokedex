using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Jirachi Species to store common natural stats of all Jirachis
	#region JirachiSpecies
	public class JirachiSpecies : PokemonSpecies
	{
#nullable enable
		private static JirachiSpecies? _instance = null;
#nullable restore
        public static JirachiSpecies Instance => _instance ?? (_instance = new JirachiSpecies());

		#region JirachiSpecies Constructor
		public JirachiSpecies() : base(
			385,
			"Jirachi",
			Steel.Instance, Psychic.Instance,
			0.3,
			1.1,
			new PokemonStats(
				100, // HPs
				100, 100, // Attack & Defense
				100, 100, // Spacial Attack & Defense
				100 // Speed
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Confusion",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Metronome",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Future-Sight",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Wish",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Refresh",
				"Secret-Power",
				"Cosmic-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Iron-Defense",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Doom-Desire",
				"Gravity",
				"Healing-Wish",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Lucky-Chant",
				"Last-Resort",
				"Drain-Punch",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Trick-Room",
				"Iron-Head",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Round",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}