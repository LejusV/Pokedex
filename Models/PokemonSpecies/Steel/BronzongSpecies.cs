using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Bronzong Species to store common natural stats of all Bronzongs
	#region BronzongSpecies
	public class BronzongSpecies : PokemonSpecies
	{
#nullable enable
		private static BronzongSpecies? _instance = null;
#nullable restore
        public static BronzongSpecies Instance => _instance ?? (_instance = new BronzongSpecies());

		#region BronzongSpecies Constructor
		public BronzongSpecies() : base(
			437,
			"Bronzong",
			Steel.Instance, Psychic.Instance,
			1.3,
			187.0,
			new PokemonStats(
				67, // HPs
				89, 116, // Attack & Defense
				79, 116, // Spacial Attack & Defense
				33 // Speed
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
				"Strength",
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
				"Explosion",
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
				"Rock-Smash",
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
				"Block",
				"Calm-Mind",
				"Gravity",
				"Gyro-Ball",
				"Natural-Gift",
				"Payback",
				"Heal-Block",
				"Rock-Polish",
				"Giga-Impact",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Trick-Room",
				"Iron-Head",
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