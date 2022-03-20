using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Corsola Species to store common natural stats of all Corsolas
	#region CorsolaSpecies
	public class CorsolaSpecies : PokemonSpecies
	{
#nullable enable
		private static CorsolaSpecies? _instance = null;
#nullable restore
        public static CorsolaSpecies Instance => _instance ?? (_instance = new CorsolaSpecies());

		#region CorsolaSpecies Constructor
		public CorsolaSpecies() : base(
			222,
			"Corsola",
			Water.Instance, Rock.Instance,
			0.6,
			5.0,
			new PokemonStats(
				65, // HPs
				55, 95, // Attack & Defense
				65, 95, // Spacial Attack & Defense
				35 // Speed
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
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Mist",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Psychic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Recover",
				"Harden",
				"Confuse-Ray",
				"Defense-Curl",
				"Barrier",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Self-Destruct",
				"Spike-Cannon",
				"Amnesia",
				"Bubble",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Mirror-Coat",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Magic-Coat",
				"Endeavor",
				"Refresh",
				"Secret-Power",
				"Camouflage",
				"Rock-Tomb",
				"Icicle-Spear",
				"Iron-Defense",
				"Calm-Mind",
				"Rock-Blast",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Lucky-Chant",
				"Sucker-Punch",
				"Aqua-Ring",
				"Rock-Polish",
				"Power-Gem",
				"Earth-Power",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Head-Smash",
				"Round",
				"Scald",
				"Bulldoze",
				"Confide",
				"Liquidation"
			};
		}
		#endregion
	}
	#endregion
}