using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Chinchou Species to store common natural stats of all Chinchous
	#region ChinchouSpecies
	public class ChinchouSpecies : PokemonSpecies
	{
#nullable enable
		private static ChinchouSpecies? _instance = null;
#nullable restore
        public static ChinchouSpecies Instance => _instance ?? (_instance = new ChinchouSpecies());

		#region ChinchouSpecies Constructor
		public ChinchouSpecies() : base(
			170,
			"Chinchou",
			Water.Instance, Electric.Instance,
			0.5,
			12.0,
			new PokemonStats(
				75, // HPs
				38, 38, // Attack & Defense
				56, 56, // Spacial Attack & Defense
				67 // Speed
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
				"Take-Down",
				"Double-Edge",
				"Supersonic",
				"Mist",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Psybeam",
				"Bubble-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Agility",
				"Mimic",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
				"Waterfall",
				"Amnesia",
				"Bubble",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Zap-Cannon",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Charge",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Bounce",
				"Shock-Wave",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Sucker-Punch",
				"Aqua-Ring",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Electro-Ball",
				"Soak",
				"Round",
				"Scald",
				"Volt-Switch",
				"Wild-Charge",
				"Ion-Deluge",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}