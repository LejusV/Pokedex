using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Golduck Species to store common natural stats of all Golducks
	#region GolduckSpecies
	public class GolduckSpecies : PokemonSpecies
	{
#nullable enable
		private static GolduckSpecies? _instance = null;
#nullable restore
        public static GolduckSpecies Instance => _instance ?? (_instance = new GolduckSpecies());

		#region GolduckSpecies Constructor
		public GolduckSpecies() : base(
			55,
			"Golduck",
			Water.Instance,
			1.7,
			76.6,
			new PokemonStats(
				80, // HPs
				82, 78, // Attack & Defense
				95, 80, // Spacial Attack & Defense
				85 // Speed
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
				"Pay-Day",
				"Ice-Punch",
				"Scratch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Disable",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Submission",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Dig",
				"Toxic",
				"Confusion",
				"Psychic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Light-Screen",
				"Bide",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Amnesia",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Role-Play",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Aerial-Ace",
				"Water-Sport",
				"Calm-Mind",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Fling",
				"Me-First",
				"Worry-Seed",
				"Aqua-Tail",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Rock-Climb",
				"Captivate",
				"Aqua-Jet",
				"Hone-Claws",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Soak",
				"Low-Sweep",
				"Round",
				"Scald",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}