using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Nidoran-F Species to store common natural stats of all Nidoran-Fs
	#region Nidoran-FSpecies
	public class NidoranFSpecies : PokemonSpecies
	{
#nullable enable
		private static NidoranFSpecies? _instance = null;
#nullable restore
        public static NidoranFSpecies Instance => _instance ?? (_instance = new NidoranFSpecies());

		#region Nidoran-FSpecies Constructor
		public NidoranFSpecies() : base(
			29,
			"Nidoran-F",
			Poison.Instance,
			0.4,
			7.0,
			new PokemonStats(
				55, // HPs
				47, 52, // Attack & Defense
				40, 40, // Spacial Attack & Defense
				41 // Speed
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
				"Scratch",
				"Cut",
				"Double-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Poison-Sting",
				"Bite",
				"Growl",
				"Supersonic",
				"Disable",
				"Ice-Beam",
				"Blizzard",
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
				"Fury-Swipes",
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
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Beat-Up",
				"Flatter",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Poison-Fang",
				"Aerial-Ace",
				"Poison-Tail",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Toxic-Spikes",
				"Poison-Jab",
				"Shadow-Claw",
				"Captivate",
				"Hone-Claws",
				"Venoshock",
				"Round",
				"Echoed-Voice",
				"Chip-Away",
				"Confide",
				"Venom-Drench"
			};
		}
		#endregion
	}
	#endregion
}