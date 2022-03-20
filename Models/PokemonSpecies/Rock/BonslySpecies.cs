using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Bonsly Species to store common natural stats of all Bonslys
	#region BonslySpecies
	public class BonslySpecies : PokemonSpecies
	{
#nullable enable
		private static BonslySpecies? _instance = null;
#nullable restore
        public static BonslySpecies Instance => _instance ?? (_instance = new BonslySpecies());

		#region BonslySpecies Constructor
		public BonslySpecies() : base(
			438,
			"Bonsly",
			Rock.Instance,
			0.5,
			15.0,
			new PokemonStats(
				50, // HPs
				80, 95, // Attack & Defense
				10, 45, // Spacial Attack & Defense
				10 // Speed
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
				"Slam",
				"Headbutt",
				"Double-Edge",
				"Low-Kick",
				"Counter",
				"Rock-Throw",
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
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Uproar",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Role-Play",
				"Brick-Break",
				"Secret-Power",
				"Fake-Tears",
				"Rock-Tomb",
				"Sand-Tomb",
				"Block",
				"Covet",
				"Calm-Mind",
				"Natural-Gift",
				"Copycat",
				"Sucker-Punch",
				"Rock-Polish",
				"Earth-Power",
				"Captivate",
				"Stealth-Rock",
				"Smack-Down",
				"Foul-Play",
				"After-You",
				"Round",
				"Confide",
				"Tearful-Look"
			};
		}
		#endregion
	}
	#endregion
}