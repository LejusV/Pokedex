using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Qwilfish Species to store common natural stats of all Qwilfishs
	#region QwilfishSpecies
	public class QwilfishSpecies : PokemonSpecies
	{
#nullable enable
		private static QwilfishSpecies? _instance = null;
#nullable restore
        public static QwilfishSpecies Instance => _instance ?? (_instance = new QwilfishSpecies());

		#region QwilfishSpecies Constructor
		public QwilfishSpecies() : base(
			211,
			"Qwilfish",
			Water.Instance, Poison.Instance,
			0.5,
			3.9,
			new PokemonStats(
				65, // HPs
				95, 85, // Attack & Defense
				55, 55, // Spacial Attack & Defense
				85 // Speed
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
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Poison-Sting",
				"Pin-Missile",
				"Supersonic",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Thunder-Wave",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Minimize",
				"Defense-Curl",
				"Haze",
				"Self-Destruct",
				"Waterfall",
				"Swift",
				"Bubble",
				"Explosion",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Spikes",
				"Destiny-Bond",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Shadow-Ball",
				"Whirlpool",
				"Stockpile",
				"Spit-Up",
				"Hail",
				"Facade",
				"Taunt",
				"Revenge",
				"Secret-Power",
				"Dive",
				"Astonish",
				"Signal-Beam",
				"Bounce",
				"Shock-Wave",
				"Water-Pulse",
				"Gyro-Ball",
				"Brine",
				"Natural-Gift",
				"Payback",
				"Toxic-Spikes",
				"Poison-Jab",
				"Aqua-Tail",
				"Captivate",
				"Aqua-Jet",
				"Venoshock",
				"Sludge-Wave",
				"Acid-Spray",
				"Round",
				"Scald",
				"Fell-Stinger",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}