using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Reuniclus Species to store common natural stats of all Reunicluss
	#region ReuniclusSpecies
	public class ReuniclusSpecies : PokemonSpecies
	{
#nullable enable
		private static ReuniclusSpecies? _instance = null;
#nullable restore
        public static ReuniclusSpecies Instance => _instance ?? (_instance = new ReuniclusSpecies());

		#region ReuniclusSpecies Constructor
		public ReuniclusSpecies() : base(
			579,
			"Reuniclus",
			Psychic.Instance,
			1.0,
			20.1,
			new PokemonStats(
				110, // HPs
				65, 75, // Attack & Defense
				125, 85, // Spacial Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Hyper-Beam",
				"Strength",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Dizzy-Punch",
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
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Superpower",
				"Magic-Coat",
				"Knock-Off",
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
				"Fling",
				"Heal-Block",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Trick-Room",
				"Grass-Knot",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Confide",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}