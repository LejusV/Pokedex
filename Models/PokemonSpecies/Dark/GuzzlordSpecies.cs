using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Guzzlord Species to store common natural stats of all Guzzlords
	#region GuzzlordSpecies
	public class GuzzlordSpecies : PokemonSpecies
	{
#nullable enable
		private static GuzzlordSpecies? _instance = null;
#nullable restore
        public static GuzzlordSpecies Instance => _instance ?? (_instance = new GuzzlordSpecies());

		#region GuzzlordSpecies Constructor
		public GuzzlordSpecies() : base(
			799,
			"Guzzlord",
			Dark.Instance, Dragon.Instance,
			5.5,
			888.0,
			new PokemonStats(
				223, // HPs
				101, 53, // Attack & Defense
				97, 53, // Spacial Attack & Defense
				43 // Speed
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
				"Thrash",
				"Bite",
				"Flamethrower",
				"Hyper-Beam",
				"Dragon-Rage",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Protect",
				"Sludge-Bomb",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Crunch",
				"Stockpile",
				"Swallow",
				"Facade",
				"Brick-Break",
				"Rock-Tomb",
				"Dragon-Claw",
				"Hammer-Arm",
				"Gyro-Ball",
				"Payback",
				"Fling",
				"Wring-Out",
				"Gastro-Acid",
				"Poison-Jab",
				"Dark-Pulse",
				"Dragon-Rush",
				"Giga-Impact",
				"Shadow-Claw",
				"Draco-Meteor",
				"Stone-Edge",
				"Wide-Guard",
				"Smack-Down",
				"Sludge-Wave",
				"Heavy-Slam",
				"Round",
				"Bulldoze",
				"Dragon-Tail",
				"Steamroller",
				"Snarl",
				"Belch",
				"Brutal-Swing",
				"Stomping-Tantrum"
			};
		}
		#endregion
	}
	#endregion
}