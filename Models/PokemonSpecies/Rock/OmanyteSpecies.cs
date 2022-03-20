using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Omanyte Species to store common natural stats of all Omanytes
	#region OmanyteSpecies
	public class OmanyteSpecies : PokemonSpecies
	{
#nullable enable
		private static OmanyteSpecies? _instance = null;
#nullable restore
        public static OmanyteSpecies Instance => _instance ?? (_instance = new OmanyteSpecies());

		#region OmanyteSpecies Constructor
		public OmanyteSpecies() : base(
			138,
			"Omanyte",
			Rock.Instance, Water.Instance,
			0.4,
			7.5,
			new PokemonStats(
				35, // HPs
				40, 100, // Attack & Defense
				90, 55, // Spacial Attack & Defense
				35 // Speed
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
				"Bind",
				"Slam",
				"Headbutt",
				"Horn-Attack",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Bite",
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
				"Mimic",
				"Double-Team",
				"Withdraw",
				"Haze",
				"Reflect",
				"Bide",
				"Waterfall",
				"Spike-Cannon",
				"Constrict",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Spikes",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Tickle",
				"Muddy-Water",
				"Iron-Defense",
				"Mud-Shot",
				"Rock-Blast",
				"Water-Pulse",
				"Gyro-Ball",
				"Brine",
				"Natural-Gift",
				"Wring-Out",
				"Toxic-Spikes",
				"Rock-Polish",
				"Earth-Power",
				"Captivate",
				"Stealth-Rock",
				"Smack-Down",
				"Round",
				"Scald",
				"Shell-Smash",
				"Reflect-Type",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}