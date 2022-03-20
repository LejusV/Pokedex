using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tentacruel Species to store common natural stats of all Tentacruels
	#region TentacruelSpecies
	public class TentacruelSpecies : PokemonSpecies
	{
#nullable enable
		private static TentacruelSpecies? _instance = null;
#nullable restore
        public static TentacruelSpecies Instance => _instance ?? (_instance = new TentacruelSpecies());

		#region TentacruelSpecies Constructor
		public TentacruelSpecies() : base(
			73,
			"Tentacruel",
			Water.Instance, Poison.Instance,
			1.6,
			55.0,
			new PokemonStats(
				80, // HPs
				70, 65, // Attack & Defense
				80, 120, // Spacial Attack & Defense
				100 // Speed
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
				"Swords-Dance",
				"Cut",
				"Bind",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Poison-Sting",
				"Supersonic",
				"Acid",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Mega-Drain",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Barrier",
				"Reflect",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Constrict",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Icy-Wind",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Magic-Coat",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Payback",
				"Wring-Out",
				"Toxic-Spikes",
				"Poison-Jab",
				"Giga-Impact",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Acid-Spray",
				"Round",
				"Scald",
				"Hex",
				"Reflect-Type",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}