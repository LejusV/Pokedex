using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Seel Species to store common natural stats of all Seels
	#region SeelSpecies
	public class SeelSpecies : PokemonSpecies
	{
#nullable enable
		private static SeelSpecies? _instance = null;
#nullable restore
        public static SeelSpecies Instance => _instance ?? (_instance = new SeelSpecies());

		#region SeelSpecies Constructor
		public SeelSpecies() : base(
			86,
			"Seel",
			Water.Instance,
			1.1,
			90.0,
			new PokemonStats(
				65, // HPs
				45, 55, // Attack & Defense
				45, 70, // Spacial Attack & Defense
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
				"Pay-Day",
				"Slam",
				"Headbutt",
				"Horn-Drill",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Disable",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
				"Peck",
				"Strength",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Bide",
				"Lick",
				"Waterfall",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Perish-Song",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Fake-Out",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Icicle-Spear",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Fling",
				"Aqua-Ring",
				"Aqua-Tail",
				"Ice-Shard",
				"Captivate",
				"Aqua-Jet",
				"Entrainment",
				"Round",
				"Echoed-Voice",
				"Drill-Run",
				"Belch",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion
}