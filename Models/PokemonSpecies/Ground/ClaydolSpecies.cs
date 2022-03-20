using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Claydol Species to store common natural stats of all Claydols
	#region ClaydolSpecies
	public class ClaydolSpecies : PokemonSpecies
	{
#nullable enable
		private static ClaydolSpecies? _instance = null;
#nullable restore
        public static ClaydolSpecies Instance => _instance ?? (_instance = new ClaydolSpecies());

		#region ClaydolSpecies Constructor
		public ClaydolSpecies() : base(
			344,
			"Claydol",
			Ground.Instance, Psychic.Instance,
			1.5,
			108.0,
			new PokemonStats(
				60, // HPs
				70, 105, // Attack & Defense
				70, 120, // Spacial Attack & Defense
				75 // Speed
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
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Confusion",
				"Psychic",
				"Teleport",
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
				"Rock-Smash",
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
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Stone-Edge",
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