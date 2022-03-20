using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Probopass Species to store common natural stats of all Probopasss
	#region ProbopassSpecies
	public class ProbopassSpecies : PokemonSpecies
	{
#nullable enable
		private static ProbopassSpecies? _instance = null;
#nullable restore
        public static ProbopassSpecies Instance => _instance ?? (_instance = new ProbopassSpecies());

		#region ProbopassSpecies Constructor
		public ProbopassSpecies() : base(
			476,
			"Probopass",
			Rock.Instance, Steel.Instance,
			1.4,
			340.0,
			new PokemonStats(
				60, // HPs
				55, 145, // Attack & Defense
				75, 150, // Spacial Attack & Defense
				40 // Speed
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
				"Headbutt",
				"Tackle",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Tri-Attack",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Lock-On",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Taunt",
				"Magic-Coat",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Block",
				"Rock-Blast",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Magnet-Rise",
				"Rock-Polish",
				"Power-Gem",
				"Earth-Power",
				"Giga-Impact",
				"Flash-Cannon",
				"Discharge",
				"Iron-Head",
				"Magnet-Bomb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Wide-Guard",
				"Smack-Down",
				"Round",
				"Volt-Switch",
				"Bulldoze",
				"Confide",
				"Magnetic-Flux",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}