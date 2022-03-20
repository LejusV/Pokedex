using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Misdreavus Species to store common natural stats of all Misdreavuss
	#region MisdreavusSpecies
	public class MisdreavusSpecies : PokemonSpecies
	{
#nullable enable
		private static MisdreavusSpecies? _instance = null;
#nullable restore
        public static MisdreavusSpecies Instance => _instance ?? (_instance = new MisdreavusSpecies());

		#region MisdreavusSpecies Constructor
		public MisdreavusSpecies() : base(
			200,
			"Misdreavus",
			Ghost.Instance,
			0.7,
			1.0,
			new PokemonStats(
				60, // HPs
				60, 60, // Attack & Defense
				85, 85, // Spacial Attack & Defense
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
				"Headbutt",
				"Double-Edge",
				"Growl",
				"Psybeam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
				"Defense-Curl",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Zap-Cannon",
				"Destiny-Bond",
				"Perish-Song",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Torment",
				"Will-O-Wisp",
				"Memento",
				"Facade",
				"Taunt",
				"Trick",
				"Magic-Coat",
				"Skill-Swap",
				"Imprison",
				"Grudge",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Aerial-Ace",
				"Calm-Mind",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Me-First",
				"Sucker-Punch",
				"Dark-Pulse",
				"Power-Gem",
				"Nasty-Plot",
				"Shadow-Sneak",
				"Trick-Room",
				"Captivate",
				"Charge-Beam",
				"Ominous-Wind",
				"Wonder-Room",
				"Telekinesis",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Hex",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}