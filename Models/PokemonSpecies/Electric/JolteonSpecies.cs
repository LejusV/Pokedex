using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Jolteon Species to store common natural stats of all Jolteons
	#region JolteonSpecies
	public class JolteonSpecies : PokemonSpecies
	{
#nullable enable
		private static JolteonSpecies? _instance = null;
#nullable restore
        public static JolteonSpecies Instance => _instance ?? (_instance = new JolteonSpecies());

		#region JolteonSpecies Constructor
		public JolteonSpecies() : base(
			135,
			"Jolteon",
			Electric.Instance,
			0.8,
			24.5,
			new PokemonStats(
				65, // HPs
				65, 60, // Attack & Defense
				110, 95, // Spacial Attack & Defense
				130 // Speed
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
				"Double-Kick",
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Pin-Missile",
				"Roar",
				"Hyper-Beam",
				"Strength",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Hyper-Voice",
				"Signal-Beam",
				"Covet",
				"Shock-Wave",
				"Natural-Gift",
				"Last-Resort",
				"Magnet-Rise",
				"Giga-Impact",
				"Thunder-Fang",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Volt-Switch",
				"Work-Up",
				"Wild-Charge",
				"Confide",
				"Baby-Doll-Eyes"
			};
		}
		#endregion
	}
	#endregion
}