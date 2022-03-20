using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Whirlipede Species to store common natural stats of all Whirlipedes
	#region WhirlipedeSpecies
	public class WhirlipedeSpecies : PokemonSpecies
	{
#nullable enable
		private static WhirlipedeSpecies? _instance = null;
#nullable restore
        public static WhirlipedeSpecies Instance => _instance ?? (_instance = new WhirlipedeSpecies());

		#region WhirlipedeSpecies Constructor
		public WhirlipedeSpecies() : base(
			544,
			"Whirlipede",
			Bug.Instance, Poison.Instance,
			1.2,
			58.5,
			new PokemonStats(
				40, // HPs
				55, 99, // Attack & Defense
				40, 79, // Spacial Attack & Defense
				47 // Speed
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
				"Poison-Sting",
				"Solar-Beam",
				"Toxic",
				"Agility",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Endeavor",
				"Secret-Power",
				"Signal-Beam",
				"Iron-Defense",
				"Poison-Tail",
				"Gyro-Ball",
				"Payback",
				"Poison-Jab",
				"Rock-Climb",
				"Bug-Bite",
				"Venoshock",
				"Round",
				"Struggle-Bug",
				"Steamroller",
				"Confide",
				"Venom-Drench",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}