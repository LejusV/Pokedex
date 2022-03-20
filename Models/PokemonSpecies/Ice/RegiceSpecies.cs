using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Regice Species to store common natural stats of all Regices
	#region RegiceSpecies
	public class RegiceSpecies : PokemonSpecies
	{
#nullable enable
		private static RegiceSpecies? _instance = null;
#nullable restore
        public static RegiceSpecies Instance => _instance ?? (_instance = new RegiceSpecies());

		#region RegiceSpecies Constructor
		public RegiceSpecies() : base(
			378,
			"Regice",
			Ice.Instance,
			1.8,
			175.0,
			new PokemonStats(
				80, // HPs
				50, 100, // Attack & Defense
				100, 200, // Spacial Attack & Defense
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
				"Ice-Punch",
				"Thunder-Punch",
				"Stomp",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Self-Destruct",
				"Amnesia",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Lock-On",
				"Endure",
				"Rollout",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Signal-Beam",
				"Block",
				"Shock-Wave",
				"Gravity",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Rock-Polish",
				"Focus-Blast",
				"Giga-Impact",
				"Avalanche",
				"Flash-Cannon",
				"Rock-Climb",
				"Iron-Head",
				"Charge-Beam",
				"Round",
				"Bulldoze",
				"Frost-Breath",
				"Confide",
				"Power-Up-Punch",
				"Aurora-Veil"
			};
		}
		#endregion
	}
	#endregion
}