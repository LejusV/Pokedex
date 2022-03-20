using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Quilava Species to store common natural stats of all Quilavas
	#region QuilavaSpecies
	public class QuilavaSpecies : PokemonSpecies
	{
#nullable enable
		private static QuilavaSpecies? _instance = null;
#nullable restore
        public static QuilavaSpecies Instance => _instance ?? (_instance = new QuilavaSpecies());

		#region QuilavaSpecies Constructor
		public QuilavaSpecies() : base(
			156,
			"Quilava",
			Fire.Instance,
			0.9,
			19.0,
			new PokemonStats(
				58, // HPs
				64, 58, // Attack & Defense
				80, 65, // Spacial Attack & Defense
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
				"Cut",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Roar",
				"Ember",
				"Flamethrower",
				"Strength",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Defense-Curl",
				"Fire-Blast",
				"Swift",
				"Rest",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Brick-Break",
				"Eruption",
				"Secret-Power",
				"Overheat",
				"Aerial-Ace",
				"Covet",
				"Natural-Gift",
				"Lava-Plume",
				"Captivate",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Inferno",
				"Fire-Pledge",
				"Work-Up",
				"Wild-Charge",
				"Confide",
				"Burn-Up"
			};
		}
		#endregion
	}
	#endregion
}