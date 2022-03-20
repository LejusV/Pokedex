using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tyranitar Species to store common natural stats of all Tyranitars
	#region TyranitarSpecies
	public class TyranitarSpecies : PokemonSpecies
	{
#nullable enable
		private static TyranitarSpecies? _instance = null;
#nullable restore
        public static TyranitarSpecies Instance => _instance ?? (_instance = new TyranitarSpecies());

		#region TyranitarSpecies Constructor
		public TyranitarSpecies() : base(
			248,
			"Tyranitar",
			Rock.Instance, Dark.Instance,
			2.0,
			202.0,
			new PokemonStats(
				100, // HPs
				134, 110, // Attack & Defense
				95, 100, // Spacial Attack & Defense
				61 // Speed
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
				"Ice-Punch",
				"Thunder-Punch",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Nightmare",
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
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Dragon-Claw",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Rock-Polish",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Shadow-Claw",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Hone-Claws",
				"Smack-Down",
				"Foul-Play",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Dragon-Tail",
				"Snarl",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}