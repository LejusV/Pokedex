using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Onix Species to store common natural stats of all Onixs
	#region OnixSpecies
	public class OnixSpecies : PokemonSpecies
	{
#nullable enable
		private static OnixSpecies? _instance = null;
#nullable restore
        public static OnixSpecies Instance => _instance ?? (_instance = new OnixSpecies());

		#region OnixSpecies Constructor
		public OnixSpecies() : base(
			95,
			"Onix",
			Rock.Instance, Ground.Instance,
			8.8,
			210.0,
			new PokemonStats(
				35, // HPs
				45, 160, // Attack & Defense
				30, 45, // Spacial Attack & Defense
				70 // Speed
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
				"Bind",
				"Slam",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Roar",
				"Strength",
				"Rock-Throw",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Bide",
				"Self-Destruct",
				"Skull-Bash",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Secret-Power",
				"Mud-Sport",
				"Rock-Tomb",
				"Sand-Tomb",
				"Block",
				"Rock-Blast",
				"Gyro-Ball",
				"Natural-Gift",
				"Payback",
				"Rock-Polish",
				"Dragon-Pulse",
				"Earth-Power",
				"Flash-Cannon",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Wide-Guard",
				"Smack-Down",
				"Heavy-Slam",
				"Round",
				"Bulldoze",
				"Dragon-Tail",
				"Rototiller",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}