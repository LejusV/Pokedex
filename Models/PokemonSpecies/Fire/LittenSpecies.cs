using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Litten Species to store common natural stats of all Littens
	#region LittenSpecies
	public class LittenSpecies : PokemonSpecies
	{
#nullable enable
		private static LittenSpecies? _instance = null;
#nullable restore
        public static LittenSpecies Instance => _instance ?? (_instance = new LittenSpecies());

		#region LittenSpecies Constructor
		public LittenSpecies() : base(
			725,
			"Litten",
			Fire.Instance,
			0.4,
			4.3,
			new PokemonStats(
				45, // HPs
				65, 40, // Attack & Defense
				60, 40, // Spacial Attack & Defense
				70 // Speed
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
				"Body-Slam",
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
				"Crunch",
				"Fake-Out",
				"Heat-Wave",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Revenge",
				"Overheat",
				"Bulk-Up",
				"U-Turn",
				"Flare-Blitz",
				"Nasty-Plot",
				"Shadow-Claw",
				"Fire-Fang",
				"Flame-Charge",
				"Round",
				"Acrobatics",
				"Fire-Pledge",
				"Work-Up",
				"Confide",
				"Power-Trip"
			};
		}
		#endregion
	}
	#endregion
}