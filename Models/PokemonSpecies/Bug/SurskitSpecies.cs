using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Surskit Species to store common natural stats of all Surskits
	#region SurskitSpecies
	public class SurskitSpecies : PokemonSpecies
	{
#nullable enable
		private static SurskitSpecies? _instance = null;
#nullable restore
        public static SurskitSpecies Instance => _instance ?? (_instance = new SurskitSpecies());

		#region SurskitSpecies Constructor
		public SurskitSpecies() : base(
			283,
			"Surskit",
			Bug.Instance, Water.Instance,
			0.5,
			1.7,
			new PokemonStats(
				40, // HPs
				30, 32, // Attack & Defense
				50, 52, // Spacial Attack & Defense
				65 // Speed
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
				"Double-Edge",
				"Mist",
				"Hydro-Pump",
				"Ice-Beam",
				"Blizzard",
				"Psybeam",
				"Bubble-Beam",
				"Solar-Beam",
				"String-Shot",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Haze",
				"Swift",
				"Bubble",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Mind-Reader",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Sweet-Scent",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Secret-Power",
				"Signal-Beam",
				"Mud-Shot",
				"Water-Sport",
				"Water-Pulse",
				"Natural-Gift",
				"Captivate",
				"Bug-Bite",
				"Aqua-Jet",
				"Power-Split",
				"Round",
				"Scald",
				"Struggle-Bug",
				"Sticky-Web",
				"Fell-Stinger",
				"Confide",
				"Infestation",
				"Lunge"
			};
		}
		#endregion
	}
	#endregion
}