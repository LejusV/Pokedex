using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Solosis Species to store common natural stats of all Solosiss
	#region SolosisSpecies
	public class SolosisSpecies : PokemonSpecies
	{
#nullable enable
		private static SolosisSpecies? _instance = null;
#nullable restore
        public static SolosisSpecies Instance => _instance ?? (_instance = new SolosisSpecies());

		#region SolosisSpecies Constructor
		public SolosisSpecies() : base(
			577,
			"Solosis",
			Psychic.Instance,
			0.3,
			1.0,
			new PokemonStats(
				45, // HPs
				30, 40, // Attack & Defense
				105, 50, // Spacial Attack & Defense
				20 // Speed
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
				"Night-Shade",
				"Double-Team",
				"Recover",
				"Confuse-Ray",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Acid-Armor",
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
				"Imprison",
				"Snatch",
				"Secret-Power",
				"Astonish",
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