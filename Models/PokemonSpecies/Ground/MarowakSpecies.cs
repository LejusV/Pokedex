using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Marowak Species to store common natural stats of all Marowaks
	#region MarowakSpecies
	public class MarowakSpecies : PokemonSpecies
	{
#nullable enable
		private static MarowakSpecies? _instance = null;
#nullable restore
        public static MarowakSpecies Instance => _instance ?? (_instance = new MarowakSpecies());

		#region MarowakSpecies Constructor
		public MarowakSpecies() : base(
			105,
			"Marowak",
			Ground.Instance,
			1.0,
			45.0,
			new PokemonStats(
				60, // HPs
				80, 110, // Attack & Defense
				50, 80, // Spacial Attack & Defense
				45 // Speed
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
				"Hyper-Beam",
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
				"Mud-Slap",
				"Icy-Wind",
				"Detect",
				"Bone-Rush",
				"Outrage",
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
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Smack-Down",
				"Round",
				"Echoed-Voice",
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