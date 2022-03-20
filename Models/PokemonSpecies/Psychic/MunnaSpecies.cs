using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Munna Species to store common natural stats of all Munnas
	#region MunnaSpecies
	public class MunnaSpecies : PokemonSpecies
	{
#nullable enable
		private static MunnaSpecies? _instance = null;
#nullable restore
        public static MunnaSpecies Instance => _instance ?? (_instance = new MunnaSpecies());

		#region MunnaSpecies Constructor
		public MunnaSpecies() : base(
			517,
			"Munna",
			Psychic.Instance,
			0.6,
			23.3,
			new PokemonStats(
				76, // HPs
				25, 45, // Attack & Defense
				67, 55, // Spacial Attack & Defense
				24 // Speed
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
				"Sonic-Boom",
				"Psybeam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Defense-Curl",
				"Barrier",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Baton-Pass",
				"Moonlight",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Torment",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Yawn",
				"Skill-Swap",
				"Imprison",
				"Secret-Power",
				"Rock-Tomb",
				"Signal-Beam",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Gyro-Ball",
				"Healing-Wish",
				"Lucky-Chant",
				"Worry-Seed",
				"Energy-Ball",
				"Zen-Headbutt",
				"Trick-Room",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Synchronoise",
				"After-You",
				"Round",
				"Stored-Power",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}