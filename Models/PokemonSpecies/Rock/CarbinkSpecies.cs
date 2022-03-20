using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Carbink Species to store common natural stats of all Carbinks
	#region CarbinkSpecies
	public class CarbinkSpecies : PokemonSpecies
	{
#nullable enable
		private static CarbinkSpecies? _instance = null;
#nullable restore
        public static CarbinkSpecies Instance => _instance ?? (_instance = new CarbinkSpecies());

		#region CarbinkSpecies Constructor
		public CarbinkSpecies() : base(
			703,
			"Carbink",
			Rock.Instance, Fairy.Instance,
			0.3,
			5.7,
			new PokemonStats(
				50, // HPs
				50, 150, // Attack & Defense
				50, 150, // Spacial Attack & Defense
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
				"Magic-Coat",
				"Skill-Swap",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Covet",
				"Calm-Mind",
				"Gravity",
				"Gyro-Ball",
				"Magnet-Rise",
				"Rock-Polish",
				"Power-Gem",
				"Earth-Power",
				"Trick-Room",
				"Stone-Edge",
				"Stealth-Rock",
				"Guard-Split",
				"Wonder-Room",
				"Smack-Down",
				"After-You",
				"Round",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}