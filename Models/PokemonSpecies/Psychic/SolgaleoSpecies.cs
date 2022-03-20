using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Solgaleo Species to store common natural stats of all Solgaleos
	#region SolgaleoSpecies
	public class SolgaleoSpecies : PokemonSpecies
	{
#nullable enable
		private static SolgaleoSpecies? _instance = null;
#nullable restore
        public static SolgaleoSpecies Instance => _instance ?? (_instance = new SolgaleoSpecies());

		#region SolgaleoSpecies Constructor
		public SolgaleoSpecies() : base(
			791,
			"Solgaleo",
			Psychic.Instance, Steel.Instance,
			3.4,
			230.0,
			new PokemonStats(
				137, // HPs
				137, 107, // Attack & Defense
				113, 89, // Spacial Attack & Defense
				97 // Speed
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
				"Roar",
				"Flamethrower",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Teleport",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Metal-Claw",
				"Morning-Sun",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Facade",
				"Rock-Tomb",
				"Metal-Sound",
				"Cosmic-Power",
				"Calm-Mind",
				"Wake-Up-Slap",
				"Gyro-Ball",
				"Metal-Burst",
				"Flare-Blitz",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Trick-Room",
				"Iron-Head",
				"Stone-Edge",
				"Wide-Guard",
				"Psyshock",
				"Flame-Charge",
				"Round",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Snarl",
				"Noble-Roar",
				"Confide",
				"Sunsteel-Strike"
			};
		}
		#endregion
	}
	#endregion
}