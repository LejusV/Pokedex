using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pinsir Species to store common natural stats of all Pinsirs
	#region PinsirSpecies
	public class PinsirSpecies : PokemonSpecies
	{
#nullable enable
		private static PinsirSpecies? _instance = null;
#nullable restore
        public static PinsirSpecies Instance => _instance ?? (_instance = new PinsirSpecies());

		#region PinsirSpecies Constructor
		public PinsirSpecies() : base(
			127,
			"Pinsir",
			Bug.Instance,
			1.5,
			55.0,
			new PokemonStats(
				65, // HPs
				125, 100, // Attack & Defense
				55, 70, // Spacial Attack & Defense
				85 // Speed
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
				"Vice-Grip",
				"Guillotine",
				"Swords-Dance",
				"Cut",
				"Bind",
				"Headbutt",
				"Fury-Attack",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Hyper-Beam",
				"Submission",
				"Seismic-Toss",
				"Strength",
				"String-Shot",
				"Earthquake",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Harden",
				"Focus-Energy",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Feint-Attack",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Vital-Throw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Rock-Tomb",
				"Iron-Defense",
				"Bulk-Up",
				"Natural-Gift",
				"Feint",
				"Close-Combat",
				"Fling",
				"Me-First",
				"X-Scissor",
				"Focus-Blast",
				"Giga-Impact",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Bug-Bite",
				"Double-Hit",
				"Smack-Down",
				"Storm-Throw",
				"Round",
				"Struggle-Bug",
				"Bulldoze",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}