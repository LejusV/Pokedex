using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Lurantis Species to store common natural stats of all Lurantiss
	#region LurantisSpecies
	public class LurantisSpecies : PokemonSpecies
	{
#nullable enable
		private static LurantisSpecies? _instance = null;
#nullable restore
        public static LurantisSpecies Instance => _instance ?? (_instance = new LurantisSpecies());

		#region LurantisSpecies Constructor
		public LurantisSpecies() : base(
			754,
			"Lurantis",
			Grass.Instance,
			0.9,
			18.5,
			new PokemonStats(
				70, // HPs
				105, 90, // Attack & Defense
				80, 90, // Spacial Attack & Defense
				45 // Speed
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
				"Hyper-Beam",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Leech-Life",
				"Rest",
				"Slash",
				"Substitute",
				"Protect",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Brick-Break",
				"Aerial-Ace",
				"Leaf-Blade",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Night-Slash",
				"X-Scissor",
				"Energy-Ball",
				"Giga-Impact",
				"Grass-Knot",
				"Low-Sweep",
				"Round",
				"Petal-Blizzard",
				"Confide",
				"Solar-Blade",
				"Leafage"
			};
		}
		#endregion
	}
	#endregion
}