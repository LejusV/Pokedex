using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Vespiquen Species to store common natural stats of all Vespiquens
	#region VespiquenSpecies
	public class VespiquenSpecies : PokemonSpecies
	{
#nullable enable
		private static VespiquenSpecies? _instance = null;
#nullable restore
        public static VespiquenSpecies Instance => _instance ?? (_instance = new VespiquenSpecies());

		#region VespiquenSpecies Constructor
		public VespiquenSpecies() : base(
			416,
			"Vespiquen",
			Bug.Instance, Flying.Instance,
			1.2,
			38.5,
			new PokemonStats(
				70, // HPs
				80, 102, // Attack & Defense
				80, 102, // Spacial Attack & Defense
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
				"Cut",
				"Gust",
				"Poison-Sting",
				"Hyper-Beam",
				"String-Shot",
				"Toxic",
				"Double-Team",
				"Confuse-Ray",
				"Swift",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Destiny-Bond",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Sweet-Scent",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Facade",
				"Endeavor",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Fling",
				"Air-Slash",
				"X-Scissor",
				"Power-Gem",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Attack-Order",
				"Defend-Order",
				"Heal-Order",
				"Ominous-Wind",
				"Hone-Claws",
				"Venoshock",
				"Round",
				"Quash",
				"Acrobatics",
				"Struggle-Bug",
				"Fell-Stinger",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}