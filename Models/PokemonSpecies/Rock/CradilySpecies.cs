using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cradily Species to store common natural stats of all Cradilys
	#region CradilySpecies
	public class CradilySpecies : PokemonSpecies
	{
#nullable enable
		private static CradilySpecies? _instance = null;
#nullable restore
        public static CradilySpecies Instance => _instance ?? (_instance = new CradilySpecies());

		#region CradilySpecies Constructor
		public CradilySpecies() : base(
			346,
			"Cradily",
			Rock.Instance, Grass.Instance,
			1.5,
			60.4,
			new PokemonStats(
				86, // HPs
				81, 97, // Attack & Defense
				81, 107, // Spacial Attack & Defense
				43 // Speed
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Acid",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"String-Shot",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Constrict",
				"Amnesia",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
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
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Ingrain",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Bullet-Seed",
				"Block",
				"Brine",
				"Natural-Gift",
				"Wring-Out",
				"Gastro-Acid",
				"Worry-Seed",
				"Rock-Polish",
				"Seed-Bomb",
				"Energy-Ball",
				"Earth-Power",
				"Giga-Impact",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Smack-Down",
				"Sludge-Wave",
				"Round",
				"Bulldoze",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}