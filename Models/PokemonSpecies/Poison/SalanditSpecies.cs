using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Salandit Species to store common natural stats of all Salandits
	#region SalanditSpecies
	public class SalanditSpecies : PokemonSpecies
	{
#nullable enable
		private static SalanditSpecies? _instance = null;
#nullable restore
        public static SalanditSpecies Instance => _instance ?? (_instance = new SalanditSpecies());

		#region SalanditSpecies Constructor
		public SalanditSpecies() : base(
			757,
			"Salandit",
			Poison.Instance, Fire.Instance,
			0.6,
			4.8,
			new PokemonStats(
				48, // HPs
				44, 40, // Attack & Defense
				71, 40, // Spacial Attack & Defense
				77 // Speed
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
				"Double-Slap",
				"Scratch",
				"Sand-Attack",
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
				"Sweet-Scent",
				"Hidden-Power",
				"Fake-Out",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Knock-Off",
				"Snatch",
				"Overheat",
				"Dragon-Claw",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Dragon-Pulse",
				"Nasty-Plot",
				"Shadow-Claw",
				"Venoshock",
				"Flame-Burst",
				"Sludge-Wave",
				"Flame-Charge",
				"Round",
				"Belch",
				"Confide",
				"Venom-Drench"
			};
		}
		#endregion
	}
	#endregion
}