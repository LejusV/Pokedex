using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tentacool Species to store common natural stats of all Tentacools
	#region TentacoolSpecies
	public class TentacoolSpecies : PokemonSpecies
	{
#nullable enable
		private static TentacoolSpecies? _instance = null;
#nullable restore
        public static TentacoolSpecies Instance => _instance ?? (_instance = new TentacoolSpecies());

		#region TentacoolSpecies Constructor
		public TentacoolSpecies() : base(
			72,
			"Tentacool",
			Water.Instance, Poison.Instance,
			0.9,
			45.5,
			new PokemonStats(
				40, // HPs
				40, 35, // Attack & Defense
				50, 100, // Spacial Attack & Defense
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
				"Aurora-Beam",
				"Mega-Drain",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Confuse-Ray",
				"Barrier",
				"Haze",
				"Reflect",
				"Bide",
				"Waterfall",
				"Skull-Bash",
				"Constrict",
				"Bubble",
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
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Mirror-Coat",
				"Whirlpool",
				"Hail",
				"Facade",
				"Magic-Coat",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Tickle",
				"Muddy-Water",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Acupressure",
				"Payback",
				"Wring-Out",
				"Toxic-Spikes",
				"Aqua-Ring",
				"Poison-Jab",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Acid-Spray",
				"Round",
				"Scald",
				"Hex",
				"Confide",
				"Dazzling-Gleam",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}