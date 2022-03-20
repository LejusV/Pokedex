using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Lileep Species to store common natural stats of all Lileeps
	#region LileepSpecies
	public class LileepSpecies : PokemonSpecies
	{
#nullable enable
		private static LileepSpecies? _instance = null;
#nullable restore
        public static LileepSpecies Instance => _instance ?? (_instance = new LileepSpecies());

		#region LileepSpecies Constructor
		public LileepSpecies() : base(
			345,
			"Lileep",
			Rock.Instance, Grass.Instance,
			1.0,
			23.8,
			new PokemonStats(
				66, // HPs
				41, 77, // Attack & Defense
				61, 87, // Spacial Attack & Defense
				23 // Speed
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
				"Swords-Dance",
				"Bind",
				"Body-Slam",
				"Double-Edge",
				"Acid",
				"Mega-Drain",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Recover",
				"Confuse-Ray",
				"Barrier",
				"Constrict",
				"Amnesia",
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
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Mirror-Coat",
				"Psych-Up",
				"Ancient-Power",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Ingrain",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Tickle",
				"Bullet-Seed",
				"Brine",
				"Natural-Gift",
				"Wring-Out",
				"Gastro-Acid",
				"Worry-Seed",
				"Rock-Polish",
				"Seed-Bomb",
				"Energy-Ball",
				"Earth-Power",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Smack-Down",
				"Round",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}