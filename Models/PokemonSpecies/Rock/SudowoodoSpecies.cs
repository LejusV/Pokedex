using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sudowoodo Species to store common natural stats of all Sudowoodos
	#region SudowoodoSpecies
	public class SudowoodoSpecies : PokemonSpecies
	{
#nullable enable
		private static SudowoodoSpecies? _instance = null;
#nullable restore
        public static SudowoodoSpecies Instance => _instance ?? (_instance = new SudowoodoSpecies());

		#region SudowoodoSpecies Constructor
		public SudowoodoSpecies() : base(
			185,
			"Sudowoodo",
			Rock.Instance,
			1.2,
			38.0,
			new PokemonStats(
				70, // HPs
				100, 115, // Attack & Defense
				30, 65, // Spacial Attack & Defense
				30 // Speed
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
				"Slam",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Rock-Throw",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Self-Destruct",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Block",
				"Covet",
				"Calm-Mind",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Copycat",
				"Sucker-Punch",
				"Rock-Polish",
				"Earth-Power",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Wood-Hammer",
				"Head-Smash",
				"Smack-Down",
				"Foul-Play",
				"After-You",
				"Round",
				"Bulldoze",
				"Confide",
				"Power-Up-Punch",
				"Tearful-Look"
			};
		}
		#endregion
	}
	#endregion
}