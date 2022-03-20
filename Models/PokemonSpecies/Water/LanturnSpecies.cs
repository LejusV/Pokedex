using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Lanturn Species to store common natural stats of all Lanturns
	#region LanturnSpecies
	public class LanturnSpecies : PokemonSpecies
	{
#nullable enable
		private static LanturnSpecies? _instance = null;
#nullable restore
        public static LanturnSpecies Instance => _instance ?? (_instance = new LanturnSpecies());

		#region LanturnSpecies Constructor
		public LanturnSpecies() : base(
			171,
			"Lanturn",
			Water.Instance, Electric.Instance,
			1.2,
			22.5,
			new PokemonStats(
				125, // HPs
				58, 58, // Attack & Defense
				76, 76, // Spacial Attack & Defense
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
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Waterfall",
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
				"Stockpile",
				"Spit-Up",
				"Swallow",
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
				"Aqua-Tail",
				"Giga-Impact",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Electro-Ball",
				"Round",
				"Scald",
				"Volt-Switch",
				"Wild-Charge",
				"Ion-Deluge",
				"Confide",
				"Eerie-Impulse",
				"Dazzling-Gleam",
				"Spotlight"
			};
		}
		#endregion
	}
	#endregion
}