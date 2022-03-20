using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Steelix Species to store common natural stats of all Steelixs
	#region SteelixSpecies
	public class SteelixSpecies : PokemonSpecies
	{
#nullable enable
		private static SteelixSpecies? _instance = null;
#nullable restore
        public static SteelixSpecies Instance => _instance ?? (_instance = new SteelixSpecies());

		#region SteelixSpecies Constructor
		public SteelixSpecies() : base(
			208,
			"Steelix",
			Steel.Instance, Ground.Instance,
			9.2,
			400.0,
			new PokemonStats(
				75, // HPs
				85, 200, // Attack & Defense
				55, 65, // Spacial Attack & Defense
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
				"Cut",
				"Bind",
				"Slam",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Rock-Throw",
				"Earthquake",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Self-Destruct",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
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
				"Crunch",
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
				"Block",
				"Gyro-Ball",
				"Natural-Gift",
				"Payback",
				"Magnet-Rise",
				"Rock-Polish",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Earth-Power",
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Flash-Cannon",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Autotomize",
				"Smack-Down",
				"Round",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}