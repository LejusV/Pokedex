using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Stunfisk Species to store common natural stats of all Stunfisks
	#region StunfiskSpecies
	public class StunfiskSpecies : PokemonSpecies
	{
#nullable enable
		private static StunfiskSpecies? _instance = null;
#nullable restore
        public static StunfiskSpecies Instance => _instance ?? (_instance = new StunfiskSpecies());

		#region StunfiskSpecies Constructor
		public StunfiskSpecies() : base(
			618,
			"Stunfisk",
			Ground.Instance, Electric.Instance,
			0.7,
			11.0,
			new PokemonStats(
				109, // HPs
				66, 84, // Attack & Defense
				81, 99, // Spacial Attack & Defense
				32 // Speed
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
				"Water-Gun",
				"Surf",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Double-Team",
				"Bide",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Spark",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Uproar",
				"Facade",
				"Revenge",
				"Yawn",
				"Endeavor",
				"Secret-Power",
				"Camouflage",
				"Mud-Sport",
				"Astonish",
				"Rock-Tomb",
				"Muddy-Water",
				"Bounce",
				"Mud-Shot",
				"Shock-Wave",
				"Water-Pulse",
				"Payback",
				"Me-First",
				"Magnet-Rise",
				"Aqua-Tail",
				"Earth-Power",
				"Mud-Bomb",
				"Discharge",
				"Stone-Edge",
				"Stealth-Rock",
				"Sludge-Wave",
				"Foul-Play",
				"Round",
				"Scald",
				"Reflect-Type",
				"Bulldoze",
				"Electroweb",
				"Confide",
				"Eerie-Impulse",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}