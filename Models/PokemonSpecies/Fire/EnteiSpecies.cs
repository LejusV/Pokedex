using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Entei Species to store common natural stats of all Enteis
	#region EnteiSpecies
	public class EnteiSpecies : PokemonSpecies
	{
#nullable enable
		private static EnteiSpecies? _instance = null;
#nullable restore
        public static EnteiSpecies Instance => _instance ?? (_instance = new EnteiSpecies());

		#region EnteiSpecies Constructor
		public EnteiSpecies() : base(
			244,
			"Entei",
			Fire.Instance,
			2.1,
			198.0,
			new PokemonStats(
				115, // HPs
				115, 85, // Attack & Defense
				90, 75, // Spacial Attack & Defense
				100 // Speed
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
				"Stomp",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Fire-Blast",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sacred-Fire",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Eruption",
				"Secret-Power",
				"Overheat",
				"Extrasensory",
				"Calm-Mind",
				"Natural-Gift",
				"Giga-Impact",
				"Fire-Fang",
				"Rock-Climb",
				"Lava-Plume",
				"Iron-Head",
				"Stone-Edge",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Quash",
				"Bulldoze",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}