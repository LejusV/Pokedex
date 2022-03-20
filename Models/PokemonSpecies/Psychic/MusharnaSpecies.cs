using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Musharna Species to store common natural stats of all Musharnas
	#region MusharnaSpecies
	public class MusharnaSpecies : PokemonSpecies
	{
#nullable enable
		private static MusharnaSpecies? _instance = null;
#nullable restore
        public static MusharnaSpecies Instance => _instance ?? (_instance = new MusharnaSpecies());

		#region MusharnaSpecies Constructor
		public MusharnaSpecies() : base(
			518,
			"Musharna",
			Psychic.Instance,
			1.1,
			60.5,
			new PokemonStats(
				116, // HPs
				55, 85, // Attack & Defense
				107, 95, // Spacial Attack & Defense
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
				"Psybeam",
				"Hyper-Beam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Torment",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Skill-Swap",
				"Secret-Power",
				"Rock-Tomb",
				"Signal-Beam",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Gyro-Ball",
				"Lucky-Chant",
				"Worry-Seed",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Confide",
				"Dazzling-Gleam",
				"Psychic-Terrain"
			};
		}
		#endregion
	}
	#endregion
}