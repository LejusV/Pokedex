using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Salazzle Species to store common natural stats of all Salazzles
	#region SalazzleSpecies
	public class SalazzleSpecies : PokemonSpecies
	{
#nullable enable
		private static SalazzleSpecies? _instance = null;
#nullable restore
        public static SalazzleSpecies Instance => _instance ?? (_instance = new SalazzleSpecies());

		#region SalazzleSpecies Constructor
		public SalazzleSpecies() : base(
			758,
			"Salazzle",
			Poison.Instance, Fire.Instance,
			1.2,
			22.2,
			new PokemonStats(
				68, // HPs
				64, 60, // Attack & Defense
				111, 60, // Spacial Attack & Defense
				117 // Speed
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
				"Pound",
				"Double-Slap",
				"Disable",
				"Ember",
				"Flamethrower",
				"Dragon-Rage",
				"Toxic",
				"Double-Team",
				"Smog",
				"Fire-Blast",
				"Poison-Gas",
				"Leech-Life",
				"Rest",
				"Substitute",
				"Thief",
				"Protect",
				"Sludge-Bomb",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Sweet-Scent",
				"Hidden-Power",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Overheat",
				"Dragon-Claw",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Dragon-Pulse",
				"Nasty-Plot",
				"Shadow-Claw",
				"Captivate",
				"Venoshock",
				"Flame-Burst",
				"Sludge-Wave",
				"Flame-Charge",
				"Round",
				"Acrobatics",
				"Dragon-Tail",
				"Confide",
				"Venom-Drench"
			};
		}
		#endregion
	}
	#endregion
}