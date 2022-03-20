using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Raichu Species to store common natural stats of all Raichus
	#region RaichuSpecies
	public class RaichuSpecies : PokemonSpecies
	{
#nullable enable
		private static RaichuSpecies? _instance = null;
#nullable restore
        public static RaichuSpecies Instance => _instance ?? (_instance = new RaichuSpecies());

		#region RaichuSpecies Constructor
		public RaichuSpecies() : base(
			26,
			"Raichu",
			Electric.Instance,
			0.8,
			30.0,
			new PokemonStats(
				60, // HPs
				90, 55, // Attack & Defense
				90, 80, // Spacial Attack & Defense
				110 // Speed
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
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Growl",
				"Hyper-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Signal-Beam",
				"Covet",
				"Shock-Wave",
				"Natural-Gift",
				"Fling",
				"Magnet-Rise",
				"Focus-Blast",
				"Giga-Impact",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}