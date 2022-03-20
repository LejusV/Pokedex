using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Minior-Red-Meteor Species to store common natural stats of all Minior-Red-Meteors
	#region Minior-Red-MeteorSpecies
	public class MiniorRedMeteorSpecies : PokemonSpecies
	{
#nullable enable
		private static MiniorRedMeteorSpecies? _instance = null;
#nullable restore
        public static MiniorRedMeteorSpecies Instance => _instance ?? (_instance = new MiniorRedMeteorSpecies());

		#region Minior-Red-MeteorSpecies Constructor
		public MiniorRedMeteorSpecies() : base(
			774,
			"Minior-Red-Meteor",
			Rock.Instance, Flying.Instance,
			0.3,
			40.0,
			new PokemonStats(
				60, // HPs
				60, 100, // Attack & Defense
				60, 100, // Spacial Attack & Defense
				60 // Speed
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
				"Take-Down",
				"Double-Edge",
				"Hyper-Beam",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Confuse-Ray",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Self-Destruct",
				"Swift",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Sandstorm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Psych-Up",
				"Ancient-Power",
				"Facade",
				"Rock-Tomb",
				"Cosmic-Power",
				"Calm-Mind",
				"Gyro-Ball",
				"U-Turn",
				"Rock-Polish",
				"Power-Gem",
				"Giga-Impact",
				"Stone-Edge",
				"Stealth-Rock",
				"Charge-Beam",
				"Autotomize",
				"Round",
				"Shell-Smash",
				"Acrobatics",
				"Bulldoze",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}