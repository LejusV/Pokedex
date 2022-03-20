using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Duosion Species to store common natural stats of all Duosions
	#region DuosionSpecies
	public class DuosionSpecies : PokemonSpecies
	{
#nullable enable
		private static DuosionSpecies? _instance = null;
#nullable restore
        public static DuosionSpecies Instance => _instance ?? (_instance = new DuosionSpecies());

		#region DuosionSpecies Constructor
		public DuosionSpecies() : base(
			578,
			"Duosion",
			Psychic.Instance,
			0.6,
			8.0,
			new PokemonStats(
				65, // HPs
				40, 50, // Attack & Defense
				125, 60, // Spacial Attack & Defense
				30 // Speed
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
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Endeavor",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Signal-Beam",
				"Iron-Defense",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Gyro-Ball",
				"Embargo",
				"Heal-Block",
				"Energy-Ball",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Trick-Room",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}