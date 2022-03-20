using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Psyduck Species to store common natural stats of all Psyducks
	#region PsyduckSpecies
	public class PsyduckSpecies : PokemonSpecies
	{
#nullable enable
		private static PsyduckSpecies? _instance = null;
#nullable restore
        public static PsyduckSpecies Instance => _instance ?? (_instance = new PsyduckSpecies());

		#region PsyduckSpecies Constructor
		public PsyduckSpecies() : base(
			54,
			"Psyduck",
			Water.Instance,
			0.8,
			19.6,
			new PokemonStats(
				50, // HPs
				52, 48, // Attack & Defense
				65, 50, // Spacial Attack & Defense
				55 // Speed
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
				"Psybeam",
				"Bubble-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Dig",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
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
				"Foresight",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Cross-Chop",
				"Rain-Dance",
				"Psych-Up",
				"Future-Sight",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Role-Play",
				"Brick-Break",
				"Yawn",
				"Refresh",
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
				"Worry-Seed",
				"Aqua-Tail",
				"Shadow-Claw",
				"Mud-Bomb",
				"Zen-Headbutt",
				"Captivate",
				"Hone-Claws",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Synchronoise",
				"Soak",
				"Simple-Beam",
				"Round",
				"Clear-Smog",
				"Scald",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}