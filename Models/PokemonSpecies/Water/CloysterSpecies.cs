using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cloyster Species to store common natural stats of all Cloysters
	#region CloysterSpecies
	public class CloysterSpecies : PokemonSpecies
	{
#nullable enable
		private static CloysterSpecies? _instance = null;
#nullable restore
        public static CloysterSpecies Instance => _instance ?? (_instance = new CloysterSpecies());

		#region CloysterSpecies Constructor
		public CloysterSpecies() : base(
			91,
			"Cloyster",
			Water.Instance, Ice.Instance,
			1.5,
			132.5,
			new PokemonStats(
				50, // HPs
				95, 180, // Attack & Defense
				85, 45, // Spacial Attack & Defense
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
				"Take-Down",
				"Double-Edge",
				"Supersonic",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Aurora-Beam",
				"Hyper-Beam",
				"Toxic",
				"Rage",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Withdraw",
				"Reflect",
				"Bide",
				"Self-Destruct",
				"Clamp",
				"Swift",
				"Spike-Cannon",
				"Explosion",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Spikes",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Torment",
				"Facade",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Iron-Defense",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Payback",
				"Toxic-Spikes",
				"Poison-Jab",
				"Giga-Impact",
				"Avalanche",
				"Captivate",
				"Round",
				"Shell-Smash",
				"Frost-Breath",
				"Icicle-Crash",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion
}