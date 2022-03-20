using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Honedge Species to store common natural stats of all Honedges
	#region HonedgeSpecies
	public class HonedgeSpecies : PokemonSpecies
	{
#nullable enable
		private static HonedgeSpecies? _instance = null;
#nullable restore
        public static HonedgeSpecies Instance => _instance ?? (_instance = new HonedgeSpecies());

		#region HonedgeSpecies Constructor
		public HonedgeSpecies() : base(
			679,
			"Honedge",
			Steel.Instance, Ghost.Instance,
			0.8,
			2.0,
			new PokemonStats(
				45, // HPs
				80, 100, // Attack & Defense
				35, 37, // Spacial Attack & Defense
				28 // Speed
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
				"Swords-Dance",
				"Cut",
				"Tackle",
				"Toxic",
				"Double-Team",
				"Reflect",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"Destiny-Bond",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Shock-Wave",
				"Gyro-Ball",
				"Power-Trick",
				"Magnet-Rise",
				"Night-Slash",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Flash-Cannon",
				"Iron-Head",
				"Wide-Guard",
				"Autotomize",
				"After-You",
				"Retaliate",
				"Sacred-Sword",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}