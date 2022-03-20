using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Rampardos Species to store common natural stats of all Rampardoss
	#region RampardosSpecies
	public class RampardosSpecies : PokemonSpecies
	{
#nullable enable
		private static RampardosSpecies? _instance = null;
#nullable restore
        public static RampardosSpecies Instance => _instance ?? (_instance = new RampardosSpecies());

		#region RampardosSpecies Constructor
		public RampardosSpecies() : base(
			409,
			"Rampardos",
			Rock.Instance,
			1.6,
			102.5,
			new PokemonStats(
				97, // HPs
				165, 60, // Attack & Defense
				65, 50, // Spacial Attack & Defense
				58 // Speed
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
				"Fire-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Take-Down",
				"Leer",
				"Roar",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Fling",
				"Rock-Polish",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Head-Smash",
				"Smack-Down",
				"Round",
				"Chip-Away",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}