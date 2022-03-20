using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Diancie Species to store common natural stats of all Diancies
	#region DiancieSpecies
	public class DiancieSpecies : PokemonSpecies
	{
#nullable enable
		private static DiancieSpecies? _instance = null;
#nullable restore
        public static DiancieSpecies Instance => _instance ?? (_instance = new DiancieSpecies());

		#region DiancieSpecies Constructor
		public DiancieSpecies() : base(
			719,
			"Diancie",
			Rock.Instance, Fairy.Instance,
			0.7,
			8.8,
			new PokemonStats(
				50, // HPs
				100, 150, // Attack & Defense
				100, 150, // Spacial Attack & Defense
				50 // Speed
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
				"Tackle",
				"Hyper-Beam",
				"Rock-Throw",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Harden",
				"Light-Screen",
				"Reflect",
				"Flash",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Sharpen",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sandstorm",
				"Swagger",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Hail",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Endeavor",
				"Skill-Swap",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Covet",
				"Calm-Mind",
				"Gravity",
				"Gyro-Ball",
				"Last-Resort",
				"Magnet-Rise",
				"Rock-Polish",
				"Power-Gem",
				"Earth-Power",
				"Giga-Impact",
				"Trick-Room",
				"Stone-Edge",
				"Stealth-Rock",
				"Guard-Split",
				"Wonder-Room",
				"Psyshock",
				"Smack-Down",
				"After-You",
				"Round",
				"Moonblast",
				"Confide",
				"Diamond-Storm",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}