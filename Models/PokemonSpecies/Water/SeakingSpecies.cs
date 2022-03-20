using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Seaking Species to store common natural stats of all Seakings
	#region SeakingSpecies
	public class SeakingSpecies : PokemonSpecies
	{
#nullable enable
		private static SeakingSpecies? _instance = null;
#nullable restore
        public static SeakingSpecies Instance => _instance ?? (_instance = new SeakingSpecies());

		#region SeakingSpecies Constructor
		public SeakingSpecies() : base(
			119,
			"Seaking",
			Water.Instance,
			1.3,
			39.0,
			new PokemonStats(
				80, // HPs
				92, 65, // Attack & Defense
				65, 80, // Spacial Attack & Defense
				68 // Speed
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
				"Horn-Attack",
				"Fury-Attack",
				"Horn-Drill",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Supersonic",
				"Water-Gun",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Peck",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Bide",
				"Waterfall",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Megahorn",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Bounce",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Aqua-Ring",
				"Poison-Jab",
				"Aqua-Tail",
				"Giga-Impact",
				"Captivate",
				"Soak",
				"Round",
				"Scald",
				"Drill-Run",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion
}