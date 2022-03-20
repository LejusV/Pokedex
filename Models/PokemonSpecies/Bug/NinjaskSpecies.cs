using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ninjask Species to store common natural stats of all Ninjasks
	#region NinjaskSpecies
	public class NinjaskSpecies : PokemonSpecies
	{
#nullable enable
		private static NinjaskSpecies? _instance = null;
#nullable restore
        public static NinjaskSpecies Instance => _instance ?? (_instance = new NinjaskSpecies());

		#region NinjaskSpecies Constructor
		public NinjaskSpecies() : base(
			291,
			"Ninjask",
			Bug.Instance, Flying.Instance,
			0.8,
			12.0,
			new PokemonStats(
				61, // HPs
				90, 45, // Attack & Defense
				50, 50, // Spacial Attack & Defense
				160 // Speed
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
				"Swords-Dance",
				"Cut",
				"Sand-Attack",
				"Double-Edge",
				"Hyper-Beam",
				"Absorb",
				"Solar-Beam",
				"String-Shot",
				"Dig",
				"Toxic",
				"Agility",
				"Mimic",
				"Screech",
				"Double-Team",
				"Harden",
				"Swift",
				"Leech-Life",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Mind-Reader",
				"Snore",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Hidden-Power",
				"Sunny-Day",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"U-Turn",
				"X-Scissor",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Hone-Claws",
				"Round",
				"Struggle-Bug",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}