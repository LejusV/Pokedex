using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Shieldon Species to store common natural stats of all Shieldons
	#region ShieldonSpecies
	public class ShieldonSpecies : PokemonSpecies
	{
#nullable enable
		private static ShieldonSpecies? _instance = null;
#nullable restore
        public static ShieldonSpecies Instance => _instance ?? (_instance = new ShieldonSpecies());

		#region ShieldonSpecies Constructor
		public ShieldonSpecies() : base(
			410,
			"Shieldon",
			Rock.Instance, Steel.Instance,
			0.5,
			57.0,
			new PokemonStats(
				30, // HPs
				42, 118, // Attack & Defense
				42, 88, // Spacial Attack & Defense
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
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Roar",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Counter",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
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
				"Ancient-Power",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Iron-Defense",
				"Rock-Blast",
				"Shock-Wave",
				"Natural-Gift",
				"Metal-Burst",
				"Magnet-Rise",
				"Rock-Polish",
				"Earth-Power",
				"Flash-Cannon",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Wide-Guard",
				"Guard-Split",
				"Smack-Down",
				"Heavy-Slam",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}