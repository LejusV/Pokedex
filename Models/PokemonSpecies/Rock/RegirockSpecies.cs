using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Regirock Species to store common natural stats of all Regirocks
	#region RegirockSpecies
	public class RegirockSpecies : PokemonSpecies
	{
#nullable enable
		private static RegirockSpecies? _instance = null;
#nullable restore
        public static RegirockSpecies Instance => _instance ?? (_instance = new RegirockSpecies());

		#region RegirockSpecies Constructor
		public RegirockSpecies() : base(
			377,
			"Regirock",
			Rock.Instance,
			1.7,
			230.0,
			new PokemonStats(
				80, // HPs
				100, 200, // Attack & Defense
				50, 100, // Spacial Attack & Defense
				50 // Speed
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
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Stomp",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Rock-Throw",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
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
				"Zap-Cannon",
				"Lock-On",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Block",
				"Shock-Wave",
				"Gravity",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Rock-Polish",
				"Drain-Punch",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Charge-Beam",
				"Smack-Down",
				"Round",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}