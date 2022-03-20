using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Nincada Species to store common natural stats of all Nincadas
	#region NincadaSpecies
	public class NincadaSpecies : PokemonSpecies
	{
#nullable enable
		private static NincadaSpecies? _instance = null;
#nullable restore
        public static NincadaSpecies Instance => _instance ?? (_instance = new NincadaSpecies());

		#region NincadaSpecies Constructor
		public NincadaSpecies() : base(
			290,
			"Nincada",
			Bug.Instance, Ground.Instance,
			0.5,
			5.5,
			new PokemonStats(
				31, // HPs
				45, 90, // Attack & Defense
				30, 30, // Spacial Attack & Defense
				40 // Speed
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
				"Gust",
				"Sand-Attack",
				"Double-Edge",
				"Absorb",
				"Solar-Beam",
				"String-Shot",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Bide",
				"Leech-Life",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Mind-Reader",
				"Snore",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Metal-Claw",
				"Hidden-Power",
				"Sunny-Day",
				"Shadow-Ball",
				"Facade",
				"Secret-Power",
				"Silver-Wind",
				"Aerial-Ace",
				"Natural-Gift",
				"Night-Slash",
				"X-Scissor",
				"Bug-Buzz",
				"Bug-Bite",
				"Hone-Claws",
				"Round",
				"Final-Gambit",
				"Struggle-Bug",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}