using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Marshtomp Species to store common natural stats of all Marshtomps
	#region MarshtompSpecies
	public class MarshtompSpecies : PokemonSpecies
	{
#nullable enable
		private static MarshtompSpecies? _instance = null;
#nullable restore
        public static MarshtompSpecies Instance => _instance ?? (_instance = new MarshtompSpecies());

		#region MarshtompSpecies Constructor
		public MarshtompSpecies() : base(
			259,
			"Marshtomp",
			Water.Instance, Ground.Instance,
			0.7,
			28.0,
			new PokemonStats(
				70, // HPs
				85, 70, // Attack & Defense
				60, 70, // Spacial Attack & Defense
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
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
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
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Rock-Tomb",
				"Muddy-Water",
				"Mud-Shot",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Aqua-Tail",
				"Earth-Power",
				"Mud-Bomb",
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