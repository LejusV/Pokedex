using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dragalge Species to store common natural stats of all Dragalges
	#region DragalgeSpecies
	public class DragalgeSpecies : PokemonSpecies
	{
#nullable enable
		private static DragalgeSpecies? _instance = null;
#nullable restore
        public static DragalgeSpecies Instance => _instance ?? (_instance = new DragalgeSpecies());

		#region DragalgeSpecies Constructor
		public DragalgeSpecies() : base(
			691,
			"Dragalge",
			Poison.Instance, Dragon.Instance,
			1.8,
			81.5,
			new PokemonStats(
				65, // HPs
				75, 90, // Attack & Defense
				97, 123, // Spacial Attack & Defense
				44 // Speed
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
				"Tackle",
				"Tail-Whip",
				"Acid",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder",
				"Toxic",
				"Double-Team",
				"Smokescreen",
				"Waterfall",
				"Bubble",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Icy-Wind",
				"Outrage",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Shadow-Ball",
				"Hail",
				"Facade",
				"Secret-Power",
				"Dive",
				"Camouflage",
				"Bounce",
				"Poison-Tail",
				"Shock-Wave",
				"Water-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Draco-Meteor",
				"Gunk-Shot",
				"Venoshock",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Dragon-Tail",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}