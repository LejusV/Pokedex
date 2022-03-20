using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pupitar Species to store common natural stats of all Pupitars
	#region PupitarSpecies
	public class PupitarSpecies : PokemonSpecies
	{
#nullable enable
		private static PupitarSpecies? _instance = null;
#nullable restore
        public static PupitarSpecies Instance => _instance ?? (_instance = new PupitarSpecies());

		#region PupitarSpecies Constructor
		public PupitarSpecies() : base(
			247,
			"Pupitar",
			Rock.Instance, Ground.Instance,
			1.2,
			152.0,
			new PokemonStats(
				70, // HPs
				84, 70, // Attack & Defense
				65, 70, // Spacial Attack & Defense
				51 // Speed
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
				"Natural-Gift",
				"Payback",
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