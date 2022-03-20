using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Tyrantrum Species to store common natural stats of all Tyrantrums
	#region TyrantrumSpecies
	public class TyrantrumSpecies : PokemonSpecies
	{
#nullable enable
		private static TyrantrumSpecies? _instance = null;
#nullable restore
        public static TyrantrumSpecies Instance => _instance ?? (_instance = new TyrantrumSpecies());

		#region TyrantrumSpecies Constructor
		public TyrantrumSpecies() : base(
			697,
			"Tyrantrum",
			Rock.Instance, Dragon.Instance,
			2.5,
			270.0,
			new PokemonStats(
				82, // HPs
				121, 119, // Attack & Defense
				69, 59, // Spacial Attack & Defense
				71 // Speed
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
				"Hyper-Beam",
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
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Dragon-Claw",
				"Rock-Polish",
				"Dark-Pulse",
				"Dragon-Pulse",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Draco-Meteor",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Head-Smash",
				"Hone-Claws",
				"Round",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}