using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Swampert Species to store common natural stats of all Swamperts
	#region SwampertSpecies
	public class SwampertSpecies : PokemonSpecies
	{
#nullable enable
		private static SwampertSpecies? _instance = null;
#nullable restore
        public static SwampertSpecies Instance => _instance ?? (_instance = new SwampertSpecies());

		#region SwampertSpecies Constructor
		public SwampertSpecies() : base(
			260,
			"Swampert",
			Water.Instance, Ground.Instance,
			1.5,
			81.9,
			new PokemonStats(
				100, // HPs
				110, 90, // Attack & Defense
				85, 90, // Spacial Attack & Defense
				60 // Speed
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
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Roar",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Bide",
				"Waterfall",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Outrage",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Hydro-Cannon",
				"Rock-Tomb",
				"Muddy-Water",
				"Mud-Shot",
				"Water-Pulse",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Aqua-Tail",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Mud-Bomb",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Sludge-Wave",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Water-Pledge",
				"Bulldoze",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}