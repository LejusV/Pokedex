using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Nidoran-M Species to store common natural stats of all Nidoran-Ms
	#region Nidoran-MSpecies
	public class NidoranMSpecies : PokemonSpecies
	{
#nullable enable
		private static NidoranMSpecies? _instance = null;
#nullable restore
        public static NidoranMSpecies Instance => _instance ?? (_instance = new NidoranMSpecies());

		#region Nidoran-MSpecies Constructor
		public NidoranMSpecies() : base(
			32,
			"Nidoran-M",
			Poison.Instance,
			0.5,
			9.0,
			new PokemonStats(
				46, // HPs
				57, 40, // Attack & Defense
				40, 40, // Spacial Attack & Defense
				50 // Speed
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
				"Supersonic",
				"Disable",
				"Ice-Beam",
				"Blizzard",
				"Peck",
				"Counter",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Dig",
				"Toxic",
				"Confusion",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Reflect",
				"Focus-Energy",
				"Bide",
				"Skull-Bash",
				"Amnesia",
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
				"Beat-Up",
				"Flatter",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Poison-Tail",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Sucker-Punch",
				"Toxic-Spikes",
				"Poison-Jab",
				"Shadow-Claw",
				"Captivate",
				"Head-Smash",
				"Hone-Claws",
				"Venoshock",
				"Round",
				"Echoed-Voice",
				"Chip-Away",
				"Drill-Run",
				"Confide",
				"Venom-Drench",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion
}