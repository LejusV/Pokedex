using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Aromatisse Species to store common natural stats of all Aromatisses
	#region AromatisseSpecies
	public class AromatisseSpecies : PokemonSpecies
	{
#nullable enable
		private static AromatisseSpecies? _instance = null;
#nullable restore
        public static AromatisseSpecies Instance => _instance ?? (_instance = new AromatisseSpecies());

		#region AromatisseSpecies Constructor
		public AromatisseSpecies() : base(
			683,
			"Aromatisse",
			Fairy.Instance,
			0.8,
			15.5,
			new PokemonStats(
				101, // HPs
				72, 72, // Attack & Defense
				99, 89, // Spacial Attack & Defense
				29 // Speed
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
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sweet-Kiss",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Torment",
				"Facade",
				"Helping-Hand",
				"Magic-Coat",
				"Endeavor",
				"Skill-Swap",
				"Secret-Power",
				"Aromatherapy",
				"Odor-Sleuth",
				"Covet",
				"Calm-Mind",
				"Gyro-Ball",
				"Drain-Punch",
				"Energy-Ball",
				"Giga-Impact",
				"Flash-Cannon",
				"Trick-Room",
				"Charge-Beam",
				"Psyshock",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Heal-Pulse",
				"Disarming-Voice",
				"Draining-Kiss",
				"Misty-Terrain",
				"Fairy-Wind",
				"Moonblast",
				"Confide",
				"Aromatic-Mist",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}