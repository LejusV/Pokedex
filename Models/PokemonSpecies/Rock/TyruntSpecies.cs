using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tyrunt Species to store common natural stats of all Tyrunts
	#region TyruntSpecies
	public class TyruntSpecies : PokemonSpecies
	{
#nullable enable
		private static TyruntSpecies? _instance = null;
#nullable restore
        public static TyruntSpecies Instance => _instance ?? (_instance = new TyruntSpecies());

		#region TyruntSpecies Constructor
		public TyruntSpecies() : base(
			696,
			"Tyrunt",
			Rock.Instance, Dragon.Instance,
			0.8,
			26.0,
			new PokemonStats(
				58, // HPs
				89, 77, // Attack & Defense
				45, 45, // Spacial Attack & Defense
				48 // Speed
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
				"Stomp",
				"Horn-Drill",
				"Tackle",
				"Thrash",
				"Tail-Whip",
				"Bite",
				"Roar",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Outrage",
				"Sandstorm",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Hyper-Voice",
				"Poison-Fang",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Dragon-Claw",
				"Dragon-Dance",
				"Rock-Polish",
				"Dark-Pulse",
				"Dragon-Pulse",
				"Earth-Power",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Zen-Headbutt",
				"Draco-Meteor",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Hone-Claws",
				"Round",
				"Bulldoze",
				"Dragon-Tail",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}