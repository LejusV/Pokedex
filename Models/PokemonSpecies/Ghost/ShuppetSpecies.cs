using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Shuppet Species to store common natural stats of all Shuppets
	#region ShuppetSpecies
	public class ShuppetSpecies : PokemonSpecies
	{
#nullable enable
		private static ShuppetSpecies? _instance = null;
#nullable restore
        public static ShuppetSpecies Instance => _instance ?? (_instance = new ShuppetSpecies());

		#region ShuppetSpecies Constructor
		public ShuppetSpecies() : base(
			353,
			"Shuppet",
			Ghost.Instance,
			0.6,
			2.3,
			new PokemonStats(
				44, // HPs
				75, 35, // Attack & Defense
				63, 33, // Spacial Attack & Defense
				45 // Speed
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
				"Disable",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Mimic",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
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
				"Foresight",
				"Destiny-Bond",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Pursuit",
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
				"Imprison",
				"Grudge",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Calm-Mind",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Sucker-Punch",
				"Dark-Pulse",
				"Shadow-Sneak",
				"Trick-Room",
				"Gunk-Shot",
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
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}