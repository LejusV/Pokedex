using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Shellder Species to store common natural stats of all Shellders
	#region ShellderSpecies
	public class ShellderSpecies : PokemonSpecies
	{
#nullable enable
		private static ShellderSpecies? _instance = null;
#nullable restore
        public static ShellderSpecies Instance => _instance ?? (_instance = new ShellderSpecies());

		#region ShellderSpecies Constructor
		public ShellderSpecies() : base(
			90,
			"Shellder",
			Water.Instance,
			0.3,
			4.0,
			new PokemonStats(
				30, // HPs
				65, 100, // Attack & Defense
				45, 25, // Spacial Attack & Defense
				40 // Speed
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
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Twineedle",
				"Leer",
				"Supersonic",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
				"Toxic",
				"Rage",
				"Teleport",
				"Mimic",
				"Screech",
				"Double-Team",
				"Withdraw",
				"Barrier",
				"Reflect",
				"Bide",
				"Self-Destruct",
				"Clamp",
				"Swift",
				"Explosion",
				"Rest",
				"Tri-Attack",
				"Substitute",
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
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Icicle-Spear",
				"Iron-Defense",
				"Mud-Shot",
				"Rock-Blast",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Payback",
				"Aqua-Ring",
				"Avalanche",
				"Ice-Shard",
				"Captivate",
				"Round",
				"Shell-Smash",
				"Razor-Shell",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}