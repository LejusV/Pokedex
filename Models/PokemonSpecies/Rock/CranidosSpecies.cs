using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cranidos Species to store common natural stats of all Cranidoss
	#region CranidosSpecies
	public class CranidosSpecies : PokemonSpecies
	{
#nullable enable
		private static CranidosSpecies? _instance = null;
#nullable restore
        public static CranidosSpecies Instance => _instance ?? (_instance = new CranidosSpecies());

		#region CranidosSpecies Constructor
		public CranidosSpecies() : base(
			408,
			"Cranidos",
			Rock.Instance,
			0.9,
			31.5,
			new PokemonStats(
				67, // HPs
				125, 40, // Attack & Defense
				30, 30, // Spacial Attack & Defense
				58 // Speed
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
				"Fire-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Whirlwind",
				"Slam",
				"Stomp",
				"Headbutt",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Roar",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
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
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Superpower",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Shock-Wave",
				"Hammer-Arm",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Fling",
				"Rock-Polish",
				"Dragon-Pulse",
				"Earth-Power",
				"Zen-Headbutt",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Head-Smash",
				"Smack-Down",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}