using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dewgong Species to store common natural stats of all Dewgongs
	#region DewgongSpecies
	public class DewgongSpecies : PokemonSpecies
	{
#nullable enable
		private static DewgongSpecies? _instance = null;
#nullable restore
        public static DewgongSpecies Instance => _instance ?? (_instance = new DewgongSpecies());

		#region DewgongSpecies Constructor
		public DewgongSpecies() : base(
			87,
			"Dewgong",
			Water.Instance, Ice.Instance,
			1.7,
			120.0,
			new PokemonStats(
				90, // HPs
				70, 80, // Attack & Defense
				70, 95, // Spacial Attack & Defense
				70 // Speed
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
				"Headbutt",
				"Horn-Drill",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
				"Hyper-Beam",
				"Strength",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
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
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Sheer-Cold",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Fling",
				"Aqua-Ring",
				"Aqua-Tail",
				"Giga-Impact",
				"Avalanche",
				"Ice-Shard",
				"Captivate",
				"Aqua-Jet",
				"Round",
				"Echoed-Voice",
				"Frost-Breath",
				"Drill-Run",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion
}