using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Goodra Species to store common natural stats of all Goodras
	#region GoodraSpecies
	public class GoodraSpecies : PokemonSpecies
	{
#nullable enable
		private static GoodraSpecies? _instance = null;
#nullable restore
        public static GoodraSpecies Instance => _instance ?? (_instance = new GoodraSpecies());

		#region GoodraSpecies Constructor
		public GoodraSpecies() : base(
			706,
			"Goodra",
			Dragon.Instance,
			2.0,
			150.5,
			new PokemonStats(
				90, // HPs
				100, 70, // Attack & Defense
				110, 150, // Spacial Attack & Defense
				80 // Speed
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
				"Fire-Punch",
				"Thunder-Punch",
				"Tackle",
				"Body-Slam",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Absorb",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Bide",
				"Fire-Blast",
				"Bubble",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Outrage",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Secret-Power",
				"Muddy-Water",
				"Shock-Wave",
				"Water-Pulse",
				"Feint",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Draco-Meteor",
				"Power-Whip",
				"Sludge-Wave",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Infestation",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}