using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Bronzor Species to store common natural stats of all Bronzors
	#region BronzorSpecies
	public class BronzorSpecies : PokemonSpecies
	{
#nullable enable
		private static BronzorSpecies? _instance = null;
#nullable restore
        public static BronzorSpecies Instance => _instance ?? (_instance = new BronzorSpecies());

		#region BronzorSpecies Constructor
		public BronzorSpecies() : base(
			436,
			"Bronzor",
			Steel.Instance, Psychic.Instance,
			0.5,
			60.5,
			new PokemonStats(
				57, // HPs
				24, 86, // Attack & Defense
				24, 86, // Spacial Attack & Defense
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
				"Tackle",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Future-Sight",
				"Facade",
				"Trick",
				"Recycle",
				"Skill-Swap",
				"Imprison",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Signal-Beam",
				"Extrasensory",
				"Iron-Defense",
				"Calm-Mind",
				"Gravity",
				"Gyro-Ball",
				"Natural-Gift",
				"Payback",
				"Heal-Block",
				"Rock-Polish",
				"Flash-Cannon",
				"Trick-Room",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Heavy-Slam",
				"Round",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}