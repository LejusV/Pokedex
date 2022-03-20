using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Nidorino Species to store common natural stats of all Nidorinos
	#region NidorinoSpecies
	public class NidorinoSpecies : PokemonSpecies
	{
#nullable enable
		private static NidorinoSpecies? _instance = null;
#nullable restore
        public static NidorinoSpecies Instance => _instance ?? (_instance = new NidorinoSpecies());

		#region NidorinoSpecies Constructor
		public NidorinoSpecies() : base(
			33,
			"Nidorino",
			Poison.Instance,
			0.9,
			19.5,
			new PokemonStats(
				61, // HPs
				72, 57, // Attack & Defense
				55, 55, // Spacial Attack & Defense
				65 // Speed
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
				"Cut",
				"Double-Kick",
				"Headbutt",
				"Horn-Attack",
				"Fury-Attack",
				"Horn-Drill",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Poison-Sting",
				"Leer",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Peck",
				"Counter",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Reflect",
				"Focus-Energy",
				"Bide",
				"Skull-Bash",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Flatter",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Sucker-Punch",
				"Toxic-Spikes",
				"Poison-Jab",
				"Shadow-Claw",
				"Captivate",
				"Hone-Claws",
				"Venoshock",
				"Round",
				"Echoed-Voice",
				"Drill-Run",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion
}