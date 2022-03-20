using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cubone Species to store common natural stats of all Cubones
	#region CuboneSpecies
	public class CuboneSpecies : PokemonSpecies
	{
#nullable enable
		private static CuboneSpecies? _instance = null;
#nullable restore
        public static CuboneSpecies Instance => _instance ?? (_instance = new CuboneSpecies());

		#region CuboneSpecies Constructor
		public CuboneSpecies() : base(
			104,
			"Cubone",
			Ground.Instance,
			0.4,
			6.5,
			new PokemonStats(
				50, // HPs
				50, 95, // Attack & Defense
				40, 50, // Spacial Attack & Defense
				35 // Speed
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
				"Fire-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Double-Kick",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Tail-Whip",
				"Leer",
				"Growl",
				"Flamethrower",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Bone-Club",
				"Fire-Blast",
				"Skull-Bash",
				"Bonemerang",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Belly-Drum",
				"Mud-Slap",
				"Perish-Song",
				"Icy-Wind",
				"Detect",
				"Bone-Rush",
				"Sandstorm",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Natural-Gift",
				"Fling",
				"Earth-Power",
				"Rock-Climb",
				"Iron-Head",
				"Captivate",
				"Stealth-Rock",
				"Smack-Down",
				"Round",
				"Echoed-Voice",
				"Chip-Away",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing",
				"Stomping-Tantrum"
			};
		}
		#endregion
	}
	#endregion
}