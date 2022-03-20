using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Spritzee Species to store common natural stats of all Spritzees
	#region SpritzeeSpecies
	public class SpritzeeSpecies : PokemonSpecies
	{
#nullable enable
		private static SpritzeeSpecies? _instance = null;
#nullable restore
        public static SpritzeeSpecies Instance => _instance ?? (_instance = new SpritzeeSpecies());

		#region SpritzeeSpecies Constructor
		public SpritzeeSpecies() : base(
			682,
			"Spritzee",
			Fairy.Instance,
			0.2,
			0.5,
			new PokemonStats(
				78, // HPs
				52, 60, // Attack & Defense
				63, 65, // Spacial Attack & Defense
				23 // Speed
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
				"Disable",
				"Thunderbolt",
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
				"Wish",
				"Magic-Coat",
				"Endeavor",
				"Skill-Swap",
				"Refresh",
				"Secret-Power",
				"Aromatherapy",
				"Odor-Sleuth",
				"Covet",
				"Calm-Mind",
				"Gyro-Ball",
				"Energy-Ball",
				"Nasty-Plot",
				"Flash-Cannon",
				"Trick-Room",
				"Captivate",
				"Charge-Beam",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Disarming-Voice",
				"Draining-Kiss",
				"Misty-Terrain",
				"Fairy-Wind",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}