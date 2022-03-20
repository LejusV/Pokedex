using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Goldeen Species to store common natural stats of all Goldeens
	#region GoldeenSpecies
	public class GoldeenSpecies : PokemonSpecies
	{
#nullable enable
		private static GoldeenSpecies? _instance = null;
#nullable restore
        public static GoldeenSpecies Instance => _instance ?? (_instance = new GoldeenSpecies());

		#region GoldeenSpecies Constructor
		public GoldeenSpecies() : base(
			118,
			"Goldeen",
			Water.Instance,
			0.6,
			15.0,
			new PokemonStats(
				45, // HPs
				67, 60, // Attack & Defense
				35, 50, // Spacial Attack & Defense
				63 // Speed
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
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Supersonic",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Psybeam",
				"Bubble-Beam",
				"Peck",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Double-Team",
				"Haze",
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
				"Mud-Sport",
				"Signal-Beam",
				"Bounce",
				"Mud-Shot",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Aqua-Ring",
				"Poison-Jab",
				"Aqua-Tail",
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