using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Banette Species to store common natural stats of all Banettes
	#region BanetteSpecies
	public class BanetteSpecies : PokemonSpecies
	{
#nullable enable
		private static BanetteSpecies? _instance = null;
#nullable restore
        public static BanetteSpecies Instance => _instance ?? (_instance = new BanetteSpecies());

		#region BanetteSpecies Constructor
		public BanetteSpecies() : base(
			354,
			"Banette",
			Ghost.Instance,
			1.1,
			12.5,
			new PokemonStats(
				64, // HPs
				115, 65, // Attack & Defense
				83, 63, // Spacial Attack & Defense
				65 // Speed
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Mimic",
				"Screech",
				"Double-Team",
				"Metronome",
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
				"Feint-Attack",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Knock-Off",
				"Skill-Swap",
				"Grudge",
				"Snatch",
				"Secret-Power",
				"Calm-Mind",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Fling",
				"Sucker-Punch",
				"Dark-Pulse",
				"Giga-Impact",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Trick-Room",
				"Captivate",
				"Charge-Beam",
				"Ominous-Wind",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Hex",
				"Phantom-Force",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}