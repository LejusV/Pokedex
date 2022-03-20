using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Shuckle Species to store common natural stats of all Shuckles
	#region ShuckleSpecies
	public class ShuckleSpecies : PokemonSpecies
	{
#nullable enable
		private static ShuckleSpecies? _instance = null;
#nullable restore
        public static ShuckleSpecies Instance => _instance ?? (_instance = new ShuckleSpecies());

		#region ShuckleSpecies Constructor
		public ShuckleSpecies() : base(
			213,
			"Shuckle",
			Bug.Instance, Rock.Instance,
			0.6,
			20.5,
			new PokemonStats(
				20, // HPs
				10, 230, // Attack & Defense
				10, 230, // Spacial Attack & Defense
				5 // Speed
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
				"Headbutt",
				"Body-Slam",
				"Wrap",
				"Double-Edge",
				"Acid",
				"Strength",
				"String-Shot",
				"Rock-Throw",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Withdraw",
				"Defense-Curl",
				"Bide",
				"Constrict",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Encore",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Helping-Hand",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Rock-Blast",
				"Gyro-Ball",
				"Natural-Gift",
				"Acupressure",
				"Power-Trick",
				"Gastro-Acid",
				"Rock-Polish",
				"Earth-Power",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Bug-Bite",
				"Guard-Split",
				"Power-Split",
				"Venoshock",
				"Smack-Down",
				"Sludge-Wave",
				"After-You",
				"Round",
				"Shell-Smash",
				"Final-Gambit",
				"Struggle-Bug",
				"Bulldoze",
				"Sticky-Web",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}