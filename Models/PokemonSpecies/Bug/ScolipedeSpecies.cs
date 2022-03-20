using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Scolipede Species to store common natural stats of all Scolipedes
	#region ScolipedeSpecies
	public class ScolipedeSpecies : PokemonSpecies
	{
#nullable enable
		private static ScolipedeSpecies? _instance = null;
#nullable restore
        public static ScolipedeSpecies Instance => _instance ?? (_instance = new ScolipedeSpecies());

		#region ScolipedeSpecies Constructor
		public ScolipedeSpecies() : base(
			545,
			"Scolipede",
			Bug.Instance, Poison.Instance,
			2.5,
			200.5,
			new PokemonStats(
				60, // HPs
				100, 89, // Attack & Defense
				55, 69, // Spacial Attack & Defense
				112 // Speed
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
				"Swords-Dance",
				"Cut",
				"Double-Edge",
				"Poison-Sting",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Rest",
				"Rock-Slide",
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
				"Megahorn",
				"Baton-Pass",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Signal-Beam",
				"Iron-Defense",
				"Poison-Tail",
				"Gyro-Ball",
				"Payback",
				"Poison-Jab",
				"Aqua-Tail",
				"X-Scissor",
				"Giga-Impact",
				"Rock-Climb",
				"Bug-Bite",
				"Venoshock",
				"Round",
				"Struggle-Bug",
				"Bulldoze",
				"Steamroller",
				"Confide",
				"Venom-Drench",
				"Infestation",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion
}