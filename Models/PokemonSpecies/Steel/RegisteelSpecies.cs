using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Registeel Species to store common natural stats of all Registeels
	#region RegisteelSpecies
	public class RegisteelSpecies : PokemonSpecies
	{
#nullable enable
		private static RegisteelSpecies? _instance = null;
#nullable restore
        public static RegisteelSpecies Instance => _instance ?? (_instance = new RegisteelSpecies());

		#region RegisteelSpecies Constructor
		public RegisteelSpecies() : base(
			379,
			"Registeel",
			Steel.Instance,
			1.9,
			205.0,
			new PokemonStats(
				80, // HPs
				75, 150, // Attack & Defense
				75, 150, // Spacial Attack & Defense
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
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
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
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Shock-Wave",
				"Gravity",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Magnet-Rise",
				"Rock-Polish",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Flash-Cannon",
				"Rock-Climb",
				"Iron-Head",
				"Stealth-Rock",
				"Charge-Beam",
				"Hone-Claws",
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