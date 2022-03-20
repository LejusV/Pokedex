using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mismagius Species to store common natural stats of all Mismagiuss
	#region MismagiusSpecies
	public class MismagiusSpecies : PokemonSpecies
	{
#nullable enable
		private static MismagiusSpecies? _instance = null;
#nullable restore
        public static MismagiusSpecies Instance => _instance ?? (_instance = new MismagiusSpecies());

		#region MismagiusSpecies Constructor
		public MismagiusSpecies() : base(
			429,
			"Mismagius",
			Ghost.Instance,
			0.9,
			4.4,
			new PokemonStats(
				60, // HPs
				60, 60, // Attack & Defense
				105, 105, // Spacial Attack & Defense
				105 // Speed
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
				"Growl",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Swagger",
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
				"Facade",
				"Taunt",
				"Trick",
				"Magic-Coat",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Aerial-Ace",
				"Magical-Leaf",
				"Calm-Mind",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Lucky-Chant",
				"Sucker-Punch",
				"Dark-Pulse",
				"Power-Gem",
				"Energy-Ball",
				"Giga-Impact",
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
				"Phantom-Force",
				"Confide",
				"Mystical-Fire",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}