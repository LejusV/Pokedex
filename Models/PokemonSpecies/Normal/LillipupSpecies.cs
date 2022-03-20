using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Lillipup Species to store common natural stats of all Lillipups
	#region LillipupSpecies
	public class LillipupSpecies : PokemonSpecies
	{
#nullable enable
		private static LillipupSpecies? _instance = null;
#nullable restore
        public static LillipupSpecies Instance => _instance ?? (_instance = new LillipupSpecies());

		#region LillipupSpecies Constructor
		public LillipupSpecies() : base(
			506,
			"Lillipup",
			Normal.Instance,
			0.4,
			4.1,
			new PokemonStats(
				45, // HPs
				60, 45, // Attack & Defense
				25, 45, // Spacial Attack & Defense
				55 // Speed
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
				"Sand-Attack",
				"Tackle",
				"Take-Down",
				"Leer",
				"Bite",
				"Roar",
				"Thunderbolt",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Double-Team",
				"Lick",
				"Rest",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Yawn",
				"Secret-Power",
				"Hyper-Voice",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Aerial-Ace",
				"Howl",
				"Covet",
				"Shock-Wave",
				"Last-Resort",
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"After-You",
				"Round",
				"Retaliate",
				"Work-Up",
				"Wild-Charge",
				"Snarl",
				"Play-Rough",
				"Confide",
				"Baby-Doll-Eyes",
				"Psychic-Fangs"
			};
		}
		#endregion
	}
	#endregion
}