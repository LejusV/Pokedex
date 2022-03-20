using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Regigigas Species to store common natural stats of all Regigigass
	#region RegigigasSpecies
	public class RegigigasSpecies : PokemonSpecies
	{
#nullable enable
		private static RegigigasSpecies? _instance = null;
#nullable restore
        public static RegigigasSpecies Instance => _instance ?? (_instance = new RegigigasSpecies());

		#region RegigigasSpecies Constructor
		public RegigigasSpecies() : base(
			486,
			"Regigigas",
			Normal.Instance,
			3.7,
			420.0,
			new PokemonStats(
				110, // HPs
				160, 110, // Attack & Defense
				80, 110, // Spacial Attack & Defense
				100 // Speed
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
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Stomp",
				"Headbutt",
				"Hyper-Beam",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Confuse-Ray",
				"Dizzy-Punch",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Superpower",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Block",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Rock-Polish",
				"Drain-Punch",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Crush-Grip",
				"Wide-Guard",
				"Smack-Down",
				"Heavy-Slam",
				"Round",
				"Retaliate",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}