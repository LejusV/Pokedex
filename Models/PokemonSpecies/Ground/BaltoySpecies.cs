using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Baltoy Species to store common natural stats of all Baltoys
	#region BaltoySpecies
	public class BaltoySpecies : PokemonSpecies
	{
#nullable enable
		private static BaltoySpecies? _instance = null;
#nullable restore
        public static BaltoySpecies Instance => _instance ?? (_instance = new BaltoySpecies());

		#region BaltoySpecies Constructor
		public BaltoySpecies() : base(
			343,
			"Baltoy",
			Ground.Instance, Psychic.Instance,
			0.5,
			21.5,
			new PokemonStats(
				40, // HPs
				40, 55, // Attack & Defense
				40, 70, // Spacial Attack & Defense
				55 // Speed
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
				"Headbutt",
				"Double-Edge",
				"Ice-Beam",
				"Psybeam",
				"Solar-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Confusion",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Light-Screen",
				"Reflect",
				"Self-Destruct",
				"Dream-Eater",
				"Flash",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Facade",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Imprison",
				"Secret-Power",
				"Rock-Tomb",
				"Cosmic-Power",
				"Signal-Beam",
				"Extrasensory",
				"Calm-Mind",
				"Gravity",
				"Gyro-Ball",
				"Natural-Gift",
				"Heal-Block",
				"Power-Trick",
				"Rock-Polish",
				"Earth-Power",
				"Zen-Headbutt",
				"Trick-Room",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Guard-Split",
				"Power-Split",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Smack-Down",
				"Round",
				"Ally-Switch",
				"Bulldoze",
				"Drill-Run",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}