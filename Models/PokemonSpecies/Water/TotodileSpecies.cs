using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Totodile Species to store common natural stats of all Totodiles
	#region TotodileSpecies
	public class TotodileSpecies : PokemonSpecies
	{
#nullable enable
		private static TotodileSpecies? _instance = null;
#nullable restore
        public static TotodileSpecies Instance => _instance ?? (_instance = new TotodileSpecies());

		#region TotodileSpecies Constructor
		public TotodileSpecies() : base(
			158,
			"Totodile",
			Water.Instance,
			0.6,
			9.5,
			new PokemonStats(
				50, // HPs
				65, 64, // Attack & Defense
				44, 48, // Spacial Attack & Defense
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
				"Mega-Punch",
				"Ice-Punch",
				"Scratch",
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Waterfall",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Ancient-Power",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Flatter",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Fake-Tears",
				"Rock-Tomb",
				"Aerial-Ace",
				"Block",
				"Dragon-Claw",
				"Water-Sport",
				"Dragon-Dance",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Aqua-Tail",
				"Shadow-Claw",
				"Ice-Fang",
				"Captivate",
				"Aqua-Jet",
				"Hone-Claws",
				"Round",
				"Chip-Away",
				"Scald",
				"Water-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}