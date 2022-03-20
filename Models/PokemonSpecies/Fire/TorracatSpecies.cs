using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Torracat Species to store common natural stats of all Torracats
	#region TorracatSpecies
	public class TorracatSpecies : PokemonSpecies
	{
#nullable enable
		private static TorracatSpecies? _instance = null;
#nullable restore
        public static TorracatSpecies Instance => _instance ?? (_instance = new TorracatSpecies());

		#region TorracatSpecies Constructor
		public TorracatSpecies() : base(
			726,
			"Torracat",
			Fire.Instance,
			0.7,
			25.0,
			new PokemonStats(
				65, // HPs
				85, 50, // Attack & Defense
				80, 50, // Spacial Attack & Defense
				90 // Speed
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
				"Double-Kick",
				"Thrash",
				"Leer",
				"Bite",
				"Growl",
				"Roar",
				"Ember",
				"Flamethrower",
				"Toxic",
				"Double-Team",
				"Lick",
				"Fire-Blast",
				"Leech-Life",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Protect",
				"Scary-Face",
				"Outrage",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Overheat",
				"Bulk-Up",
				"U-Turn",
				"Flare-Blitz",
				"Shadow-Claw",
				"Fire-Fang",
				"Flame-Charge",
				"Round",
				"Acrobatics",
				"Fire-Pledge",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}