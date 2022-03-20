using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Nidorina Species to store common natural stats of all Nidorinas
	#region NidorinaSpecies
	public class NidorinaSpecies : PokemonSpecies
	{
#nullable enable
		private static NidorinaSpecies? _instance = null;
#nullable restore
        public static NidorinaSpecies Instance => _instance ?? (_instance = new NidorinaSpecies());

		#region NidorinaSpecies Constructor
		public NidorinaSpecies() : base(
			30,
			"Nidorina",
			Poison.Instance,
			0.8,
			20.0,
			new PokemonStats(
				70, // HPs
				62, 67, // Attack & Defense
				55, 55, // Spacial Attack & Defense
				56 // Speed
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
				"Horn-Drill",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Poison-Sting",
				"Bite",
				"Growl",
				"Water-Gun",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
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
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Flatter",
				"Facade",
				"Helping-Hand",
				"Secret-Power",
				"Poison-Fang",
				"Aerial-Ace",
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
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}