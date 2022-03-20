using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Larvitar Species to store common natural stats of all Larvitars
	#region LarvitarSpecies
	public class LarvitarSpecies : PokemonSpecies
	{
#nullable enable
		private static LarvitarSpecies? _instance = null;
#nullable restore
        public static LarvitarSpecies Instance => _instance ?? (_instance = new LarvitarSpecies());

		#region LarvitarSpecies Constructor
		public LarvitarSpecies() : base(
			246,
			"Larvitar",
			Rock.Instance, Ground.Instance,
			0.6,
			72.0,
			new PokemonStats(
				50, // HPs
				64, 50, // Attack & Defense
				45, 50, // Spacial Attack & Defense
				41 // Speed
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
				"Stomp",
				"Headbutt",
				"Body-Slam",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Hyper-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Detect",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Dragon-Dance",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Rock-Polish",
				"Dark-Pulse",
				"Earth-Power",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Smack-Down",
				"Round",
				"Chip-Away",
				"Retaliate",
				"Bulldoze",
				"Snarl",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}