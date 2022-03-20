using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Incineroar Species to store common natural stats of all Incineroars
	#region IncineroarSpecies
	public class IncineroarSpecies : PokemonSpecies
	{
#nullable enable
		private static IncineroarSpecies? _instance = null;
#nullable restore
        public static IncineroarSpecies Instance => _instance ?? (_instance = new IncineroarSpecies());

		#region IncineroarSpecies Constructor
		public IncineroarSpecies() : base(
			727,
			"Incineroar",
			Fire.Instance, Dark.Instance,
			1.8,
			83.0,
			new PokemonStats(
				95, // HPs
				115, 90, // Attack & Defense
				80, 90, // Spacial Attack & Defense
				60 // Speed
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
				"Hyper-Beam",
				"Earthquake",
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
				"Cross-Chop",
				"Sunny-Day",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Blast-Burn",
				"Overheat",
				"Bulk-Up",
				"U-Turn",
				"Embargo",
				"Fling",
				"Flare-Blitz",
				"Dark-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Fire-Fang",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Quash",
				"Acrobatics",
				"Fire-Pledge",
				"Bulldoze",
				"Work-Up",
				"Snarl",
				"Confide",
				"Darkest-Lariat",
				"Throat-Chop",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}